using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class PistolInstaller : WeaponInstaller
    {
        [SerializeField]
        private int _startGunStore;

        [SerializeField]
        private Transform _firePoint;

        [SerializeField]
        private Vector3 _bulletSpread = new(0.25f, 0.25f, 0.25f);

        public override void Install(IEntity entity)
        {
            base.Install(entity);
            InstallPistol(entity);
        }

        private void InstallPistol(IEntity entity)
        {
            entity.AddGunStore(new ReactiveInt(_startGunStore));            
            entity.AddFirePoint(_firePoint);
            entity.AddFireEvent(new BaseEvent());
            entity.AddMaxBulletSpread(new BaseVariable<Vector3>(_bulletSpread));           
        }
    }
}
