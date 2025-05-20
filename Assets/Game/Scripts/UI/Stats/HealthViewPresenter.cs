using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using Game.UI;

namespace SampleGame
{
    public sealed class HealthViewPresenter : IContextInit<IUIContext>, IContextDispose<IUIContext>
    {
        private readonly StatView _healthView;
        private readonly IGameContext _gameContext;

        private IEntity _character;        
        private IReactiveVariable<int> _currentHealth;
        private IValue<int> _maxHealth;

        public HealthViewPresenter(IGameContext gameContext, StatView healthView)
        {
            _gameContext = gameContext;
            _healthView = healthView;
        }

        public void Init(IUIContext context)
        {
            _character = _gameContext.GetCharacter();            
            _currentHealth = _character.GetCurrentHealth();   
            _maxHealth = _character.GetMaxHealth();                        
            _currentHealth.Subscribe(HealthChanged);
            UIRender(_currentHealth.Value);
        }

        public void Dispose(IUIContext context)
        {            
            _currentHealth.Unsubscribe(HealthChanged);
        }

        private void HealthChanged(int value)
        {
            UIRender(value);
        }

        private void UIRender(int value)
        {
            if (value >= 0)
            {
                _healthView.SetText(value.ToString());

                float currentHealth = _currentHealth.Value;
                float maxHealth = _maxHealth.Value;

                float progress = currentHealth / maxHealth;
                _healthView.SetProgress(progress);
            }            
        }
    }
}
