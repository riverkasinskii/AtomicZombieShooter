using Atomic.Elements;
using Atomic.Entities;
using Modules.Gameplay;
using UnityEngine;

namespace SampleGame
{
    public sealed class EnemyInstaller : SceneEntityInstaller
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
        private int _maxHealth = 10;

        [SerializeField]
        private int _currentHealth = 3;

        [SerializeField]
        private TriggerEventReceiver _trigger;

        [SerializeField]
        private float _moveSpeed = 1;

        [SerializeField]
        private float _angularSpeed = 5;

        [SerializeField]
        private SceneEntity _weapon;

        public override void Install(IEntity entity)
        {
            InstallMain(entity);
            InstallLife(entity);
            InstallArea(entity);
            InstallMove(entity);
            InstallRotate(entity);
            InstallWeapon(entity);
            InstallCombat(entity);
        }

        private void InstallMain(IEntity entity)
        {            
            entity.AddGameObject(_gameObject);
            entity.AddTransform(_transform);
            entity.AddRigidbody(_rigidbody);
            entity.AddCollider(_collider);
            entity.AddDamageableTag();            
            entity.AddTarget(null);
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
            GameContext gameContext = GameContext.Instance;            
            entity.AddBehaviour(new EnemyDeathBehaviour(gameContext));
        }

        private void InstallArea(IEntity entity)
        {
            entity.AddTrigger(_trigger);
        }

        private void InstallMove(IEntity entity)
        {
            entity.AddMoveableTag();
            entity.AddMoveSpeed(new ReactiveFloat(_moveSpeed));
            entity.AddMoveState(new ReactiveBool());
            entity.AddMinTargetDistance(new ReactiveFloat(float.MaxValue));
            entity.AddMoveCondition(new AndExpression(
                () => HealthUseCase.IsAlive(entity),
                () => !MoveUseCase.MinDistance(entity),
                () => entity.GetMoveState().Value
                ));

            entity.AddBehaviour<EnemyMoveBehaviour>();
        }

        private void InstallRotate(IEntity entity)
        {
            entity.AddAngularSpeed(new BaseFunction<float>(() => _angularSpeed));
            entity.AddRotateCondition(new AndExpression(
                () => HealthUseCase.IsAlive(entity)
                ));
            entity.AddBehaviour<EnemyRotateBehaviour>();
        }

        private void InstallWeapon(IEntity entity)
        {
            entity.AddCurrentWeapon(new ReactiveVariable<IEntity>(_weapon));
        }

        private void InstallCombat(IEntity entity)
        {
            entity.AddFireEvent(new BaseEvent());
            entity.AddFireState(new BaseVariable<bool>(true));
            entity.AddFireCondition(new AndExpression(
                () => HealthUseCase.IsAlive(entity),
                () => HealthUseCase.TargetIsAlive(entity),
                () => MoveUseCase.MinDistance(entity)                
            ));

            entity.AddFireAction(new BaseAction(() =>
            {
                if (entity.GetFireCondition().Invoke() && entity.GetFireState().Value)
                {                    
                    entity.GetFireState().Value = false;
                    entity.GetFireEvent()?.Invoke();                    
                }
            }));

            entity.AddBehaviour<EnemyFireBehaviour>();
        }
    }
}