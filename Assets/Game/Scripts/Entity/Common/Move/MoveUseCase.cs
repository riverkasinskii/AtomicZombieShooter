using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public static class MoveUseCase
    {        
        public static bool MinDistance(in IEntity entity)
        {            
            return entity.GetMinTargetDistance().Value <= 1f;
        }

        public static bool IsMoving(in IEntity entity)
        {
            return entity.GetMoveCondition().Value;
        }                

        public static void MoveTowards(in IEntity entity, in Vector3 direction, in float deltaTime)
        {
            if (entity.TryGetMoveCondition(out IExpression<bool> condition) && !condition.Value)
                return;

            Transform transform = entity.GetTransform();
            IValue<float> speed = entity.GetMoveSpeed();
            transform.position += direction * (speed.Invoke() * deltaTime);
        }

        public static void MoveTowards(in IEntity source, in IEntity target, in float moveSpeed, in float deltaTime)
        {
            if (target == null)
                return;

            Transform transformSource = source.GetTransform();
            Transform transformTarget = target.GetTransform();
            float distance = Vector3.Distance(transformSource.position, transformTarget.position);
            source.GetMinTargetDistance().Value = distance;

            if (source.TryGetMoveCondition(out IExpression<bool> condition) && !condition.Value)
                return;           
            
            transformSource.position = Vector3.MoveTowards(transformSource.position, transformTarget.position, moveSpeed * deltaTime);            
        }
    }
}
