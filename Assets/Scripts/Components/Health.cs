using System;
using UnityEngine;


namespace UndefinedExplosions.Components {
    public class Health : MonoBehaviour
    {
        [SerializeField]
        private int initialHealth = 100;
        private int currentHealth;

        public Action<int> OnHealthChanged;
        public Action OnDied;

        public int CurrentHealth
        {
            get => currentHealth;
            private set
            {
                currentHealth = value;
                if (currentHealth <= 0)
                {
                    currentHealth = 0;
                    OnDied?.Invoke();
                }
                OnHealthChanged?.Invoke(currentHealth);
            }
        }

        private void Awake()
        {
            currentHealth = initialHealth;
        }

        public void TakeDamage(int amount)
        {
            CurrentHealth -= amount;
        }
    }
}
