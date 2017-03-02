using UnityEngine;
using System.Collections;
using System;

public class MeleeEnemy : LivingObject, IDamageable<int> {


    #region classMembers

    [SerializeField] // shows this field from the inspector
    private int m_life; // life of the object


    #endregion

    #region Interfaces' Members

    [HideInInspector] // hides this field from the inspector
    public int MyDurability // property from IDamageable connected to m_life
    {
        get
        {
            return m_life;
        }

        set
        {
            m_life = value;
        }
    }
    #endregion

    // Initialization
    void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        /*if (Input.GetKeyDown("w"))      //TEST THINGS life in this case
            TakeDamage(1);*/
	}

    public override void Death()
    {
        //do funny things
        Destroy(gameObject);
    }

    public void TakeDamage(int amount)
    {
        // Call effects here
        MyDurability -= amount;

        if (m_life <= 0) 
        {
            Death();
        }
    }
            
            
}
