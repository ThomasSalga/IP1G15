using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RangedTower : TowerParent, ISpawnGO, IRecurringAction {

    #region members

    [SerializeField]
    protected float m_atkRate; // attacks per second         //How do I connect this two values
    protected float m_atkSpeed; // time between attacks      // to change from the Inspector?
    [SerializeField]
    protected GameObject m_prefabGO;

    private float m_lastShot;
    private float m_lastPenny;
    #endregion

    #region Interfaces' Properties

    public float MyActionTimeGap
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

    public GameObject MyPrefabToSpawn
    {
        get
        {
            return m_prefabGO;
        }

        set
        {
            m_prefabGO = value;
        }
    }
    #endregion

    public IEnumerator RecurAction()
    {
        yield return new WaitForSeconds(m_atkSpeed);
        SpawnGO(MyPrefabToSpawn);
    }

    // Use this for initialization
    protected override void Start()
    {
        base.Start();
        MyActionTimeGap = MyActionTimeGap;
        m_buildingSpace.Add(Vector2.left);
    }

    // Update is called once per frame
    void Update ()
    {
        

    }

    protected override void CheckState()
    {
        switch (m_state)
        {
            case DefenceState.ToPlace:
                transform.position = Drag();
                break;

            case DefenceState.Placed:
                if (Time.time > m_atkSpeed + m_lastShot)
                {
                    StartCoroutine(RecurAction());
                    m_lastShot = Time.time;
                }
                if (Time.time > m_atkSpeed*2 + m_lastPenny)
                {
                    FindObjectOfType<Player>().MyResource++;
                    m_lastPenny = Time.time;
                }
                break;
        }
    }

    public void SpawnGO(GameObject go)
    {
        Instantiate(go, transform.position, Quaternion.identity);
    }
}
