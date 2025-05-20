using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public enum WeaponType
    {
        Melee,
        Range
    }

    public abstract class WeaponInstaller : SceneEntityInstaller
    {                        
        [SerializeField]
        private WeaponType _weaponType; 

        public override void Install(IEntity entity)
        {
            GameContext gameContext = GameContext.Instance;

            entity.AddGameObject(gameObject);
            entity.AddTransform(transform);            

            InstallWeapon(entity, gameContext);            
        }

        private void InstallWeapon(IEntity entity, GameContext gameContext)
        {                        
            entity.AddFireCondition(new AndExpression());
            entity.AddWeaponType(new Const<WeaponType>(_weaponType));
            entity.AddWeaponFireAction(new BaseAction(() =>
            {
                if (entity.GetFireCondition().Invoke())
                {
                    AttackUseCase.Attack(entity, gameContext);
                }
            }));
        }            
    }             
}