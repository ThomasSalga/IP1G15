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
			Animator animator = GetComponent<Animator>() as Animator;
			animator.SetTrigger("attacking");

            MyTarget.GetComponent<TowerParent>().TakeDamage(MyDamage);
        }
        //else m_state = EnemyState.Move;
    }
}
