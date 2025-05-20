using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public static class AttackUseCase
    {
        public static void Attack(in IEntity entity, in IGameContext context)
        {
            WeaponType type = entity.GetWeaponType().Value;

            if (type == WeaponType.Melee)
            {
                MeleeAttack(entity, context);
            }
            if (type == WeaponType.Range)
            {
                RangeAttack(entity, context);
            }
        }

        private static void RangeAttack(in IEntity weapon, in IGameContext context)
        {                        
            if (weapon.GetGunStore().Value >= 1)
            {
                Transform firePoint = weapon.GetFirePoint();
                Vector3 bulletSpread = weapon.GetMaxBulletSpread().Value;
                weapon.GetGunStore().Value -= 1;
                weapon.GetFireEvent().Invoke();
                SpawnBulletUseCase.SpawnBullet(context, firePoint.position, firePoint.rotation, bulletSpread);
            }            
        }

        private static void MeleeAttack(in IEntity source, in IGameContext context)
        {
            Vector3 center = source.GetTransform().position;
            float radius = source.GetDetectRadius().Value;
            int damage = source.GetDamage().Value;

            Collider[] results = Physics.OverlapSphere(center, radius);
            foreach (var hitCollider in results)
            {
                if(hitCollider.TryGetEntity(out IEntity entity) && entity.HasCharactableTag())
                {
                    entity.GetCurrentHealth().Value -= damage;                    
                    entity.GetHealthEvent()?.Invoke(entity.GetCurrentHealth().Value);      
                }
            }
        }
    }
}
