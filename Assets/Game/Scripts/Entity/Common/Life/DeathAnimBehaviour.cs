using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class DeathAnimBehaviour : IEntityInit, IEntityDispose
    {
        private static int _isDeathHash;        
        private Animator _animator;
        private IEvent _destroyEvent;

        public DeathAnimBehaviour(string isDeathHash)
        {
            _isDeathHash = Animator.StringToHash(isDeathHash);
        }

        public void Init(in IEntity entity)
        {
            _animator = entity.GetAnimator();
            _destroyEvent = entity.GetDestroyEvent();
            _destroyEvent.Subscribe(OnDead);
        }
                
        public void Dispose(in IEntity entity)
        {
            _destroyEvent.Unsubscribe(OnDead);
        }

        private void OnDead()
        {            
            _animator.SetBool(_isDeathHash, true);            
        }                
    }
}
