using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public static class RotateUseCase
    {
        public static void RotateTowards(in IEntity source, in IEntity target , in float deltaTime)
        {
            if (source.TryGetRotateCondition(out IExpression<bool> condition) && !condition.Value)
                return;

            Transform targetTransform = target.GetTransform();
            Transform sourceTransform = source.GetTransform();
            Vector3 direction = targetTransform.position - sourceTransform.position;
            Quaternion targetRotation = Quaternion.LookRotation(direction, Vector3.up);
            RotateTowards(source, targetRotation, deltaTime);
        }

        public static void RotateTowards(in IEntity entity, in Vector3 direction, in float deltaTime)
        {
            if (direction == Vector3.zero)
                return;

            if (entity.TryGetRotateCondition(out IExpression<bool> condition) && !condition.Value)
                return;

            Quaternion targetRotation = Quaternion.LookRotation(direction, Vector3.up);
            RotateTowards(entity, targetRotation, deltaTime);
        }

        private static void RotateTowards(in IEntity entity, in Quaternion targetRotation, in float deltaTime)
        {
            float speed = entity.GetAngularSpeed().Value * deltaTime;
            Transform transform = entity.GetTransform();
            transform.rotation = RotateTowards(transform.rotation, targetRotation, speed);
        }

        private static Quaternion RotateTowards(in Quaternion currentRotation, in Quaternion targetRotation, in float speed)
        {
            return Quaternion.Lerp(currentRotation, targetRotation, speed);
        }
    }
}
