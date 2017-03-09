using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class Player : MonoBehaviour, IFixable<int> {

    [SerializeField]
    private int m_maxLife;
    [SerializeField]
    private int m_life;
    [SerializeField]
    private int m_resource;

    public int MyMaxDurability
    {
        get
        {
            return m_maxLife;
        }

        set
        {
            m_maxLife = value;
        }
    }

    public int MyDurability
    {
        get
        {
            return m_life;
        }

        set
        {
            m_life = value;
            if (m_life <= 0)
            {
                SceneManager.LoadScene("DeadScene");
            }
        }
    }

    public int MyResource
    {
        get
        {
            return m_resource;
        }

        set
        {
            m_resource = value;
        }
    }

    // Use this for initialization
    void Start ()
    {
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        TakeDamage(other.GetComponent<EnemyParent>().MyDamage);
        Destroy(other.gameObject);
    }

    public void Fix(int amount)
    {
        MyDurability += amount;
    }

    public void TakeDamage(int amount)
    {
        MyDurability -= amount;
    }
}
