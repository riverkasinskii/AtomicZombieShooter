using Atomic.Contexts;
using Atomic.Entities;
using Modules.Common;
using Modules.Gameplay;

namespace SampleGame
{
    public sealed class CharacterFireController : IContextInit<IPlayerContext>, IContextUpdate
    {
        private readonly Cooldown _cooldown;
        private readonly IGameContext _gameContext;

        private IEntity _character;
        private Joystick _joystick;        

        public CharacterFireController(IGameContext gameContext, Cooldown cooldown)
        {
            _gameContext = gameContext;
            _cooldown = cooldown;
        }
                
        public void Init(IPlayerContext context)
        {
            _character = _gameContext.GetCharacter();
            _joystick = context.GetAttackJoystick();        
        }

        public void OnUpdate(IContext context, float deltaTime)
        {                        
            if (InputDirectionUseCase.IsPressed(_joystick))
            {
                _character.GetAngularDirection().Value = InputDirectionUseCase.GetAttackDirection(_joystick);
                RotateUseCase.RotateTowards(_character, _character.GetAngularDirection().Value, deltaTime);

                _cooldown.Tick(deltaTime);
                if (!_cooldown.IsExpired())
                {
                    return;
                }
                _character.GetInputAction()?.Invoke();
                _cooldown.Reset();
            }      
        }
    }
}
