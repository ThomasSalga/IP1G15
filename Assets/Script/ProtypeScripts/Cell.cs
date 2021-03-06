﻿using UnityEngine;
using System.Collections;

public class Cell : MonoBehaviour {

    #region member
    [SerializeField]
    private bool m_blocked;
    private int m_row;
    private int m_column;
    #endregion

    #region properties
    public bool IsBlocked
    {
        get { return m_blocked; }
        set
        {
            m_blocked = value;
            if(value)
            {

            }
        }
    }

    public int MyRow
    {
        get { return m_row; }
        set { m_row = value; }
    }

    public int MyColumn
    {
        get { return m_column; }
        set { m_column = value; }
    }
    #endregion

    // Use this for initialization
    void Awake ()
    {
        m_blocked = false;
    }

    // Update is called once per frame
    void Update ()
    {
	    
	}

    public void LockThis()
    {
        m_blocked = true;
    }

    public void UnlockThis()
    {
        m_blocked = false;
    }
}
