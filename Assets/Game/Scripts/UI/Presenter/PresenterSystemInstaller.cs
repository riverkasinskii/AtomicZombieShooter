using Atomic.Contexts;
using Game.UI;
using System;
using UnityEngine;

namespace SampleGame
{
    [Serializable]
    public sealed class PresenterSystemInstaller : IContextInstaller<IUIContext>
    {       
        [SerializeField]
        private HealthScreen _healthScreen;

        [SerializeField]
        private StatView _ammoView;

        [SerializeField]
        private StatView _healthView;

        [SerializeField]
        private KillsView _killsView;

        public void Install(IUIContext context)
        {
            GameContext gameContext = GameContext.Instance;            
                        
            context.AddController(new HealthScreenPresenter(gameContext, _healthScreen));
            context.AddController(new AmmoViewPresenter(gameContext, _ammoView));
            context.AddController(new HealthViewPresenter(gameContext, _healthView));
            context.AddController(new KillsViewPresenter(gameContext, _killsView));
        }
    }
}