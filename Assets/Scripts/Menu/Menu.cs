using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Empezar(){

		Application.LoadLevel (1);

	}

	public void Salir(){
		
		Application.Quit();
		
	}
}
