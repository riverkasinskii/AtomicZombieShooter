/**
* Code generation. Don't modify! 
**/

using Atomic.Entities;
using System.Runtime.CompilerServices;
using UnityEngine;
using Atomic.Elements;
using Modules.Gameplay;

namespace SampleGame
{
	public static class EntityAPI
	{
		///Tags
		public const int Moveable = 448011500;
		public const int Damageable = 563499515;
		public const int Charactable = -790967438;
		public const int Pickupable = -470866833;


		///Values
		public const int GameObject = 1482111001; // GameObject
		public const int Transform = -180157682; // Transform
		public const int Rigidbody = -2101481708; // Rigidbody
		public const int Collider = 860563329; // Collider
		public const int Target = 1103309514; // IEntity
		public const int MaxHealth = 1923500305; // IValue<int>
		public const int CurrentHealth = 1412363848; // IReactiveVariable<int>
		public const int Lifetime = -997109026; // Cooldown
		public const int DestroyAction = 85938956; // IAction
		public const int DestroyEvent = 1525282958; // IEvent
		public const int HealthEvent = 1012075984; // IEvent<int>
		public const int MoveSpeed = 526065662; // IReactiveVariable<float>
		public const int MoveState = -1276234765; // IReactiveVariable<bool>
		public const int MoveCondition = 1466174948; // IExpression<bool>
		public const int MoveDirection = -721923052; // IReactiveVariable<Vector3>
		public const int ForwardDirection = -597461024; // IReactiveVariable<float>
		public const int MinTargetDistance = -1954854838; // IReactiveVariable<float>
		public const int AngularSpeed = -1089183267; // IValue<float>
		public const int AngularDirection = -1725439556; // IReactiveVariable<Vector3>
		public const int RotateCondition = 1109699557; // IExpression<bool>
		public const int Damage = 375673178; // IReactiveVariable<int>
		public const int CurrentWeapon = -205032771; // IReactiveVariable<IEntity>
		public const int CurrentKills = 1677840928; // IReactiveVariable<int>
		public const int FireCondition = -280402907; // IExpression<bool>
		public const int FireEvent = -1683597082; // IEvent
		public const int InputAction = -197516709; // IAction
		public const int FireAction = 1186461126; // IAction
		public const int FirePoint = 397255013; // Transform
		public const int FireState = 60522682; // IVariable<bool>
		public const int Animator = -1714818978; // Animator
		public const int AudioSource = 907064781; // AudioSource
		public const int Collision = -650338019; // CollisionEventReceiver
		public const int Trigger = -707381567; // TriggerEventReceiver
		public const int GunStore = 845153621; // IReactiveVariable<int>
		public const int WeaponPrefab = 504707019; // SceneEntity
		public const int WeaponFireAction = -19054336; // IAction
		public const int WeaponFireCondition = 1470459285; // IExpression<bool>
		public const int WeaponType = -1936256502; // IValue<WeaponType>
		public const int DetectRadius = 1261701180; // IValue<float>
		public const int MaxBulletSpread = 2018890938; // IValue<Vector3>
		public const int PickUpEvent = -1876534383; // IEvent
		public const int ItemAction = -1348305608; // IAction<IEntity>
		public const int ItemDestroyAction = -1094844770; // IAction
		public const int BulletDestroyAction = 1051289009; // IAction


		///Tag Extensions

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveableTag(this IEntity obj) => obj.HasTag(Moveable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMoveableTag(this IEntity obj) => obj.AddTag(Moveable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveableTag(this IEntity obj) => obj.DelTag(Moveable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDamageableTag(this IEntity obj) => obj.HasTag(Damageable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddDamageableTag(this IEntity obj) => obj.AddTag(Damageable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDamageableTag(this IEntity obj) => obj.DelTag(Damageable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCharactableTag(this IEntity obj) => obj.HasTag(Charactable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCharactableTag(this IEntity obj) => obj.AddTag(Charactable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCharactableTag(this IEntity obj) => obj.DelTag(Charactable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPickupableTag(this IEntity obj) => obj.HasTag(Pickupable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddPickupableTag(this IEntity obj) => obj.AddTag(Pickupable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPickupableTag(this IEntity obj) => obj.DelTag(Pickupable);


		///Value Extensions

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static GameObject GetGameObject(this IEntity obj) => obj.GetValue<GameObject>(GameObject);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetGameObject(this IEntity obj, out GameObject value) => obj.TryGetValue(GameObject, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddGameObject(this IEntity obj, GameObject value) => obj.AddValue(GameObject, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasGameObject(this IEntity obj) => obj.HasValue(GameObject);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelGameObject(this IEntity obj) => obj.DelValue(GameObject);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetGameObject(this IEntity obj, GameObject value) => obj.SetValue(GameObject, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Transform GetTransform(this IEntity obj) => obj.GetValue<Transform>(Transform);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTransform(this IEntity obj, out Transform value) => obj.TryGetValue(Transform, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddTransform(this IEntity obj, Transform value) => obj.AddValue(Transform, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTransform(this IEntity obj) => obj.HasValue(Transform);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTransform(this IEntity obj) => obj.DelValue(Transform);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTransform(this IEntity obj, Transform value) => obj.SetValue(Transform, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Rigidbody GetRigidbody(this IEntity obj) => obj.GetValue<Rigidbody>(Rigidbody);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetRigidbody(this IEntity obj, out Rigidbody value) => obj.TryGetValue(Rigidbody, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddRigidbody(this IEntity obj, Rigidbody value) => obj.AddValue(Rigidbody, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasRigidbody(this IEntity obj) => obj.HasValue(Rigidbody);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelRigidbody(this IEntity obj) => obj.DelValue(Rigidbody);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetRigidbody(this IEntity obj, Rigidbody value) => obj.SetValue(Rigidbody, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Collider GetCollider(this IEntity obj) => obj.GetValue<Collider>(Collider);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCollider(this IEntity obj, out Collider value) => obj.TryGetValue(Collider, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCollider(this IEntity obj, Collider value) => obj.AddValue(Collider, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCollider(this IEntity obj) => obj.HasValue(Collider);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCollider(this IEntity obj) => obj.DelValue(Collider);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCollider(this IEntity obj, Collider value) => obj.SetValue(Collider, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEntity GetTarget(this IEntity obj) => obj.GetValue<IEntity>(Target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTarget(this IEntity obj, out IEntity value) => obj.TryGetValue(Target, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddTarget(this IEntity obj, IEntity value) => obj.AddValue(Target, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTarget(this IEntity obj) => obj.HasValue(Target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTarget(this IEntity obj) => obj.DelValue(Target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTarget(this IEntity obj, IEntity value) => obj.SetValue(Target, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<int> GetMaxHealth(this IEntity obj) => obj.GetValue<IValue<int>>(MaxHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMaxHealth(this IEntity obj, out IValue<int> value) => obj.TryGetValue(MaxHealth, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMaxHealth(this IEntity obj, IValue<int> value) => obj.AddValue(MaxHealth, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMaxHealth(this IEntity obj) => obj.HasValue(MaxHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMaxHealth(this IEntity obj) => obj.DelValue(MaxHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMaxHealth(this IEntity obj, IValue<int> value) => obj.SetValue(MaxHealth, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<int> GetCurrentHealth(this IEntity obj) => obj.GetValue<IReactiveVariable<int>>(CurrentHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCurrentHealth(this IEntity obj, out IReactiveVariable<int> value) => obj.TryGetValue(CurrentHealth, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCurrentHealth(this IEntity obj, IReactiveVariable<int> value) => obj.AddValue(CurrentHealth, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCurrentHealth(this IEntity obj) => obj.HasValue(CurrentHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCurrentHealth(this IEntity obj) => obj.DelValue(CurrentHealth);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCurrentHealth(this IEntity obj, IReactiveVariable<int> value) => obj.SetValue(CurrentHealth, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Cooldown GetLifetime(this IEntity obj) => obj.GetValue<Cooldown>(Lifetime);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetLifetime(this IEntity obj, out Cooldown value) => obj.TryGetValue(Lifetime, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddLifetime(this IEntity obj, Cooldown value) => obj.AddValue(Lifetime, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasLifetime(this IEntity obj) => obj.HasValue(Lifetime);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelLifetime(this IEntity obj) => obj.DelValue(Lifetime);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetLifetime(this IEntity obj, Cooldown value) => obj.SetValue(Lifetime, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAction GetDestroyAction(this IEntity obj) => obj.GetValue<IAction>(DestroyAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetDestroyAction(this IEntity obj, out IAction value) => obj.TryGetValue(DestroyAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddDestroyAction(this IEntity obj, IAction value) => obj.AddValue(DestroyAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDestroyAction(this IEntity obj) => obj.HasValue(DestroyAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDestroyAction(this IEntity obj) => obj.DelValue(DestroyAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetDestroyAction(this IEntity obj, IAction value) => obj.SetValue(DestroyAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent GetDestroyEvent(this IEntity obj) => obj.GetValue<IEvent>(DestroyEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetDestroyEvent(this IEntity obj, out IEvent value) => obj.TryGetValue(DestroyEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddDestroyEvent(this IEntity obj, IEvent value) => obj.AddValue(DestroyEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDestroyEvent(this IEntity obj) => obj.HasValue(DestroyEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDestroyEvent(this IEntity obj) => obj.DelValue(DestroyEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetDestroyEvent(this IEntity obj, IEvent value) => obj.SetValue(DestroyEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent<int> GetHealthEvent(this IEntity obj) => obj.GetValue<IEvent<int>>(HealthEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetHealthEvent(this IEntity obj, out IEvent<int> value) => obj.TryGetValue(HealthEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddHealthEvent(this IEntity obj, IEvent<int> value) => obj.AddValue(HealthEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasHealthEvent(this IEntity obj) => obj.HasValue(HealthEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelHealthEvent(this IEntity obj) => obj.DelValue(HealthEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetHealthEvent(this IEntity obj, IEvent<int> value) => obj.SetValue(HealthEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<float> GetMoveSpeed(this IEntity obj) => obj.GetValue<IReactiveVariable<float>>(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveSpeed(this IEntity obj, out IReactiveVariable<float> value) => obj.TryGetValue(MoveSpeed, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMoveSpeed(this IEntity obj, IReactiveVariable<float> value) => obj.AddValue(MoveSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveSpeed(this IEntity obj) => obj.HasValue(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveSpeed(this IEntity obj) => obj.DelValue(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveSpeed(this IEntity obj, IReactiveVariable<float> value) => obj.SetValue(MoveSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<bool> GetMoveState(this IEntity obj) => obj.GetValue<IReactiveVariable<bool>>(MoveState);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveState(this IEntity obj, out IReactiveVariable<bool> value) => obj.TryGetValue(MoveState, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMoveState(this IEntity obj, IReactiveVariable<bool> value) => obj.AddValue(MoveState, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveState(this IEntity obj) => obj.HasValue(MoveState);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveState(this IEntity obj) => obj.DelValue(MoveState);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveState(this IEntity obj, IReactiveVariable<bool> value) => obj.SetValue(MoveState, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IExpression<bool> GetMoveCondition(this IEntity obj) => obj.GetValue<IExpression<bool>>(MoveCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveCondition(this IEntity obj, out IExpression<bool> value) => obj.TryGetValue(MoveCondition, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMoveCondition(this IEntity obj, IExpression<bool> value) => obj.AddValue(MoveCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveCondition(this IEntity obj) => obj.HasValue(MoveCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveCondition(this IEntity obj) => obj.DelValue(MoveCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveCondition(this IEntity obj, IExpression<bool> value) => obj.SetValue(MoveCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<Vector3> GetMoveDirection(this IEntity obj) => obj.GetValue<IReactiveVariable<Vector3>>(MoveDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveDirection(this IEntity obj, out IReactiveVariable<Vector3> value) => obj.TryGetValue(MoveDirection, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMoveDirection(this IEntity obj, IReactiveVariable<Vector3> value) => obj.AddValue(MoveDirection, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveDirection(this IEntity obj) => obj.HasValue(MoveDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveDirection(this IEntity obj) => obj.DelValue(MoveDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveDirection(this IEntity obj, IReactiveVariable<Vector3> value) => obj.SetValue(MoveDirection, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<float> GetForwardDirection(this IEntity obj) => obj.GetValue<IReactiveVariable<float>>(ForwardDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetForwardDirection(this IEntity obj, out IReactiveVariable<float> value) => obj.TryGetValue(ForwardDirection, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddForwardDirection(this IEntity obj, IReactiveVariable<float> value) => obj.AddValue(ForwardDirection, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasForwardDirection(this IEntity obj) => obj.HasValue(ForwardDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelForwardDirection(this IEntity obj) => obj.DelValue(ForwardDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetForwardDirection(this IEntity obj, IReactiveVariable<float> value) => obj.SetValue(ForwardDirection, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<float> GetMinTargetDistance(this IEntity obj) => obj.GetValue<IReactiveVariable<float>>(MinTargetDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMinTargetDistance(this IEntity obj, out IReactiveVariable<float> value) => obj.TryGetValue(MinTargetDistance, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMinTargetDistance(this IEntity obj, IReactiveVariable<float> value) => obj.AddValue(MinTargetDistance, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMinTargetDistance(this IEntity obj) => obj.HasValue(MinTargetDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMinTargetDistance(this IEntity obj) => obj.DelValue(MinTargetDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMinTargetDistance(this IEntity obj, IReactiveVariable<float> value) => obj.SetValue(MinTargetDistance, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<float> GetAngularSpeed(this IEntity obj) => obj.GetValue<IValue<float>>(AngularSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAngularSpeed(this IEntity obj, out IValue<float> value) => obj.TryGetValue(AngularSpeed, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAngularSpeed(this IEntity obj, IValue<float> value) => obj.AddValue(AngularSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAngularSpeed(this IEntity obj) => obj.HasValue(AngularSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAngularSpeed(this IEntity obj) => obj.DelValue(AngularSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAngularSpeed(this IEntity obj, IValue<float> value) => obj.SetValue(AngularSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<Vector3> GetAngularDirection(this IEntity obj) => obj.GetValue<IReactiveVariable<Vector3>>(AngularDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAngularDirection(this IEntity obj, out IReactiveVariable<Vector3> value) => obj.TryGetValue(AngularDirection, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAngularDirection(this IEntity obj, IReactiveVariable<Vector3> value) => obj.AddValue(AngularDirection, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAngularDirection(this IEntity obj) => obj.HasValue(AngularDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAngularDirection(this IEntity obj) => obj.DelValue(AngularDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAngularDirection(this IEntity obj, IReactiveVariable<Vector3> value) => obj.SetValue(AngularDirection, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IExpression<bool> GetRotateCondition(this IEntity obj) => obj.GetValue<IExpression<bool>>(RotateCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetRotateCondition(this IEntity obj, out IExpression<bool> value) => obj.TryGetValue(RotateCondition, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddRotateCondition(this IEntity obj, IExpression<bool> value) => obj.AddValue(RotateCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasRotateCondition(this IEntity obj) => obj.HasValue(RotateCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelRotateCondition(this IEntity obj) => obj.DelValue(RotateCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetRotateCondition(this IEntity obj, IExpression<bool> value) => obj.SetValue(RotateCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<int> GetDamage(this IEntity obj) => obj.GetValue<IReactiveVariable<int>>(Damage);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetDamage(this IEntity obj, out IReactiveVariable<int> value) => obj.TryGetValue(Damage, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddDamage(this IEntity obj, IReactiveVariable<int> value) => obj.AddValue(Damage, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDamage(this IEntity obj) => obj.HasValue(Damage);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDamage(this IEntity obj) => obj.DelValue(Damage);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetDamage(this IEntity obj, IReactiveVariable<int> value) => obj.SetValue(Damage, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<IEntity> GetCurrentWeapon(this IEntity obj) => obj.GetValue<IReactiveVariable<IEntity>>(CurrentWeapon);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCurrentWeapon(this IEntity obj, out IReactiveVariable<IEntity> value) => obj.TryGetValue(CurrentWeapon, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCurrentWeapon(this IEntity obj, IReactiveVariable<IEntity> value) => obj.AddValue(CurrentWeapon, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCurrentWeapon(this IEntity obj) => obj.HasValue(CurrentWeapon);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCurrentWeapon(this IEntity obj) => obj.DelValue(CurrentWeapon);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCurrentWeapon(this IEntity obj, IReactiveVariable<IEntity> value) => obj.SetValue(CurrentWeapon, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<int> GetCurrentKills(this IEntity obj) => obj.GetValue<IReactiveVariable<int>>(CurrentKills);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCurrentKills(this IEntity obj, out IReactiveVariable<int> value) => obj.TryGetValue(CurrentKills, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCurrentKills(this IEntity obj, IReactiveVariable<int> value) => obj.AddValue(CurrentKills, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCurrentKills(this IEntity obj) => obj.HasValue(CurrentKills);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCurrentKills(this IEntity obj) => obj.DelValue(CurrentKills);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCurrentKills(this IEntity obj, IReactiveVariable<int> value) => obj.SetValue(CurrentKills, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IExpression<bool> GetFireCondition(this IEntity obj) => obj.GetValue<IExpression<bool>>(FireCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetFireCondition(this IEntity obj, out IExpression<bool> value) => obj.TryGetValue(FireCondition, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddFireCondition(this IEntity obj, IExpression<bool> value) => obj.AddValue(FireCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasFireCondition(this IEntity obj) => obj.HasValue(FireCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelFireCondition(this IEntity obj) => obj.DelValue(FireCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetFireCondition(this IEntity obj, IExpression<bool> value) => obj.SetValue(FireCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent GetFireEvent(this IEntity obj) => obj.GetValue<IEvent>(FireEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetFireEvent(this IEntity obj, out IEvent value) => obj.TryGetValue(FireEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddFireEvent(this IEntity obj, IEvent value) => obj.AddValue(FireEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasFireEvent(this IEntity obj) => obj.HasValue(FireEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelFireEvent(this IEntity obj) => obj.DelValue(FireEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetFireEvent(this IEntity obj, IEvent value) => obj.SetValue(FireEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAction GetInputAction(this IEntity obj) => obj.GetValue<IAction>(InputAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetInputAction(this IEntity obj, out IAction value) => obj.TryGetValue(InputAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddInputAction(this IEntity obj, IAction value) => obj.AddValue(InputAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasInputAction(this IEntity obj) => obj.HasValue(InputAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelInputAction(this IEntity obj) => obj.DelValue(InputAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetInputAction(this IEntity obj, IAction value) => obj.SetValue(InputAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAction GetFireAction(this IEntity obj) => obj.GetValue<IAction>(FireAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetFireAction(this IEntity obj, out IAction value) => obj.TryGetValue(FireAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddFireAction(this IEntity obj, IAction value) => obj.AddValue(FireAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasFireAction(this IEntity obj) => obj.HasValue(FireAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelFireAction(this IEntity obj) => obj.DelValue(FireAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetFireAction(this IEntity obj, IAction value) => obj.SetValue(FireAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Transform GetFirePoint(this IEntity obj) => obj.GetValue<Transform>(FirePoint);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetFirePoint(this IEntity obj, out Transform value) => obj.TryGetValue(FirePoint, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddFirePoint(this IEntity obj, Transform value) => obj.AddValue(FirePoint, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasFirePoint(this IEntity obj) => obj.HasValue(FirePoint);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelFirePoint(this IEntity obj) => obj.DelValue(FirePoint);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetFirePoint(this IEntity obj, Transform value) => obj.SetValue(FirePoint, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IVariable<bool> GetFireState(this IEntity obj) => obj.GetValue<IVariable<bool>>(FireState);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetFireState(this IEntity obj, out IVariable<bool> value) => obj.TryGetValue(FireState, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddFireState(this IEntity obj, IVariable<bool> value) => obj.AddValue(FireState, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasFireState(this IEntity obj) => obj.HasValue(FireState);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelFireState(this IEntity obj) => obj.DelValue(FireState);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetFireState(this IEntity obj, IVariable<bool> value) => obj.SetValue(FireState, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Animator GetAnimator(this IEntity obj) => obj.GetValue<Animator>(Animator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAnimator(this IEntity obj, out Animator value) => obj.TryGetValue(Animator, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAnimator(this IEntity obj, Animator value) => obj.AddValue(Animator, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAnimator(this IEntity obj) => obj.HasValue(Animator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAnimator(this IEntity obj) => obj.DelValue(Animator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAnimator(this IEntity obj, Animator value) => obj.SetValue(Animator, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static AudioSource GetAudioSource(this IEntity obj) => obj.GetValue<AudioSource>(AudioSource);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAudioSource(this IEntity obj, out AudioSource value) => obj.TryGetValue(AudioSource, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAudioSource(this IEntity obj, AudioSource value) => obj.AddValue(AudioSource, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAudioSource(this IEntity obj) => obj.HasValue(AudioSource);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAudioSource(this IEntity obj) => obj.DelValue(AudioSource);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAudioSource(this IEntity obj, AudioSource value) => obj.SetValue(AudioSource, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static CollisionEventReceiver GetCollision(this IEntity obj) => obj.GetValue<CollisionEventReceiver>(Collision);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCollision(this IEntity obj, out CollisionEventReceiver value) => obj.TryGetValue(Collision, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCollision(this IEntity obj, CollisionEventReceiver value) => obj.AddValue(Collision, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCollision(this IEntity obj) => obj.HasValue(Collision);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCollision(this IEntity obj) => obj.DelValue(Collision);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCollision(this IEntity obj, CollisionEventReceiver value) => obj.SetValue(Collision, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TriggerEventReceiver GetTrigger(this IEntity obj) => obj.GetValue<TriggerEventReceiver>(Trigger);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTrigger(this IEntity obj, out TriggerEventReceiver value) => obj.TryGetValue(Trigger, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddTrigger(this IEntity obj, TriggerEventReceiver value) => obj.AddValue(Trigger, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTrigger(this IEntity obj) => obj.HasValue(Trigger);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTrigger(this IEntity obj) => obj.DelValue(Trigger);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTrigger(this IEntity obj, TriggerEventReceiver value) => obj.SetValue(Trigger, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<int> GetGunStore(this IEntity obj) => obj.GetValue<IReactiveVariable<int>>(GunStore);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetGunStore(this IEntity obj, out IReactiveVariable<int> value) => obj.TryGetValue(GunStore, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddGunStore(this IEntity obj, IReactiveVariable<int> value) => obj.AddValue(GunStore, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasGunStore(this IEntity obj) => obj.HasValue(GunStore);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelGunStore(this IEntity obj) => obj.DelValue(GunStore);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetGunStore(this IEntity obj, IReactiveVariable<int> value) => obj.SetValue(GunStore, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static SceneEntity GetWeaponPrefab(this IEntity obj) => obj.GetValue<SceneEntity>(WeaponPrefab);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetWeaponPrefab(this IEntity obj, out SceneEntity value) => obj.TryGetValue(WeaponPrefab, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddWeaponPrefab(this IEntity obj, SceneEntity value) => obj.AddValue(WeaponPrefab, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasWeaponPrefab(this IEntity obj) => obj.HasValue(WeaponPrefab);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelWeaponPrefab(this IEntity obj) => obj.DelValue(WeaponPrefab);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWeaponPrefab(this IEntity obj, SceneEntity value) => obj.SetValue(WeaponPrefab, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAction GetWeaponFireAction(this IEntity obj) => obj.GetValue<IAction>(WeaponFireAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetWeaponFireAction(this IEntity obj, out IAction value) => obj.TryGetValue(WeaponFireAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddWeaponFireAction(this IEntity obj, IAction value) => obj.AddValue(WeaponFireAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasWeaponFireAction(this IEntity obj) => obj.HasValue(WeaponFireAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelWeaponFireAction(this IEntity obj) => obj.DelValue(WeaponFireAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWeaponFireAction(this IEntity obj, IAction value) => obj.SetValue(WeaponFireAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IExpression<bool> GetWeaponFireCondition(this IEntity obj) => obj.GetValue<IExpression<bool>>(WeaponFireCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetWeaponFireCondition(this IEntity obj, out IExpression<bool> value) => obj.TryGetValue(WeaponFireCondition, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddWeaponFireCondition(this IEntity obj, IExpression<bool> value) => obj.AddValue(WeaponFireCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasWeaponFireCondition(this IEntity obj) => obj.HasValue(WeaponFireCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelWeaponFireCondition(this IEntity obj) => obj.DelValue(WeaponFireCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWeaponFireCondition(this IEntity obj, IExpression<bool> value) => obj.SetValue(WeaponFireCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<WeaponType> GetWeaponType(this IEntity obj) => obj.GetValue<IValue<WeaponType>>(WeaponType);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetWeaponType(this IEntity obj, out IValue<WeaponType> value) => obj.TryGetValue(WeaponType, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddWeaponType(this IEntity obj, IValue<WeaponType> value) => obj.AddValue(WeaponType, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasWeaponType(this IEntity obj) => obj.HasValue(WeaponType);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelWeaponType(this IEntity obj) => obj.DelValue(WeaponType);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWeaponType(this IEntity obj, IValue<WeaponType> value) => obj.SetValue(WeaponType, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<float> GetDetectRadius(this IEntity obj) => obj.GetValue<IValue<float>>(DetectRadius);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetDetectRadius(this IEntity obj, out IValue<float> value) => obj.TryGetValue(DetectRadius, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddDetectRadius(this IEntity obj, IValue<float> value) => obj.AddValue(DetectRadius, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDetectRadius(this IEntity obj) => obj.HasValue(DetectRadius);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDetectRadius(this IEntity obj) => obj.DelValue(DetectRadius);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetDetectRadius(this IEntity obj, IValue<float> value) => obj.SetValue(DetectRadius, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<Vector3> GetMaxBulletSpread(this IEntity obj) => obj.GetValue<IValue<Vector3>>(MaxBulletSpread);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMaxBulletSpread(this IEntity obj, out IValue<Vector3> value) => obj.TryGetValue(MaxBulletSpread, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMaxBulletSpread(this IEntity obj, IValue<Vector3> value) => obj.AddValue(MaxBulletSpread, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMaxBulletSpread(this IEntity obj) => obj.HasValue(MaxBulletSpread);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMaxBulletSpread(this IEntity obj) => obj.DelValue(MaxBulletSpread);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMaxBulletSpread(this IEntity obj, IValue<Vector3> value) => obj.SetValue(MaxBulletSpread, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent GetPickUpEvent(this IEntity obj) => obj.GetValue<IEvent>(PickUpEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPickUpEvent(this IEntity obj, out IEvent value) => obj.TryGetValue(PickUpEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddPickUpEvent(this IEntity obj, IEvent value) => obj.AddValue(PickUpEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPickUpEvent(this IEntity obj) => obj.HasValue(PickUpEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPickUpEvent(this IEntity obj) => obj.DelValue(PickUpEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPickUpEvent(this IEntity obj, IEvent value) => obj.SetValue(PickUpEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAction<IEntity> GetItemAction(this IEntity obj) => obj.GetValue<IAction<IEntity>>(ItemAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetItemAction(this IEntity obj, out IAction<IEntity> value) => obj.TryGetValue(ItemAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddItemAction(this IEntity obj, IAction<IEntity> value) => obj.AddValue(ItemAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasItemAction(this IEntity obj) => obj.HasValue(ItemAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelItemAction(this IEntity obj) => obj.DelValue(ItemAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetItemAction(this IEntity obj, IAction<IEntity> value) => obj.SetValue(ItemAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAction GetItemDestroyAction(this IEntity obj) => obj.GetValue<IAction>(ItemDestroyAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetItemDestroyAction(this IEntity obj, out IAction value) => obj.TryGetValue(ItemDestroyAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddItemDestroyAction(this IEntity obj, IAction value) => obj.AddValue(ItemDestroyAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasItemDestroyAction(this IEntity obj) => obj.HasValue(ItemDestroyAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelItemDestroyAction(this IEntity obj) => obj.DelValue(ItemDestroyAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetItemDestroyAction(this IEntity obj, IAction value) => obj.SetValue(ItemDestroyAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAction GetBulletDestroyAction(this IEntity obj) => obj.GetValue<IAction>(BulletDestroyAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetBulletDestroyAction(this IEntity obj, out IAction value) => obj.TryGetValue(BulletDestroyAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddBulletDestroyAction(this IEntity obj, IAction value) => obj.AddValue(BulletDestroyAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasBulletDestroyAction(this IEntity obj) => obj.HasValue(BulletDestroyAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelBulletDestroyAction(this IEntity obj) => obj.DelValue(BulletDestroyAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetBulletDestroyAction(this IEntity obj, IAction value) => obj.SetValue(BulletDestroyAction, value);
    }
}
