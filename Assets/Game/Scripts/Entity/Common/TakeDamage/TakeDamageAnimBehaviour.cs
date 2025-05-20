using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class TakeDamageAnimBehaviour : IEntityInit, IEntityDispose
    {
        private static int _isTakeDamageHash;

        private Animator _animator;
        private IEvent<int> _healthEvent;

        public TakeDamageAnimBehaviour(string isTakeDamageHash)
        {
            _isTakeDamageHash = Animator.StringToHash(isTakeDamageHash);
        }

        public void Init(in IEntity entity)
        {
            _animator = entity.GetAnimator();
            _healthEvent = entity.GetHealthEvent();
            _healthEvent.Subscribe(OnTakeDamage);
        }

        public void Dispose(in IEntity entity)
        {
            _healthEvent.Unsubscribe(OnTakeDamage);
        }

        private void OnTakeDamage(int value)
        {            
            if (value > 0)
            {                
                _animator.SetTrigger(_isTakeDamageHash);
            }            
        }
    }
}
