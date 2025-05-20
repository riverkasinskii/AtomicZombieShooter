using Atomic.Elements;
using Atomic.Entities;
using Modules.Gameplay;
using UnityEngine;

namespace SampleGame
{
    public sealed class BulletInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private float _moveSpeed = 45;

        [SerializeField]
        private int _damage = 1;

        [SerializeField]
        private CollisionEventReceiver _collision;

        [SerializeField]
        private float _lifetime = 3;        
        
        public override void Install(IEntity entity)
        {
            GameContext gameContext = GameContext.Instance;
                        
            entity.AddTransform(transform);
            entity.AddGameObject(gameObject);
            entity.AddDamage(new ReactiveInt(_damage));
                        
            entity.AddLifetime(new Cooldown(_lifetime, _lifetime));
            entity.AddBulletDestroyAction(new BaseAction(() => SpawnBulletUseCase.UnspawnBullet(gameContext, entity)));

            entity.AddMoveSpeed(new ReactiveFloat(_moveSpeed));
            entity.AddMoveDirection(new ReactiveVariable<Vector3>());            
            entity.AddCollision(_collision);

            entity.AddBehaviour<BulletLifetimeBehaviour>();
            entity.AddBehaviour<MoveTowardsBehaviour>();
            entity.AddBehaviour<BulletCollisionBehaviour>();            
        }
    }
}
