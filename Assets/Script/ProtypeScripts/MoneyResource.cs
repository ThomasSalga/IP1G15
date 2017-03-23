using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class MoneyResource : MonoBehaviour, IRecurringAction
{
    [SerializeField]
    private float m_earningRate;
    [SerializeField]
    public int m_earningAmount;

    private float m_lastPenny;
    private GameObject m_player;

    public float MyActionTimeGap
    {
        get
        {
            return m_earningRate;
        }

        set
        {
            m_earningRate = value;
        }
    }

    public IEnumerator RecurAction()
    {
        yield return new WaitForSeconds(MyActionTimeGap);
        EarnMoney(m_earningAmount);
    }

    public void EarnMoney(int amount)
    {
        FindObjectOfType<Player>().MyResource += amount;
        StartCoroutine(RecurAction());
    }

    public void OneShotEarnMoney(int amount)
    {
        FindObjectOfType<Player>().MyResource += amount;
    }

}
