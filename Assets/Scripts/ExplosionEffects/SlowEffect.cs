using UnityEngine;


namespace UndefinedExplosions.ExplosionEffects
{
    public class SlowEffect : IExplosionEffect
    {
        private readonly float speedMultiplier;
        private readonly float maxDuration;

        public SlowEffect(float speedMultiplier, float maxDuration)
        {
            this.speedMultiplier = speedMultiplier;
            this.maxDuration = maxDuration;
        }

        public void Apply(GameObject target, float magnitude)
        {
            var duration = maxDuration * magnitude;
            Debug.Log($"Trying to apply Slow effect on {target.name} for {duration} sec");
        }
    }
}
