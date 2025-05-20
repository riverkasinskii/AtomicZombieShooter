using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class HandInstaller : WeaponInstaller
    {
        [SerializeField]
        private float _detectRadius = 0.2f;

        [SerializeField]
        private int _damage = 1;

        public override void Install(IEntity entity)
        {
            base.Install(entity);
            InstallHand(entity);
        }

        private void InstallHand(IEntity entity)
        {
            entity.AddDamage(new ReactiveInt(_damage));
            entity.AddDetectRadius(new Const<float>(_detectRadius));
        }
    }
}
