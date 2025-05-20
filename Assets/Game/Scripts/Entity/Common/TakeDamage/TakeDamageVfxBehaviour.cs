using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class TakeDamageVfxBehaviour : IEntityInit, IEntityDispose
    {
        private readonly ParticleSystem _vfx;

        private IEvent<int> _healthEvent;

        public TakeDamageVfxBehaviour(ParticleSystem vfx)
        {
            _vfx = vfx;
        }

        public void Init(in IEntity entity)
        {
            _healthEvent = entity.GetHealthEvent();

            _healthEvent.Subscribe(OnTakeDamage);
        }

        public void Dispose(in IEntity entity)
        {
            _healthEvent.Unsubscribe(OnTakeDamage);
        }

        private void OnTakeDamage(int value)
        {
            _vfx.Play();
        }
    }
}