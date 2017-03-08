using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public enum DefenceState { ToPlace, Placed };

public abstract class TowerParent : LivingObject, IDamageable<int> {

    #region members
    [SerializeField]
    protected DefenceState m_state;
    [SerializeField]
    protected int m_hp;
    [SerializeField]
    protected float m_adjustPosX;
    [SerializeField]
    protected float m_adjustPosY;

    protected GameObject m_hit;
    protected Vector3 m_pos;
    protected List<Vector2> m_buildingSpace;

    private int m_originX;
    private int m_originY;
    #endregion

    #region Interfaces' Property

    public int MyDurability
    {
        get
        {
            return m_hp;
        }

        set
        {
            m_hp = value;
        }
    }


    #endregion

    // Use this for initialization
    protected virtual void Start ()
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
        m_buildingSpace = new List<Vector2>();
        m_buildingSpace.Add(Vector2.zero);
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        CheckState();
	}

    protected virtual void CheckState()
    {
        switch (m_state)
        {
            case DefenceState.ToPlace:
                transform.position = Drag();
                //DefenceStateToPlace();
                break;

            case DefenceState.Placed:
               // DefenceStatePlaced();
                break;
        }
    }

    public virtual void TakeDamage(int amount)
    {
        MyDurability -= amount;

        if (MyDurability <= 0)
            Death();
    }

    public override void Death()
    {
        FreePos();
    }

    protected virtual Vector3 Drag()
    {
        if (Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero))
        {
            m_hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero).collider.gameObject;

            if (m_hit.gameObject.tag == "Snap")
            {
                PlacementFeedback(gameObject.GetComponent<SpriteRenderer>(), Color.green);
                if (Input.GetButtonDown("Fire1") && !m_hit.GetComponent<Cell>().IsBlocked)
                {
                    m_originX = m_hit.GetComponent<Cell>().MyColumn;
                    m_originY = m_hit.GetComponent<Cell>().MyRow;
                    SecurePos(m_originX, m_originY);
                    m_state = DefenceState.Placed;
                    m_pos = m_hit.transform.position;
                    m_pos.z = 0;
                    m_pos.x += m_adjustPosX;
                    m_pos.y += m_adjustPosY;
                    gameObject.GetComponent<Collider2D>().enabled = true;
                    return m_pos;
                }
                m_pos = m_hit.transform.position;
                m_pos.z = 0;
                m_pos.x += m_adjustPosX;
                m_pos.y += m_adjustPosY;
            }
            else PlacementFeedback(gameObject.GetComponent<SpriteRenderer>(), Color.red);
        }
        return m_pos;
    }

    protected virtual void SecurePos(int x, int y)
    {
        List<Vector2> temp = m_buildingSpace;

        for (int i = m_buildingSpace.Count - 1; i >= 0; i--)
        {
            Vector2 t = temp[i];
            t.x += x; 
            t.y += y;
            temp[i] = t;
        }
        if (GameObject.FindGameObjectWithTag("Field").GetComponent<Grid>().BlockCells(temp))
            PlacementFeedback(gameObject.GetComponent<SpriteRenderer>(), Color.white);
        else Destroy(gameObject);
    }

    protected virtual void FreePos()
    {
        if (GameObject.FindGameObjectWithTag("Field").GetComponent<Grid>().FreeCells(m_buildingSpace))
        {
            Destroy(gameObject);
        }
    }

    void PlacementFeedback(SpriteRenderer rendererObj, Color apply)
    {
        rendererObj.color = apply;
    }
    
}
