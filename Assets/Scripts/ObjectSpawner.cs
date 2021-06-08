using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;
    [SerializeField] private float minInterval;
    [SerializeField] private float maxInterval;

    [SerializeField] private GameObject[] prefabs;

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(GetRandomInterval());
            SpawnRandomPrefabInRandomPlace();
        }
    }

    private Vector3 GetRandomPosition()
    {
        return new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);
    }

    private float GetRandomInterval()
    {
        return Random.Range(minInterval, maxInterval);
    }

    private GameObject GetRandomPrefab()
    {
        if (prefabs == null || prefabs.Length <= 0)
        {
            Debug.LogWarning($"No prefabs in {name}");
            return new GameObject();
        }

        return prefabs[Random.Range(0, prefabs.Length)];
    }

    private void SpawnRandomPrefabInRandomPlace()
    {
        Instantiate(GetRandomPrefab(), GetRandomPosition(), Quaternion.identity, null);
    }
}
