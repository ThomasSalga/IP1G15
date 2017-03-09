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

    // Use this for initialization
    void Start ()
    {
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        m_life--;
    }

    public void Fix(int amount)
    {
        throw new NotImplementedException();
    }

    public void TakeDamage(int amount)
    {
        throw new NotImplementedException();
    }
}
