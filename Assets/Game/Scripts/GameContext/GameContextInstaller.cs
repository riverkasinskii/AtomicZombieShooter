using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class GameContextInstaller : SceneContextInstaller<IGameContext>
    {
        [SerializeField]
        private SceneEntity _character;

        [SerializeField]
        private BulletSystemInstaller _bulletInstaller;
                        
        [SerializeField]
        private Transform _worldTransform;

        protected override void Install(IGameContext context)
        {            
            context.AddCharacter(_character);
            context.AddWorldTransform(_worldTransform);            

            _bulletInstaller.Install(context);            
        }
    }
}
