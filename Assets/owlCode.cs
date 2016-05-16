using UnityEngine;
using System.Collections;

public class owlCode : MonoBehaviour {


	Rigidbody rb;
	GameObject player;
	public GameObject bullet;
	GameObject owlBullet;
	public Transform playerLocation;
	public Transform owlBulletSpawn;
	private float reload=0f;
	// Use this for initialization
	//OWL Enemy COde

	public void fire(){
		//creates function for shooting the owl's bullets
		if (owlBullet==null) {
			//instantiates the bullet and labeles the clones as owlBullet
			owlBullet = Instantiate (bullet, owlBulletSpawn.position, owlBulletSpawn.rotation) as GameObject;
			//"reload" time for this script
			reload=0f;
		}
	}
	void Start () {
		rb = GetComponent<Rigidbody> ();
		//declaring what the player is
		player = GameObject.FindGameObjectWithTag ("Player");
		//Invoke("fire",2);
	//	InvokeRepeating ("fire", 2, 2);



	}
	
	// Update is called once per frame
	void Update () {
		//used for reload time
		reload = reload+Time.deltaTime;

		}
	void OnTriggerStay(Collider player) {
		transform.LookAt(playerLocation);
		/*fires if player is in their field of vision every 2 seconds
		 * had problems with this code however because all enemies are always firing regardless if the player is withing their field of vision
		 */
		if (reload > 2f) {
			InvokeRepeating ("fire", 2, 2);

		}
		//destroys the owl bullet in 2 seconds upon creation, done to save frames
		Destroy(owlBullet,2f);	
		
		//since code is attached to empty game obj this is used to destroy the empty if the child is destroyed
		if (transform.Find ("Owl") == null) {
			Destroy(this);
		}
		//owlBullet = Instantiate(bullet,transform.position,transform.rotation) as GameObject;





	}

	/*void shoot(){
		Invoke("fire",2);
		Debug.Log ("responding");
	}
*/
}