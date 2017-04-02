using UnityEngine;
using System.Collections;

public class BuildingDamageScript : MonoBehaviour {

	public SpriteRenderer damageVisual;
	public Sprite stage1;
	public Sprite stage2;
	public Sprite stage3;
	public Sprite stage4;
	float actualHealth;


	// Use this for initialization
	void Start () {
	
		actualHealth= (float)gameObject.GetComponent<TowerParent> ().MyDurability/5;
		damageVisual = gameObject.GetComponent<SpriteRenderer>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
	





		float finalHealth = (float)gameObject.GetComponent<TowerParent> ().MyDurability; //75
	
	


		if (finalHealth <= actualHealth * 5) {
			damageVisual.sprite = stage1;
		}
		if (finalHealth <= actualHealth * 4) {
			damageVisual.sprite = stage2;
		}
		if (finalHealth <= actualHealth * 3) {
			damageVisual.sprite = stage3;
		}
		if (finalHealth <= actualHealth * 2) {
			damageVisual.sprite = stage4;
		}

	}
}
