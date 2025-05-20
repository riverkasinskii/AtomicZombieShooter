using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using Game.UI;

namespace SampleGame
{
    public sealed class AmmoViewPresenter : IContextInit<IUIContext>, IContextDispose<IUIContext>
    {
        private readonly StatView _ammoView;
        private readonly IGameContext _gameContext;

        private IEntity _character;        
        private IReactiveValue<int> _currentGunStore;

        public AmmoViewPresenter(IGameContext gameContext, StatView ammoView)
        {
            _gameContext = gameContext;
            _ammoView = ammoView;
        }

        public void Init(IUIContext context)
        {
            _character = _gameContext.GetCharacter();            
            _currentGunStore = _character.GetCurrentWeapon().Value.GetGunStore();
                        
            _currentGunStore.Subscribe(InitGunStore);

            InitGunStore(_currentGunStore.Value);
        }

        public void Dispose(IUIContext context)
        {            
            _currentGunStore.Unsubscribe(InitGunStore);
        }

        private void InitGunStore(int value)
        {
            _ammoView.SetText(value.ToString());
        }
    }
}