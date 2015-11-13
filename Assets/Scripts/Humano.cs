using UnityEngine;
using System.Collections;

public class Humano : MonoBehaviour {

	// Use this for initialization
	public GameObject personaje;

	public GameObject murcielago;

	GameObject aux;
	public float distanciaParaMoverseHumano=5f;
	public float movimientoHumano = 0.1f;


	private HUD hudscript;

	void Start () {
	
	}



	// Update is called once per frame
	void FixedUpdate() {



		float distancia = Vector3.Distance(personaje.transform.position, transform.position);
		//print (distancia);

		if (distancia < distanciaParaMoverseHumano) {
		
			this.gameObject.transform.Translate(0,0, movimientoHumano);
		}
		

	}

	void OnTriggerEnter(Collider other) {

		if (other.gameObject.tag == "Bala") {

			Destroy (other.gameObject);
			Vector3 positionGameObject = this.gameObject.transform.position;
			Destroy (this.gameObject);

			aux = Instantiate (murcielago, positionGameObject, transform.rotation) as GameObject;
			Light lightComp = aux.AddComponent<Light> ();
			lightComp.color = Color.white;
			lightComp.intensity = 50;
			//aux.transform.position = (positionGameObject);

			Destroy (aux, 5);

			HUD.HumanosConvertidos+= 1;
			print(HUD.HumanosConvertidos);
		}

	}
}
