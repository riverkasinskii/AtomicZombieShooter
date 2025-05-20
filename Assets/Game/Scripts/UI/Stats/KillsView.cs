using TMPro;
using UnityEngine;

namespace Game.UI
{
    public sealed class KillsView : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text valueText;

        public void SetText(string health)
        {
            this.valueText.text = health;
        }

        public void SetVisible(bool visible)
        {
            this.gameObject.SetActive(visible);
        }
    }
}