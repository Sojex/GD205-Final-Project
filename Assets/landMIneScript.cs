using UnityEngine;
using System.Collections;

public class landMIneScript : MonoBehaviour {

	// Use this for initialization
	//Land mine Code
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	void OnCollisionEnter(Collision col){

		//Destroysthe player if he touches it

		if (col.gameObject.tag == "Player") {
			Destroy(col.gameObject);
		}
	}
	
	
}


