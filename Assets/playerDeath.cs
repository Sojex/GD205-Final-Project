using UnityEngine;
using System.Collections;

public class playerDeath : MonoBehaviour {
	public GameObject Player;
	// Use this for initialization
	//code attatched to the light to detect if the player dies to load game over scene
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Player == null) {
	//loads game over screen if the player is destroyed
			Application.LoadLevel ("GameOver");
			//unlockes the cursor
			Screen.lockCursor = false;
		}
	}
}
