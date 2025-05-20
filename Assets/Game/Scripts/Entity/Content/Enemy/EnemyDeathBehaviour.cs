using Atomic.Elements;
using Atomic.Entities;

namespace SampleGame
{
    public sealed class EnemyDeathBehaviour : IEntityInit, IEntityDispose
    {
        private readonly IGameContext _gameContext;

        private IEntity _enemy;
        private IEntity _character;
        private IReactiveVariable<int> _healthEvent;

        public EnemyDeathBehaviour(IGameContext gameContext) 
        {
            _gameContext = gameContext;
        }

        public void Init(in IEntity entity)
        {
            _enemy = entity;
            _character = _gameContext.GetCharacter();
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
                _character.GetCurrentKills().Value += 1;
                _enemy.GetDestroyAction()?.Invoke();
                _enemy.GetCollider().enabled = false;
            }
        }
    }
}