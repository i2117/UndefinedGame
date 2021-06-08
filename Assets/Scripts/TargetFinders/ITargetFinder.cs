using System.Collections.Generic;
using UnityEngine;


namespace UndefinedExplosions
{
    public interface ITargetFinder
    {
        List<GameObject> GetTargets();
    }
}
