using System.Collections.Generic;
using UnityEngine;


namespace UndefinedExplosions
{
    [RequireComponent(typeof(Collider))]
    public class Bomb : MonoBehaviour
    {
        [SerializeField]
        private BombSettings bombSettings;

        private List<IExplosionEffect> effects;
        private ITargetFinder targetFinder;

        private void Awake()
        {
            effects = bombSettings.GetEffects();
            targetFinder = new CircleTargetFinder(transform, bombSettings.Radius);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Explode();
        }

        private void Explode()
        {
            var targets = targetFinder.GetTargets();
            targets.ForEach(target => ApplyAllEffects(target, CalculateMagnitude(target)));
            Destroy(gameObject);
        }

        private void ApplyAllEffects(GameObject target, float magnitude)
        {
            effects.ForEach(effect => effect.Apply(target, magnitude));
        }

        private float CalculateMagnitude(GameObject target)
        {
            var distance = Vector3.Distance(transform.position, target.transform.position);
            return distance / bombSettings.Radius;
        }
    }
}
