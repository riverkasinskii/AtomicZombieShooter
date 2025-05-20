using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class AmmoItemInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private int _gunRestore = 10;

        public override void Install(IEntity entity)
        {
            entity.AddGameObject(gameObject);
            entity.AddPickupableTag();
            entity.AddPickUpEvent(new BaseEvent());            
            entity.AddItemAction(new BaseAction<IEntity>((target) =>
            {
                if (target.HasCurrentWeapon())
                {
                    IEntity weapon = target.GetCurrentWeapon().Value;
                    weapon.GetGunStore().Value += _gunRestore;                    
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
