using UnityEngine;
using System.Collections;

public class waveManager : MonoBehaviour {

	public int currentWave = 1;		//wave counter
	public bool allowSpawn = true;	//allows zombies to spawn
	private bool waveIdle;	//detects is the wave time is over but still are zombies
	public float waveTime = 10;	//duration of wave

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Time.time > waveTime)
		{
			allowSpawn = false;
			if(GameObject.FindGameObjectWithTag("Enemy") == null)
			{
				waveEnd ();
			}
		}
	
	
	}

	void waveEnd()
	{

		currentWave ++;
		waveTime = Time.time + currentWave *10;
		allowSpawn = true;
	}
}
