using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	[SerializeField]
	private int health;

	[SerializeField]
	private int defaultHealth = 100;

	// Use this for initialization
	void Start () {
		health = defaultHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public int GetHealth()
	{
		return health;
	}

	void OnDamage(int amount)
	{
		if(amount < 0)
		{
			return;
		}

		Debug.Log(gameObject.name + " recieved " + amount + " damage!");

		health -= amount;

		if(health <= 0)
		{
			health = 0;

			Debug.Log(gameObject.name + " has dead!");
			gameObject.SendMessage("OnDeath");
		}
	}

}
