using UnityEngine;
using System.Collections;
using System;

public class Projectile : MonoBehaviour, IMovable, IAttack<int> {

    [SerializeField]
    protected float m_speed;
    protected int m_direction;
    [SerializeField]
    protected int m_damage;

    protected Rigidbody2D m_rb;

    protected GameObject m_target;

    #region properties
    public float MySpeed
    {
        get
        {
            return m_speed;
        }

        set
        {
            m_speed = value;
        }
    }

    public int MyDirection
    {
        get
        {
            return m_direction;
        }

        set
        {
            m_direction = value;
        }
    }

    public int MyDamage
    {
        get
        {
            return m_damage;
        }

        set
        {
            m_damage = value;
        }
    }

    public Rigidbody2D MyRigidBody
    {
        get
        {
            return m_rb;
        }
    }

    public GameObject MyTarget
    {
        get
        {
            return m_target;
        }

        set
        {
            if (value.tag == "Enemy")
            {
                m_target = value;
                Attack();
            }
            else m_target = null;
        }
    }
    #endregion
    // Use this for initialization
    void Start ()
    {
        m_rb = GetComponent<Rigidbody2D>();
        m_direction = (int)transform.right.x * -1;
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        m_rb.velocity = new Vector2(m_speed * m_direction, 0);
    }

	protected virtual void OnTriggerEnter2D(Collider2D other)
    {
		

			MyTarget = other.gameObject;                    
		
		}

    public void Move()
    {
        MyDirection *= (int)transform.right.x;  // if positive = right; if negative = left;
        MyRigidBody.velocity = new Vector2(MySpeed * MyDirection, 0); // moves the rigid body
    }

    public void Stop()
    {
        //not used
    }

    public void Attack()
    {        
        MyTarget.GetComponent<EnemyParent>().TakeDamage(MyDamage);
        Destroy(gameObject);
    }
    
}
        
