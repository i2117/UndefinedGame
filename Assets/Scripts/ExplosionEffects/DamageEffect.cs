using UnityEngine;
using UndefinedExplosions.Components;


namespace UndefinedExplosions.ExplosionEffects
{
    public class DamageEffect : IExplosionEffect
    {
        private readonly int maxDamage;
        private readonly bool isFixed;

        public DamageEffect(int maxDamage, bool isFixed)
        {
            this.maxDamage = maxDamage;
            this.isFixed = isFixed;
        }

        public void Apply(GameObject target, float magnitude)
        {
            var health = target.GetComponent<Health>();
            if (health == null)
            {
                return;
            }

            int finalDamage = isFixed ? maxDamage : Mathf.RoundToInt(maxDamage * magnitude);
            Debug.Log($"Dealing {finalDamage} damage to {target.name}");
            health.TakeDamage(finalDamage);
        }
    }
}
