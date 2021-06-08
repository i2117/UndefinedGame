using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace UndefinedExplosions
{
    public class CircleTargetFinder : ITargetFinder
    {
        private readonly Transform center;
        private readonly float radius;

        public CircleTargetFinder(Transform center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public List<GameObject> GetTargets()
        {
            var colliders = Physics2D.OverlapCircleAll(center.position, radius);
            return colliders.ToList().Select(collider => collider.gameObject).ToList();
        }
    }
}
