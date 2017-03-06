using UnityEngine;
using System.Collections;

public class MeleeEnemy : EnemyParent
{
    public override void Attack()
    {
        Stop();
        if (MyTarget != null)
        {
            StartCoroutine(RecurAction());
            MyTarget.GetComponent<TowerParent>().TakeDamage(MyDamage);
        }
        //else m_state = EnemyState.Move;
    }
}
