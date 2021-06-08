using UnityEngine;


namespace UndefinedExplosions.Components
{ 
    [RequireComponent(typeof(Health))]
    public abstract class HealthIndicator : MonoBehaviour
    {
        private Health health;

        private void Awake()
        {
            health = GetComponent<Health>();
        }

        private void OnEnable()
        {
            health.OnHealthChanged += SetHealthText;
        }

        private void OnDisable()
        {
            health.OnHealthChanged -= SetHealthText;
        }

        protected abstract void SetHealthText(int newValue);
    }
}
