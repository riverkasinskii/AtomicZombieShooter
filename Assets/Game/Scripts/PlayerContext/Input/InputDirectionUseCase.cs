using Modules.Common;
using UnityEngine;

namespace SampleGame
{
    public static class InputDirectionUseCase
    {        
        public static Vector3 GetMoveDirection(in Joystick joystick)
        {            
            Vector3 newDirection = new(joystick.Horizontal, 0, joystick.Vertical);
            return newDirection;                        
        }

        public static Vector3 GetAttackDirection(in Joystick joystick)
        {            
            Vector3 newDirection = new(joystick.Horizontal, 0, joystick.Vertical);
            return newDirection;
        }

        public static bool IsPressed(in Joystick joystick)
        {            
            return joystick.IsPressed;
        }
    }
}
