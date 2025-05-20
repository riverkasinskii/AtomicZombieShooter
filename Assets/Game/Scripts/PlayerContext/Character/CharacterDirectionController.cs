using Atomic.Contexts;
using Atomic.Entities;
using Modules.Common;

namespace SampleGame
{
    public sealed class CharacterDirectionController : IContextInit<IPlayerContext>, IContextUpdate
    {
        private Joystick _joystick;
        private IEntity _character;
        private readonly IGameContext _gameContext;     
        
        public CharacterDirectionController(IGameContext gameContext)
        {
            _gameContext = gameContext;
        }

        public void Init(IPlayerContext context)
        {
            _character = _gameContext.GetCharacter();
            _joystick = context.GetMoveJoystick();
        }

        public void OnUpdate(IContext context, float deltaTime)
        {
            _character.GetMoveDirection().Value = InputDirectionUseCase.GetMoveDirection(_joystick);
            _character.GetAngularDirection().Value = InputDirectionUseCase.GetMoveDirection(_joystick);            
        }
    }
}
