using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Portal : MonoBehaviour {

	public Health baseHealth;

	private float monsterSpawnGap = 1;
	private float lastMonsterSpawnTime;

	private int currentMonster;
	

	public GameObject[] monsters;

	public static GameStatus status {get;set;}
	
	public static int money {get;set;}

	public static int numberOfMonsterRemaining {get;set;}
	
	public static int maxWaveCount = 5;
	
	public static int currentWave {get;set;}

	public static int currentLevelNumber {get;set;}


	// Use this for initialization
	void Start () {
		money = 100;

		currentMonster = 0;
		lastMonsterSpawnTime = Time.time;
		status = GameStatus.GamePlay;
		currentLevelNumber = 0;
	}
	
	// Update is called once per frame
	void Update () {

		//check for game over
		if(baseHealth.GetHealth() <= 0)
		{
			//Game over
			status = GameStatus.GameOver;
			Debug.Log("GameOver");
		}
		else if(currentWave >= maxWaveCount)
		{
			//Game completed
			status = GameStatus.Completed;
			Debug.Log("Clear");
		}

		if(status == GameStatus.GamePlay)
		{

			if(currentMonster < MonsterList.GetWaveMonsterCount())
			{
				if(Time.time - lastMonsterSpawnTime > monsterSpawnGap)
				{
					//Spawn monster
					Debug.Log(MonsterList.GetMonsterID(currentLevelNumber,currentWave,currentMonster) + " was spawned.");

					GameObject monster;

					monster = GameObject.Instantiate(monsters[MonsterList.GetMonsterID(currentLevelNumber,currentWave,currentMonster)]);
					monster.SetActive(true);
					monster.transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z);

					lastMonsterSpawnTime = Time.time;

					//Decrease monster count
					numberOfMonsterRemaining--;

					currentMonster++;
				}
			}
		}

	}


}
