using UnityEngine;
using System.Collections;

public enum EnemyState { Move, Attack };

public abstract class EnemyParent : LivingObject, IDamageable<int>, IMovable, IAttack<int>, IRecurringAction {

    #region classMembers

    [SerializeField] // shows this field from the inspector
    protected EnemyState m_state;
    [SerializeField] // shows this field from the inspector
    protected int m_life; // life of the object
    [SerializeField]
    protected float m_speed; // movement speed of the object
    [SerializeField]
    protected int m_direction; // movement direction: <0 left; >0 right
    [SerializeField]
    protected int m_attack; // attack damage
    [SerializeField]
    protected Rigidbody2D m_rigidBody; // the rigidbody required for collision and movement
    [SerializeField]
    protected float m_atkRate; // attacks per second         //How do I connect this two values
    protected float m_atkSpeed; // time between attacks      // to change from the Inspector?

    protected GameObject m_target;

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

    public float MySpeed // property from IMovable connected to m_speed
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

    public int MyDirection // property from IMovable connected to m_direction
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

    public int MyDamage // property from IAttack connected to m_attack
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

    public Rigidbody2D MyRigidBody // read only property from IAttack connected to m_rigidBody
    {
        get
        {
            return m_rigidBody;
        }
    }

    public GameObject MyTarget // property from IAttack connected to m_target
    {
        get
        {
            return m_target;
        }

        set
        {
            m_target = value;
            if (value = null)
                m_state = EnemyState.Move;
        }
    }

    public float MyActionTimeGap // property from IRecurringAction connected to m_atkRate and m_attackSpeed
    {
        get
        {
            return m_atkRate;
        }

        set
        {
            if (value != 0)
            {
                m_atkRate = value;
                m_atkSpeed = 1f / value; // time between attacks = 1sec/attacks per second
            }
            else
            {
                m_atkRate = 0f;  //how do I set a limit in a variable
                m_atkSpeed = Mathf.Infinity; /*may cause issues*/
                Debug.LogError(gameObject.name + ": do not assign 0 value to atkRate");
            }
        }
    }
    #endregion

    public Color m_color;

    IEnumerator HitFeedback()
    {
        Debug.Log("Color");
        Color c = gameObject.GetComponent<SpriteRenderer>().color;
        gameObject.GetComponent<SpriteRenderer>().color = Color.black;
        yield return new WaitForSeconds(0.2f);
        gameObject.GetComponent<SpriteRenderer>().color = c;
    }

    // Initialization
    protected virtual void Start()
    {
        MyActionTimeGap = m_atkRate; //to update attack speed 
    }

    // Update is called once per frame
    protected virtual void FixedUpdate()
    {
        /*if (Input.GetKeyDown("w"))      //USE TO TEST THINGS life in this case
            TakeDamage(1);*/

        CheckState();

    }

    // AI LOGIC IS IN HERE
    protected virtual void CheckState()
    {
        if (m_target == null)
            m_state = EnemyState.Move;

        switch (m_state)
        {
            case EnemyState.Move:
                Move();
                break;

            case EnemyState.Attack:
                //Attack();
                break;
        }
    }

    public override void Death()
    {
        //do funny things
		GameObject.Find ("DeathSound").GetComponent<AudioSource> ().Play ();
        gameObject.GetComponent<MoneyResource>().OneShotEarnMoney(gameObject.GetComponent<MoneyResource>().m_earningAmount);
        Destroy(gameObject);

    }

    public void TakeDamage(int amount)
    {
        // Call effects here
        StartCoroutine(HitFeedback());

        MyDurability -= amount;

        if (m_life <= 0)
        {
            Death();
        }
    }

    public virtual void Move()
    {
        MyDirection *= (int)transform.right.x;  // if positive = right; if negative = left;
        MyRigidBody.velocity = new Vector2(MySpeed * MyDirection, 0); // moves the rigid body
    }

    public virtual void Stop()
    {
		if (MyTarget != null) {
			Animator animator = GetComponent<Animator> () as Animator;
			animator.SetBool ("attacking", true);

		} else {
			Animator animator = GetComponent<Animator> () as Animator;
			animator.SetBool ("attacking", false);
		}
			



        MyRigidBody.velocity = new Vector2(0, 0); // stops the rigid body
    }

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Defence")
        {
            MyTarget = other.gameObject;
            m_state = EnemyState.Attack;
            Attack();
        }
        else if (other.gameObject.tag == "Projectile")
        {
            //hit visual feedback
        }
    }

    public virtual void Attack()
    {
        //do funny things
    }

    public virtual IEnumerator RecurAction()
    {
        yield return new WaitForSeconds(m_atkSpeed);
	
        Attack();
    }
}