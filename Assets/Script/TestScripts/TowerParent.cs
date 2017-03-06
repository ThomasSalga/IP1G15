using UnityEngine;
using System.Collections;
using System;

public enum DefenceState { ToPlace, Placed };

public abstract class TowerParent : LivingObject, IDamageable<int> {

    #region members
    [SerializeField]
    protected int m_hp;

    private DefenceState m_state;

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
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    protected void CheckState()
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
        Destroy(gameObject);
    }

    protected virtual Vector3 Drag()
    {
        if (Input.GetButtonUp("Fire1"))// && snappable)
        {
            if (Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero).collider.gameObject.tag == "Snap")
            {
                return Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero).collider.transform.position;
            }
        }
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
