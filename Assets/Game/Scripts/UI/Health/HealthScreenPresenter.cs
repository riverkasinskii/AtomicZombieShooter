using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using Game.UI;

namespace SampleGame
{
    public sealed class HealthScreenPresenter : IContextInit<IUIContext>, IContextDispose<IUIContext>
    {
        private readonly HealthScreen _healthScreen;
        private readonly IGameContext _gameContext;

        private IEntity _character;        
        private IValue<int> _maxHealth;
        private IReactiveVariable<int> _currentHealth;        

        public HealthScreenPresenter(IGameContext gameContext, HealthScreen healthScreen)
        {
            _gameContext = gameContext;
            _healthScreen = healthScreen;
        }         
                
        public void Init(IUIContext context)
        {
            _character = _gameContext.GetCharacter();
            _maxHealth = _character.GetMaxHealth();
            _currentHealth = _character.GetCurrentHealth();            

            _currentHealth.Subscribe(HealthChanged);

            UIRender(_currentHealth.Value);
        }

        public void Dispose(IUIContext context)
        {
            _currentHealth.Unsubscribe(HealthChanged);            
        }

        private void HealthChanged(int damage)
        {
            UIRender(damage);
        }

        private void UIRender(int damage)
        {
            _healthScreen.TakeDamage(damage);

            float currentHealth = _currentHealth.Value;
            float maxHealth = _maxHealth.Value;
            float percent = (currentHealth / maxHealth);
            _healthScreen.ChangePercent(percent);
        }
    }
}
