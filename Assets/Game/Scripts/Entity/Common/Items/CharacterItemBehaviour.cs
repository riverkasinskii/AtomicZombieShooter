using Atomic.Entities;
using Modules.Gameplay;
using UnityEngine;

namespace SampleGame
{
    public sealed class CharacterItemBehaviour : IEntityInit, IEntityDispose
    {        
        private TriggerEventReceiver _triggerReceiver;
        private IEntity _source;

        public void Init(in IEntity entity)
        {
            _source = entity;
            _triggerReceiver = entity.GetTrigger();

            _triggerReceiver.OnEntered += OnEntered;
        }

        public void Dispose(in IEntity entity)
        {
            _triggerReceiver.OnEntered -= OnEntered;
        }

        private void OnEntered(Collider collider)
        {
            if (collider.TryGetEntity(out IEntity target) && target.HasPickupableTag())
            {
                target.GetItemAction()?.Invoke(_source);
            }
        }
    }
}
