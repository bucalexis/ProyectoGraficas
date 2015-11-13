using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour {
		

	public float speed = 20;
	// Use this for initialization
	public GameObject bala;
	 Rigidbody rb ;

	GameObject aux;

	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
			
		if (Input.GetKeyDown("space"))
		{  
		
			aux = Instantiate(bala, transform.position, transform.rotation) as GameObject;
			aux.GetComponent<Rigidbody>().velocity = new Vector3(0,0,speed);
			Destroy (aux, 3);
		}


	}
}
