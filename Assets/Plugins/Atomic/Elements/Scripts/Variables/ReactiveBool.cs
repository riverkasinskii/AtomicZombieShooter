using System;
using UnityEngine;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif

namespace Atomic.Elements
{
#if ODIN_INSPECTOR
    [InlineProperty]
#endif

    [Serializable]
    public class ReactiveBool : IReactiveVariable<bool>, IDisposable
    {
        public event Action<bool> OnValueChanged;

#if ODIN_INSPECTOR
        [HideLabel, OnValueChanged(nameof(InvokeEvent))]
#endif
        [SerializeField]
        private bool value;

        public bool Value
        {
            get { return this.value; }
            set
            {
                if (this.value != value)
                {
                    this.value = value;
                    this.OnValueChanged?.Invoke(value);
                }
            }
        }

        public ReactiveBool() => this.value = default;

        public ReactiveBool(bool value) => this.value = value;

        public static implicit operator ReactiveBool(bool value) => new(value);

        public void Subscribe(Action<bool> listener) => this.OnValueChanged += listener;

        public void Unsubscribe(Action<bool> listener) => this.OnValueChanged -= listener;

        private void InvokeEvent(bool value) => this.OnValueChanged?.Invoke(value);

        public void Dispose() => AtomicHelper.Dispose(ref this.OnValueChanged);

        public override string ToString() => this.Value.ToString();
    }
}