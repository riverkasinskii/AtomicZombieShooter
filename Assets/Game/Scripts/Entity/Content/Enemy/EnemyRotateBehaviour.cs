using Atomic.Entities;

namespace SampleGame
{
    public sealed class EnemyRotateBehaviour : IEntityFixedUpdate
    {
        public void OnFixedUpdate(in IEntity entity, in float deltaTime)
        {
            IEntity target = entity.GetTarget();
            if (target != null)
            {
                RotateUseCase.RotateTowards(entity, target, deltaTime);
            }
        }
    }
}
