using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class VfxItemBehaviour : IEntityInit, IEntityDispose, IEntityUpdate
    {
        private bool _isStarting = false;
        private readonly ParticleSystem _vfx;
        private IEvent _pickUpEvent;

        public VfxItemBehaviour(ParticleSystem vfx)
        {
            _vfx = vfx;
        }

        public void Init(in IEntity entity)
        {
            _pickUpEvent = entity.GetPickUpEvent();
            _pickUpEvent.Subscribe(OnPickUpEvent);
        }

        public void Dispose(in IEntity entity)
        {
            _pickUpEvent.Unsubscribe(OnPickUpEvent);
        }

        private void OnPickUpEvent()
        {            
            _vfx.Play();
            _isStarting = true;
        }

        public void OnUpdate(in IEntity entity, in float deltaTime)
        {
            if (_isStarting && _vfx.isStopped)
            {
                entity.GetItemDestroyAction()?.Invoke();
            }
        }
    }
}
