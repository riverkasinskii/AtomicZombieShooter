using Atomic.Entities;
using Modules.Gameplay;
using SampleGame;
using UnityEngine;

namespace Game.Gameplay
{
    public sealed class EnemyAnimInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private Animator _animator;

        [SerializeField]
        private AnimationEventReceiver _animationReceiver;

        private const string fireEvent = "fire_event";                

        [SerializeField]
        private string _isDeathKey = "Death";

        [SerializeField]
        private string _isMovingKey = "IsMoving";

        [SerializeField]
        private string _isFiringKey = "Attack";

        [SerializeField]
        private string _isTakeDamageKey = "TakeDamage";

        public override void Install(IEntity entity)
        {
            entity.AddAnimator(_animator);
                                    
            entity.AddBehaviour(new MoveAnimBehaviour(_isMovingKey));
            entity.AddBehaviour(new FireAnimBehaviour(_isFiringKey));
            entity.AddBehaviour(new TakeDamageAnimBehaviour(_isTakeDamageKey));
            entity.AddBehaviour(new DeathAnimBehaviour(_isDeathKey));

            entity.WhenInit(() =>
            {
                _animationReceiver.Subscribe(fireEvent, () =>
                {
                    entity.GetCurrentWeapon().Value?.GetWeaponFireAction().Invoke();

                    entity.GetFireAction()?.Invoke();

                    if (entity.GetFireCondition().Invoke())
                    {
                        entity.GetFireEvent()?.Invoke();
                    }                    
                });
            });

            entity.WhenDispose(() =>
            {
                _animationReceiver.Unsubscribe(fireEvent, () =>
                {
                    entity.GetFireAction()?.Invoke();
                });
            });
        }
    }
}