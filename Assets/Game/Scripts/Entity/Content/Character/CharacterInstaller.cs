using Atomic.Elements;
using Atomic.Entities;
using Modules.Gameplay;
using UnityEngine;

namespace SampleGame
{
    public sealed class CharacterInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private GameObject _gameObject;

        [SerializeField]
        private Transform _transform;

        [SerializeField]
        private Rigidbody _rigidbody;

        [SerializeField]
        private Collider _collider;

        [SerializeField]
        private float _moveSpeed = 3;

        [SerializeField]
        private float _angularSpeed = 15;

        [SerializeField]
        private int _maxHealth = 10;

        [SerializeField]
        private int _currentHealth = 3;
                        
        [SerializeField]
        private SceneEntity _weapon;

        [SerializeField]
        private TriggerEventReceiver _triggerReceiver;

        public override void Install(IEntity entity)
        {
            InstallMain(entity);
            InstallMove(entity);
            InstallRotate(entity);
            InstallLife(entity);      
            InstallWeapon(entity);
            InstallCombat(entity);
            InstallItem(entity);
        }
                
        private void InstallMain(IEntity entity)
        {                                 
            entity.AddGameObject(_gameObject);
            entity.AddTransform(_transform);
            entity.AddRigidbody(_rigidbody);
            entity.AddCollider(_collider);
            entity.AddCharactableTag();
        }

        private void InstallMove(IEntity entity)
        {
            entity.AddMoveableTag();            
            entity.AddMoveSpeed(new ReactiveFloat(_moveSpeed));
            entity.AddMoveCondition(new AndExpression(
                () => HealthUseCase.IsAlive(entity),
                () => entity.GetMoveDirection().Value != Vector3.zero
                ));
            entity.AddMoveDirection(new ReactiveVector3());     
            entity.AddBehaviour<MoveTowardsBehaviour>();            
        }

        private void InstallRotate(IEntity entity)
        {
            entity.AddAngularSpeed(new BaseFunction<float>(() => _angularSpeed));
            entity.AddAngularDirection(new ReactiveVector3());
            entity.AddRotateCondition(new AndExpression(() => HealthUseCase.IsAlive(entity)));
            entity.AddBehaviour<RotateTowardsBehaviour>();
        }

        private void InstallLife(IEntity entity)
        {            
            entity.AddMaxHealth(new Const<int>(_maxHealth));            
            entity.AddCurrentHealth(new ReactiveVariable<int>(_currentHealth));
            entity.AddHealthEvent(new BaseEvent<int>());
            entity.AddDestroyEvent(new BaseEvent());
            entity.AddDestroyAction(new BaseAction(() =>
            {
                entity.GetDestroyEvent()?.Invoke();                
            }));    
            
            entity.AddBehaviour<CharacterDeathBehaviour>();
        }

        private void InstallWeapon(IEntity entity)
        {
            entity.AddCurrentWeapon(new ReactiveVariable<IEntity>(_weapon));                        
        }

        private void InstallCombat(IEntity entity)
        {            
            entity.AddFireEvent(new BaseEvent());            
            entity.AddFireCondition(new AndExpression(
                    () => HealthUseCase.IsAlive(entity),                    
                    () =>
                    {
                        IEntity weapon = entity.GetCurrentWeapon().Value;                        
                        return weapon != null && weapon.GetFireCondition().Invoke() && weapon.GetGunStore().Value > 0;
                    }                    
            ));

            entity.AddInputAction(new BaseAction(() =>
            {
                if (entity.GetFireCondition().Invoke())
                {
                    entity.GetFireEvent()?.Invoke();
                }                
            }));

            entity.AddFireAction(new BaseAction(() =>
            {
                if (entity.GetFireCondition().Invoke())
                {                    
                    entity.GetCurrentWeapon().Value?.GetWeaponFireAction().Invoke();                    
                }
            }));  
            
            entity.AddCurrentKills(new ReactiveVariable<int>());        
        }

        private void InstallItem(IEntity entity)
        {
            entity.AddTrigger(_triggerReceiver);
            entity.AddBehaviour(new CharacterItemBehaviour());
        }
    }
}

