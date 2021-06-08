using System.Collections.Generic;
using UnityEngine;
using UndefinedExplosions.ExplosionEffects;


namespace UndefinedExplosions
{
    [CreateAssetMenu(menuName = "Bomb/Settings", fileName = "BombData")]
    public class BombSettings : ScriptableObject
    {
        [SerializeField] private float radius = 5F;
        [Header("Damage")]
        [SerializeField] private int maxDamage = 50;
        [SerializeField] private bool damageIsFixed;
        [Header("Slow")]
        [SerializeField] private bool hasSlowEffect;
        [SerializeField] private float speedMultiplier = 0.5F;
        [SerializeField] private float maxSlowDuration = 10F;

        public float Radius => radius;

        public List<IExplosionEffect> GetEffects()
        {
            List<IExplosionEffect> effects = new List<IExplosionEffect>();

            effects.Add(new DamageEffect(maxDamage, damageIsFixed));

            if (hasSlowEffect)
            {
                effects.Add(new SlowEffect(speedMultiplier, maxSlowDuration));
            }

            return effects;
        }
    }
}
