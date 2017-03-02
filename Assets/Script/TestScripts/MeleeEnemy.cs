using UnityEngine;
using System.Collections;
using System;

public class MeleeEnemy : LivingObject, IDamageable<int>, IMovable, IAttack<int> {


    #region classMembers

    [SerializeField] // shows this field from the inspector
    private EnemyState m_state;
    [SerializeField] // shows this field from the inspector
    private int m_life; // life of the object
    [SerializeField]
    private float m_speed; // movement speed of the object
    [SerializeField]
    private int m_direction; // movement direction: <0 left; >0 right
    [SerializeField]
    private int m_attack; // attack damage
    [SerializeField]
    private Rigidbody2D m_rigidBody; // the rigidbody required for collision and movement

    private GameObject m_target;

    #endregion

    #region Interfaces' Properties


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
            return m_attack;
        }

        set
        {
            m_attack = value;
        }
    }

    public Rigidbody2D MyRigidBody
    {
        get
        {
            return m_rigidBody;
        }
    }
    #endregion

    // Initialization
    void Start ()
    {
        
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        /*if (Input.GetKeyDown("w"))      //TEST THINGS life in this case
            TakeDamage(1);*/

        CheckState();

    }

    protected void CheckState()  // AI LOGIC IS IN HERE
    {
        switch (m_state)
        {
            case EnemyState.Move:
                Move();
                break;

            case EnemyState.Attack:
                //EnemyStateAttack();
                Stop();
                if (m_target != null)
                {
                    //implement
                    //timed action
                    //here
                }
                else m_state = EnemyState.Move;
                Debug.Log("I'm STILL");
                break;
        }
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

    public void Move()
    {
        MyDirection *= (int)transform.right.x;  // if positive = right; if negative = left;
        MyRigidBody.velocity = new Vector2(MySpeed * MyDirection, 0); // moves the rigid body
    }

    public void Stop()
    {
        // should I stop or just call Stop instead of Move
        MyRigidBody.velocity = new Vector2(0, 0);
        //MyRigidBody.Sleep();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Defence")
        {
            m_target = other.gameObject;
            m_state = EnemyState.Attack;
        }
        else if (other.gameObject.tag == "Projectile")
        {
            //hit visual feedback
        }
    }

    public void Attack(Collider2D other)
    {
        Debug.Log("I HIT " + other.gameObject.name);
        //other.
        //other.gameObject.GetComponent<IDamageable<int>>(TakeDamage(MyDamage));
    }
}
