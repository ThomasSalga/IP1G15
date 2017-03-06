using UnityEngine;
using System.Collections;
using System;

public class TowerSeller : MonoBehaviour, IBuyable<int> {


    [SerializeField]
    protected int m_price;

    public int MyPrice
    {
        get
        {
            return m_price;
        }

        set
        {
            m_price = value;
        }
    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
