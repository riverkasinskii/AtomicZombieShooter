using Atomic.Contexts;
using Modules.Gameplay;
using System;
using UnityEngine;

namespace SampleGame
{
    [Serializable]
    public sealed class CharacterSystemInstaller : IContextInstaller<IPlayerContext>
    {        
        [SerializeField]
        private float _fireDuration = 0.5f;

        public void Install(IPlayerContext context)
        {
            GameContext gameContext = GameContext.Instance;            
                        
            context.AddController(new CharacterDirectionController(gameContext));
            context.AddController(new CharacterFireController(gameContext, new Cooldown(_fireDuration, _fireDuration)));
        }
    }
}
