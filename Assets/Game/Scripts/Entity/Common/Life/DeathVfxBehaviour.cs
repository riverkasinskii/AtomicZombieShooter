using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class DeathVfxBehaviour : IEntityInit, IEntityDispose
    {        
        private IEvent<int> _healthEvent;

        private readonly ParticleSystem _vfx;

        public DeathVfxBehaviour(ParticleSystem vfx)
        {
            _vfx = vfx;
        }

        public void Init(in IEntity entity)
        {            
            _healthEvent = entity.GetHealthEvent();            

            _healthEvent.Subscribe(OnHealthEnded);
        }

        public void Dispose(in IEntity entity)
        {
            _healthEvent.Unsubscribe(OnHealthEnded);
        }

        private void OnHealthEnded(int value)
        {
            _vfx.Play();            
        }
    }
}
