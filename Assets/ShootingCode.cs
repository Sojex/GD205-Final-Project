using UnityEngine;
using System.Collections;

public class ShootingCode : MonoBehaviour {


	public GameObject bullet;
	public Transform bulletSpawn;
//	public float deathTime= 10f;no need for this code
	GameObject bulletClone;
	public float fireRate=2f;


	// Use this for initialization
	void Start () {

		

	}
	
	// Update is called once per frame
	void  Update () {
	
		if (Input.GetMouseButtonDown (0)) {
		//instantiates the bullet and names the clones bulletclone
			bulletClone = Instantiate(bullet,bulletSpawn.position,bulletSpawn.rotation) as GameObject;


			//destroys the bullets after 4 seconds
			Destroy(bulletClone,4f);
		
		
		}




	}
}
