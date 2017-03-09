using UnityEngine;
using System.Collections;
using System;

public class HealingTower : TowerParent, IRecurringAction {

    [SerializeField]
    private float m_healRate;
    [SerializeField]
    private int m_healingPower;

    private float m_lastHeal;

    public float MyActionTimeGap
    {
        get
        {
            return m_healRate;
        }

        set
        {
            m_healRate = value;
        }
    }

    public IEnumerator RecurAction()
    {
        yield return new WaitForSeconds(MyActionTimeGap);
        Heal(m_healingPower);
    }

    // Use this for initialization
    protected override void Start()
    {
        base.Start();
        MyActionTimeGap = MyActionTimeGap;
        m_buildingSpace.Add(Vector2.left);
        m_buildingSpace.Add(Vector2.up);
    }

    protected override void CheckState()
    {
        switch (m_state)
        {
            case DefenceState.ToPlace:
                transform.position = Drag();
                //DefenceStateToPlace();
                break;

            case DefenceState.Placed:
                if (Time.time > MyActionTimeGap + m_lastHeal)
                {
                    StartCoroutine(RecurAction());
                    m_lastHeal = Time.time;
                }
                break;
        }
    }

    // Update is called once per frame
    void Update ()
    {
	    
	}

    void Heal(int amount)
    {
        Debug.Log("HEAL");
        FindObjectOfType<Player>().MyDurability += amount;
        RecurAction();
    }
}
