using UnityEngine;
using System.Collections;
using System;

public class RSTower : TowerParent, ISpawnGO, IRecurringAction {

    #region Interfaces' Properties
    public float MyActionTimeGap
    {
        get
        {
            throw new NotImplementedException();
        }

        set
        {
            throw new NotImplementedException();
        }
    }

    public GameObject MyPrefabToSpawn
    {
        get
        {
            throw new NotImplementedException();
        }

        set
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    public IEnumerator RecurAction()
    {
        throw new NotImplementedException();
    }

    public void SpawnGO(GameObject go)
    {
        throw new NotImplementedException();
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
