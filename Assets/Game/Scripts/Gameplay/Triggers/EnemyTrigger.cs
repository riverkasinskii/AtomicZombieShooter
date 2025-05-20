using Atomic.Entities;
using SampleGame;
using UnityEngine;

namespace Game.Gameplay
{
    [RequireComponent(typeof(Collider))]
    public sealed class EnemyTrigger : MonoBehaviour
    {
        [SerializeField]
        private SceneEntity[] _enemies;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetEntity(out IEntity target) && target.HasCharactableTag())
            {
                foreach (var entity in _enemies)
                {
                    entity.GetMoveState().Value = true;
                    entity.SetTarget(target);
                }                
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetEntity(out IEntity target) && target.HasCharactableTag())
            {
                foreach (var entity in _enemies)
                {
                    entity.SetTarget(null);
                    entity.GetMoveState().Value = false;
                }
            }
        }
    }
}