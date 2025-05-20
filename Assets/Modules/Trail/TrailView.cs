using System;
using UnityEngine;

namespace Modules.Gameplay
{
    public sealed class TrailView : MonoBehaviour
    {
        [SerializeField]
        private TrailRenderer trailPrefab;

        [SerializeField, Space]
        private Transform trailParent;

        [SerializeField]
        private Vector3 trailScale = new(5, 5, 2.5f);

        [SerializeField]
        private Vector3 trailOffset = new(0, 0, -1.5f);

        private TrailRenderer _trail;

        public void Show()
        {
            if (_trail == null)
            {
                _trail = Instantiate(trailPrefab, trailParent);
            }               

            Transform tranform = _trail.transform;
            tranform.localScale = trailScale;
            tranform.localPosition = trailOffset;
            tranform.localEulerAngles = Vector3.zero;
                        
            _trail.SetPositions(Array.Empty<Vector3>());            
            _trail.Clear();
            _trail.emitting = true;
            _trail.enabled = true;
        }

        public void Hide()
        {
            if (_trail != null)
            {
                _trail.enabled = false;
            }
        }
    }
}