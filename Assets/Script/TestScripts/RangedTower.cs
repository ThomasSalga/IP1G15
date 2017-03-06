using UnityEngine;
using System.Collections;

public class RangedTower : TowerParent, ISpawnGO, IRecurringAction {


    #region members

    [SerializeField]
    protected float m_atkRate; // attacks per second         //How do I connect this two values
    protected float m_atkSpeed; // time between attacks      // to change from the Inspector?
    [SerializeField]
    protected GameObject m_prefabGO;

    private float m_lastShot;
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

    public void SpawnGO(GameObject go)
    {
        Instantiate(go, transform.position, Quaternion.identity);
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.time > MyActionTimeGap + m_lastShot)
        {
            SpawnGO(MyPrefabToSpawn);
            m_lastShot = Time.time;
        }

    }
}
