using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class HealthItemInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private int _restoredHealth = 3;

        public override void Install(IEntity entity)
        {
            entity.AddGameObject(gameObject);
            entity.AddPickupableTag();
            entity.AddPickUpEvent(new BaseEvent());            
            entity.AddItemAction(new BaseAction<IEntity>((target) =>
            {
                int currentHealth = target.GetCurrentHealth().Value;
                int maxHealth = target.GetMaxHealth().Value;

                if (currentHealth < maxHealth)
                {
                    target.GetCurrentHealth().Value += _restoredHealth;
                    entity.GetPickUpEvent()?.Invoke();
                    entity.DelPickupableTag();
                }                
            }));

            entity.AddItemDestroyAction(new BaseAction(() =>
            {
                entity.GetGameObject().SetActive(false);
            }));
        }
    }
}
