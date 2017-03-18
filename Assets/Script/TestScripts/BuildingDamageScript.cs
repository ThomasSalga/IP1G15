using UnityEngine;
using System.Collections;

public class BuildingDamageScript : MonoBehaviour {

	public SpriteRenderer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	

		gameObject.GetComponent<SpriteRenderer>().sprite;

		float actualhealth= (float)gameObject.GetComponent<TowerParent> ().MyDurability/4;

		float finalHealth = (float)gameObject.GetComponent<TowerParent> ().MyDurability; //75
	

		if (finalHealth <= actualhealth) {
			healthBar.sprite = health100;
		}
		if (finalHealth <= actualhealth/4 * 3) {
			healthBar.sprite = health95;
		}
		if (finalHealth <= actualhealth) {
			healthBar.sprite = health90;
		}
		if (finalHealth <= actualhealth) {
			healthBar.sprite = health85;
		}

	}
}
