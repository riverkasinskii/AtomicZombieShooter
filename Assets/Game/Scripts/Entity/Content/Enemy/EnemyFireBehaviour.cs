using Atomic.Elements;
using Atomic.Entities;

namespace SampleGame
{
    public sealed class EnemyFireBehaviour : IEntityUpdate
    {
        public void OnUpdate(in IEntity entity, in float deltaTime)
        {
            if (entity.TryGetFireCondition(out IExpression<bool> condition) && !condition.Value)
            {
                entity.GetFireState().Value = true;
                return;
            }                

            entity.GetFireAction()?.Invoke();
        }
    }
}