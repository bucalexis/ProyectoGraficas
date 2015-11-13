using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Personaje : MonoBehaviour {
	

	
	public Image image ;
	public Image imageMenu ;
	public static int vida = 3;

	public float maxSpeed = 5f;
	public bool facingLeft= true;
	
	public float moverX = 0;
	public float moverY = 0;

	Animator anim ;


	void Start () {
		anim = GetComponent<Animator> ();
		
		
		
	}



	
	// Update is called once per frame
	// Update is called once per frame
	void FixedUpdate () {
		
		moverX= Input.GetAxis("Horizontal")/maxSpeed;	
		moverY= Input.GetAxis("Vertical")/maxSpeed;	
		//Para mover en z
		this.gameObject.transform.Translate(moverX, 0, moverY);
		//print (moverY);

		/*if (moverX < 0) {	
			print ("La izquierda");
		} else if (moverX > 0){
			print ("La derecha");
		}*/
	}
	


	
	void OnTriggerEnter(Collider other)
	{

	}
	
	void OnCollisionEnter(Collision other)
	{ 

	}
}
