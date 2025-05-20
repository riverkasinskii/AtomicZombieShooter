using Atomic.Elements;
using Atomic.Entities;

namespace SampleGame
{
    public sealed class EnemyMoveBehaviour : IEntityFixedUpdate
    {
        public void OnFixedUpdate(in IEntity entity, in float deltaTime)
        {
            IEntity target = entity.GetTarget();
            if (target != null)
            {
                IReactiveVariable<float> speed = entity.GetMoveSpeed();
                MoveUseCase.MoveTowards(entity, target, speed.Value, deltaTime);
            }
        }
    }
}
