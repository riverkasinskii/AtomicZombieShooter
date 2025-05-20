using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class FireAnimBehaviour : IEntityInit, IEntityDispose
    {
        private static int _isFiringHash;

        private Animator _animator;        
        private IEvent _fireEvent;        

        public FireAnimBehaviour(string isFiringHash)
        {            
            _isFiringHash = Animator.StringToHash(isFiringHash);
        }

        public void Init(in IEntity entity)
        {            
            _animator = entity.GetAnimator();
            _fireEvent = entity.GetFireEvent();            
            _fireEvent.Subscribe(OnFire);
        }

        public void Dispose(in IEntity entity)
        {            
            _fireEvent.Unsubscribe(OnFire);
        }

        private void OnFire()
        {            
            _animator.SetTrigger(_isFiringHash);
        }
    }
}
