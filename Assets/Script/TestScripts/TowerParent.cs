using UnityEngine;
using System.Collections;
using System;

public abstract class TowerParent : MonoBehaviour, IDamageable<int> {

    #region Interfaces' Property
    
    public int MyDurability
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

    public virtual void TakeDamage(int amount)
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
