using UnityEngine;
using System.Collections;

public class Jugador : MonoBehaviour {

	public float velocidad = 5.0f;

	// Rigidbody 2D
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 posicion = transform.localPosition;

		if (Input.GetKey (KeyCode.RightArrow)) {
			posicion.x += velocidad * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			posicion.x -= velocidad * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			posicion.y += velocidad * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			posicion.y -= velocidad * Time.deltaTime;
		}

		transform.localPosition = posicion;

		// Seguir jugador
		Vector3 posicionCamara = new Vector3 (
				posicion.x,
				posicion.y,
				-100.0f
		);
	
		Camera.main.transform.localPosition = posicionCamara;












	}
}
