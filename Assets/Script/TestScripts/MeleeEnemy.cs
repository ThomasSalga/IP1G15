using UnityEngine;
using System.Collections;


public class MeleeEnemy : EnemyParent
{
    public override void Attack()
	{
		Stop ();
		if (MyTarget != null)
        {			
			StartCoroutine (RecurAction ());
			MyTarget.GetComponent<TowerParent> ().TakeDamage (MyDamage);
		} 
	}

    public override IEnumerator RecurAction()
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(m_atkSpeed);
        Attack();
    }

    
}
