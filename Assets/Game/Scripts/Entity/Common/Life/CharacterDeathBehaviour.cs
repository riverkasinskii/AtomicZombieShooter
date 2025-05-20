using Atomic.Elements;
using Atomic.Entities;

namespace SampleGame
{
    public sealed class CharacterDeathBehaviour : IEntityInit, IEntityDispose
    {
        private IEntity _character;
        private IReactiveVariable<int> _healthEvent;

        public void Init(in IEntity entity)
        {                        
            _character = entity;
            _healthEvent = entity.GetCurrentHealth();

            _healthEvent.Subscribe(DeathListener);
        }

        public void Dispose(in IEntity entity)
        {
            _healthEvent.Unsubscribe(DeathListener);
        }

        private void DeathListener(int value)
        {
            if (value <= 0)
            {                
                _character.GetDestroyAction().Invoke();
                _character.GetCollider().enabled = false;
            }
        }
    }
}