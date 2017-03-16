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
    
}
