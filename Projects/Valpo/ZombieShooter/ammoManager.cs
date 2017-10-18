using UnityEngine;

namespace CompleteProject
{
	public class ammoManager : MonoBehaviour
	{
		public GameObject ammoCan;                // The enemy prefab to be spawned.
		public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
		//public waveManager wavMan;
		private int ammoIndex = 0;
		
		void Update ()
		{
			//print ("SPAWN STUFF WHY NOT A BOX");
			if(GameObject.FindGameObjectWithTag("Ammo")==null)
			{
				// If the player has no health left...
				if(ammoIndex>spawnPoints.Length)
				{
					ammoIndex =0;
				}
				else
				{
					ammoIndex ++;
				}
				Instantiate (ammoCan, spawnPoints[ammoIndex].position, spawnPoints[ammoIndex].rotation);
			}
		}
	}
}
