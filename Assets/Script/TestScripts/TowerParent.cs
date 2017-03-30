using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public enum DefenceState { ToPlace, Placed };

public abstract class TowerParent : LivingObject, IDamageable<int>, IBuyable<int> {

    #region members
    [SerializeField]
    protected DefenceState m_state;
    [SerializeField]
    protected int m_hp;
    [SerializeField]
    protected float m_adjustPosX;
    [SerializeField]
    protected float m_adjustPosY;
    [SerializeField]
    protected int cost;

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

	public int MyMaxDurability
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

    public int MyPrice
    {
        get
        {
            return cost;
        }

        set
        {
            cost = value;
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
		StartCoroutine(DelayBuildingDeath());
		FreePos();
    }


	IEnumerator DelayBuildingDeath(){

		GameObject.Find ("BuildingDestroySoundEffect").GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds (GameObject.Find ("BuildingDestroySoundEffect").GetComponent<AudioSource> ().clip.length);

	}

    protected virtual Vector3 Drag()
    {
        if(FindObjectOfType<Player>().holdingBuilding)
        if (Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero))
        {
            m_hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero).collider.gameObject;

            if (m_hit.gameObject.tag == "Snap")
            {
                if (m_originX != m_hit.GetComponent<Cell>().MyColumn || m_originY != m_hit.GetComponent<Cell>().MyRow)
                {
                    m_originY = m_hit.GetComponent<Cell>().MyRow;
                    m_originX = m_hit.GetComponent<Cell>().MyColumn;
                }
                if (SecurePos(m_originX, m_originY, m_buildingSpace))
                {
                    PlacementFeedback(gameObject.GetComponent<SpriteRenderer>(), Color.green);

                        if (Input.GetButtonDown("Fire1") && FindObjectOfType<Player>().MyResource - MyPrice >= 0)
                        {
                            BlockSpace(m_originX, m_originY, m_buildingSpace);
                            m_state = DefenceState.Placed;
                            Debug.Log("state transition here");
                            StateTransition();
                            FindObjectOfType<Player>().MyResource -= MyPrice;
                            PlacementFeedback(gameObject.GetComponent<SpriteRenderer>(), Color.white);
                            m_pos = m_hit.transform.position;
                            m_pos.z = 0;
                            m_pos.x += m_adjustPosX;
                            m_pos.y += m_adjustPosY;
                            gameObject.GetComponent<Collider2D>().enabled = true;
                            return m_pos;
                        }
                        else if (FindObjectOfType<Player>().MyResource - MyPrice < 0)
                        {
                            Destroy(gameObject);
                        }
                }
                else
                {
                    PlacementFeedback(gameObject.GetComponent<SpriteRenderer>(), Color.red);
                    if (Input.GetButtonDown("Fire1"))
                    {
                        Destroy(gameObject);
                    }
                }
                m_pos = m_hit.transform.position;
                m_pos.z = 0;
                m_pos.x += m_adjustPosX;
                m_pos.y += m_adjustPosY;
            }
        }
        return m_pos;
    }

    protected virtual bool SecurePos(int x, int y, List<Vector2> checkPlaces)
    {
        foreach (Vector2 place in checkPlaces)
        {
            int newX = x + (int)place.x;
            int newY = y + (int)place.y;
            if(!FindObjectOfType<Grid>().IsPlaceable(newX,newY))
            {
                return false;
            }
        }
        return true;
    }

    protected virtual void BlockSpace(int x, int y, List<Vector2> checkPlaces)
    {
        List<Vector2> temp = new List<Vector2>();

        foreach (Vector2 place in checkPlaces)
        {
            Vector2 t = new Vector2();
            int newX = x + (int)place.x;
            int newY = y + (int)place.y;
            t.x = newX;
            t.y = newY;
            temp.Add(t);
        }
        FindObjectOfType<Grid>().BlockCells(temp);
        m_buildingSpace = temp;
    }

    protected virtual void FreePos()
    {
        if (FindObjectOfType<Grid>().FreeCells(m_buildingSpace))
            Destroy(gameObject);
    }

    void PlacementFeedback(SpriteRenderer rendererObj, Color apply)
    {
        rendererObj.color = apply;
    }

    public virtual void StateTransition()
    {
        Debug.Log("state transition holding false");
        FindObjectOfType<Player>().holdingBuilding = false;
    }
    
}
