using UnityEngine;
using System.Collections;

public class SpawnTower : SpawnGO {

    public override void Spawn()
    {
        Debug.Log("SPAWN OVERRIDE");
        if (!FindObjectOfType<Player>().holdingBuilding)
        {
            FindObjectOfType<Player>().holdingBuilding = true;
            Debug.Log("holding true and spawning");
            base.Spawn();
        }
        else { Debug.Log("you already have one"); }
    }
}
