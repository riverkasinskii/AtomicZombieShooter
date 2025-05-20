using Atomic.Elements;
using Atomic.Entities;
using Modules.Gameplay;
using UnityEngine;

namespace SampleGame
{
    public sealed class BulletCollisionBehaviour : IEntityInit, IEntityDispose
    {
        private IAction _destroyAction;
        private CollisionEventReceiver _collision;
        private IValue<int> _damage;        

        public void Init(in IEntity entity)
        {
            _destroyAction = entity.GetBulletDestroyAction();
            _damage = entity.GetDamage();          
            _collision = entity.GetCollision();

            _collision.OnEntered += OnCollisionEntered;
        }

        public void Dispose(in IEntity entity)
        {
            _collision.OnEntered -= OnCollisionEntered;
        }

        private void OnCollisionEntered(Collision collision)
        {
            int damage = _damage.Value;
                        
            if (collision.gameObject.TryGetComponent(out IEntity target) && TakeDamageUseCase.TakeDamage(target, damage))
            {
                target.GetHealthEvent()?.Invoke(damage);
                _destroyAction.Invoke();
            }                
        }                
    }
}
