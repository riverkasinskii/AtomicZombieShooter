using Atomic.Contexts;
using UnityEngine;

namespace SampleGame
{
    public sealed class UIContextInstaller : SceneContextInstaller<IUIContext>
    {       
        [SerializeField]
        private PresenterSystemInstaller _presenterInstaller;

        protected override void Install(IUIContext context)
        {
            _presenterInstaller.Install(context);
        }
    }
}
