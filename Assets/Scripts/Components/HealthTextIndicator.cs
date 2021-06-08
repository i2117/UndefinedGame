using UnityEngine;
using TMPro;


namespace UndefinedExplosions.Components
{
    public class HealthTextIndicator : HealthIndicator
    {
        [SerializeField] private TextMeshProUGUI healthText;

        protected override void SetHealthText(int newValue)
        {
            if (healthText == null)
            {
                return;
            }

            healthText.text = $"HP:\n{newValue}";
        }
    }
}
