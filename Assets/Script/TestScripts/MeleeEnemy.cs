using UnityEngine;
using System.Collections;

public class MeleeEnemy : EnemyParent
{
    public override void Attack()
    {
        Debug.Log("I HIT " + MyTarget.name);
        Stop();
        if (MyTarget != null)
        {
            StartCoroutine(RecurAction());
            //other.gameObject.GetComponent<BuildingParent>().TakeDamage(MyDamage);
        }
        else m_state = EnemyState.Move;
    }
}
