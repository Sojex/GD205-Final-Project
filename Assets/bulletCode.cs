using UnityEngine;
using System.Collections;


public class bulletCode : MonoBehaviour {
	public float speed = 100000000000000000000000000000000000000f;
	public Vector3 trajectory;
	public Rigidbody rb;
   // GameObject enemy;
	// Use this for initialization

	//Code that makes the player's bullets go forward as well as destroy enemies
	void Start () {
		//used to be able to use the bullet's rigid body
		rb = GetComponent<Rigidbody> ();

		//creates direction at which i will push te bullet
		trajectory = transform.forward * speed;
		//enemy = GameObject.Find ("enemy");  


	}
	
	// Update is called once per frame
	void Update () {
		// bullet movement code
		rb.AddForce (trajectory);






	}
		




	void OnCollisionEnter(Collision col){
	//enemy destroying code
		if (col.gameObject.tag == "enemy") {
			Destroy(col.gameObject);
			//Debug.Log("HIT");

		}
	
	}


}
