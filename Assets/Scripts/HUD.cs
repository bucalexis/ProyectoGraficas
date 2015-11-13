using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class HUD : MonoBehaviour {


	public float tiempo= 10;

	public Text tiempoTexto;

	public Image reloj;

	public Sprite reloj1;
	public Sprite reloj2;

	
	public static int HumanosConvertidos= 0;

	public Text humanosConvertidosTexto;


	public int HumanosAMatar = 2;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		tiempo -= Time.deltaTime;
		tiempoTexto.text = tiempo.ToString("f0");

		humanosConvertidosTexto.text = HumanosConvertidos.ToString();


		if (tiempo <= 10) {
			reloj.sprite =  reloj2;
		}

		if (HumanosConvertidos == HumanosAMatar && tiempo > 0) {
			//Ganaste
			Application.LoadLevel (2);
		
		
		}
		if (tiempo < 0 && HumanosConvertidos != HumanosAMatar) {
		//Perdiste
			Application.LoadLevel (3);
		
		}


		//Para manipular seccion de humanos convertidos


		if(HumanosConvertidos<10)//	Cambiar texto a rojo cuando se ha convertido menos de 10 humanos
		humanosConvertidosTexto.color = new Color32 (200, 26, 36,255);
		if(HumanosConvertidos>=10&&HumanosConvertidos<20)//	Cambiar texto a amarillo cuando se ha convertido entre 10 y 19 humanos
			humanosConvertidosTexto.color = new Color32 (255, 255, 0,255);
		if(HumanosConvertidos>19)//	Cambiar texto a verde cuando se ha convertido a mas de 20 humanos
			humanosConvertidosTexto.color = new Color32 (0, 130, 0,255);

		//Actualizar text
		humanosConvertidosTexto.text = HumanosConvertidos+"/"+HumanosAMatar;



	}
}
