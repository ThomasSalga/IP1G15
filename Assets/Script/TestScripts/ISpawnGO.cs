using UnityEngine;
using System.Collections;

public interface ISpawnGO
{
    GameObject MyPrefabToSpawn { get; set; }

    void SpawnGO(GameObject go);
}