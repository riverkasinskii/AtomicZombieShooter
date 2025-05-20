using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using Game.UI;

namespace SampleGame
{
    public sealed class KillsViewPresenter : IContextInit<IUIContext>, IContextDispose<IUIContext>
    {
        private readonly KillsView _killsView;
        private readonly IGameContext _gameContext;

        private IEntity _character;        
        private IReactiveVariable<int> _currentKills;        

        public KillsViewPresenter(IGameContext gameContext, KillsView killsView)
        {
            _gameContext = gameContext;
            _killsView = killsView;
        }

        public void Init(IUIContext context)
        {
            _character = _gameContext.GetCharacter();            
            _currentKills = _character.GetCurrentKills();            
                        
            _currentKills.Subscribe(KillsChanged);

            KillsChanged(_currentKills.Value);
        }

        public void Dispose(IUIContext context)
        {            
            _currentKills.Unsubscribe(KillsChanged);
        }

        private void KillsChanged(int value)
        {
            _killsView.SetText(value.ToString());
        }
    }
}