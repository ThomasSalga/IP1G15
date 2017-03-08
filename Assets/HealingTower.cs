using UnityEngine;
using System.Collections;
using System;

public class HealingTower : TowerParent, IRecurringAction {

    [SerializeField]
    private float m_healRate;
    private int m_healingPower;

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

    // Update is called once per frame
    void Update ()
    {
	    
	}

    void Heal(int amount)
    {
        MyDurability += amount;
    }
}
