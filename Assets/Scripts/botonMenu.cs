using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class botonMenu : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler {

	// Use this for initialization
	public Button boton;
	public Sprite imagen1;
	public Sprite imagen2;
	public Text textoBoton;
	public Texture2D cursorTexture;
	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;



	
	public void OnPointerEnter (PointerEventData eventData) 
	{
		boton.GetComponent<AudioSource>().Play();
		Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
		textoBoton.color = new Color32 (255, 255, 255,255);
		boton.image.sprite = imagen2;
	}

	public void OnPointerExit (PointerEventData eventData) 
	{
		Cursor.SetCursor(null, Vector2.zero, cursorMode);
		textoBoton.color = new Color32 (255, 255, 255, 100);
		boton.image.sprite = imagen1;
	}
}
