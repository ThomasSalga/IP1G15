using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnlockTower : TowerParent {

	#region members


	protected GameObject m_prefabGO;


	#endregion




	// Use this for initialization
	protected override void Start()
	{
		base.Start();

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
			
			break;
		}
	}

	public void SpawnGO(GameObject go)
	{
		Instantiate(go, transform.position, Quaternion.identity);
	}
}
