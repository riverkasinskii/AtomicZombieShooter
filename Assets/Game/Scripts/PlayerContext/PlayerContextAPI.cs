/**
* Code generation. Don't modify! 
**/

using Atomic.Contexts;
using System.Runtime.CompilerServices;
using Atomic.Entities;
using Modules.Common;

namespace SampleGame
{
	public static class PlayerContextAPI
	{


		///Values
		public const int MoveJoystick = -1686028204; // Joystick
		public const int AttackJoystick = 1168591300; // Joystick


		///Value Extensions

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Joystick GetMoveJoystick(this IPlayerContext obj) => obj.GetValue<Joystick>(MoveJoystick);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveJoystick(this IPlayerContext obj, out Joystick value) => obj.TryGetValue(MoveJoystick, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMoveJoystick(this IPlayerContext obj, Joystick value) => obj.AddValue(MoveJoystick, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveJoystick(this IPlayerContext obj) => obj.HasValue(MoveJoystick);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveJoystick(this IPlayerContext obj) => obj.DelValue(MoveJoystick);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveJoystick(this IPlayerContext obj, Joystick value) => obj.SetValue(MoveJoystick, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Joystick GetAttackJoystick(this IPlayerContext obj) => obj.GetValue<Joystick>(AttackJoystick);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAttackJoystick(this IPlayerContext obj, out Joystick value) => obj.TryGetValue(AttackJoystick, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAttackJoystick(this IPlayerContext obj, Joystick value) => obj.AddValue(AttackJoystick, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAttackJoystick(this IPlayerContext obj) => obj.HasValue(AttackJoystick);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAttackJoystick(this IPlayerContext obj) => obj.DelValue(AttackJoystick);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAttackJoystick(this IPlayerContext obj, Joystick value) => obj.SetValue(AttackJoystick, value);
    }
}
