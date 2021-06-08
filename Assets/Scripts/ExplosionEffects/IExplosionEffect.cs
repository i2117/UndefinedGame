using UnityEngine;

namespace UndefinedExplosions
{
    public interface IExplosionEffect
    {
        void Apply(GameObject target, float magnitude);
    }
}
