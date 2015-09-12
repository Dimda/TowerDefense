using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MonsterList {

	private static int[,,] monsterList = {
										{{0,1,0,-1,-1},{0,1,2,0,3},{0,1,2,0,3,5}},//Level 1
										{{0,1,0,0,2},{0,1,2,0,3},{0,1,2,0,3,5}}//Level 2
										};

	public static int GetMonsterID(int level,int wave,int monster)
	{
		return monsterList[level,wave,monster];
	}

	public static int GetWaveMonsterCount()
	{
		return MonsterList.monsterList.GetLength(2);
	}

}
