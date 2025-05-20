using Atomic.Entities;

namespace SampleGame
{
    public static class HealthUseCase
    {
        public static bool IsAlive(in IEntity entity)
        {
            return entity.GetCurrentHealth().Value > 0;
        }

        public static bool TargetIsAlive(in IEntity entity)
        {
            IEntity target = entity.GetTarget();
            if (target != null && target.GetCurrentHealth().Value > 0)
            {
                return true;
            }            
            return false;
        }
    }
}
