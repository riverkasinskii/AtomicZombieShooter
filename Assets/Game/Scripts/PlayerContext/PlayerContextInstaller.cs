using Atomic.Contexts;
using Modules.Common;
using UnityEngine;

namespace SampleGame
{
    public sealed class PlayerContextInstaller : SceneContextInstaller<IPlayerContext>
    {
        [SerializeField]
        private CharacterSystemInstaller _characterInstaller;
       
        [SerializeField]
        private Joystick _attackJoystick;

        [SerializeField]
        private Joystick _moveJoystick;

        protected override void Install(IPlayerContext context)
        {
            context.AddMoveJoystick(_moveJoystick);     
            context.AddAttackJoystick(_attackJoystick);

            _characterInstaller.Install(context);                        
        }
    }
}
