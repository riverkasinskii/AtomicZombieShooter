using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class PistolVfxBehaviour : IEntityInit, IEntityDispose
    {
        private IEvent _fireEvent;

        private readonly ParticleSystem _vfx;

        public PistolVfxBehaviour(ParticleSystem vfx)
        {
            _vfx = vfx;
        }

        public void Init(in IEntity entity)
        {
            _fireEvent = entity.GetFireEvent();

            _fireEvent.Subscribe(OnFired);
        }

        public void Dispose(in IEntity entity)
        {
            _fireEvent.Unsubscribe(OnFired);
        }

        private void OnFired()
        {
            _vfx.Play();
        }
    }
}
