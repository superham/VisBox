using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace CompleteProject
{
	public class waveScoreManager : MonoBehaviour
	{
		public waveManager wav;        // The player's score.
		
		
		Text text;                      // Reference to the Text component.
		
		
		void Awake ()
		{
			// Set up the reference.
			text = GetComponent <Text> ();
			
			// Reset the score.
		}
		
		
		void Update ()
		{
			// Set the displayed text to be the word "Score" followed by the score value.
			text.text = "Wave: " + wav.currentWave;
		}
	}
}
