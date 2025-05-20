using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class SpawnBulletUseCase
    {
        public static IEntity SpawnBullet(in IGameContext context, in Vector3 position, in Quaternion rotation, in Vector3 bulletSpread)
        {
            IEntity bullet = context.GetBulletPool().Rent();
            Transform bulletTransform = bullet.GetTransform();
            bulletTransform.SetPositionAndRotation(position, rotation);

            bullet.GetLifetime().Reset();
            bullet.GetMoveDirection().Value = bulletTransform.forward + GetBulletSpread(bulletSpread);
            
            return bullet;
        }

        public static void UnspawnBullet(in IGameContext context, in IEntity bullet)
        {
            context.GetBulletPool().Return(bullet);
        }

        private static Vector3 GetBulletSpread(in Vector3 maxSpread)
        {            
            float xAxis = Random.Range(0, maxSpread.x);
            float yAxis = Random.Range(0, maxSpread.y);
            float zAxis = Random.Range(0, maxSpread.z);

            return new Vector3(xAxis, yAxis, zAxis);
        }
    }
}
