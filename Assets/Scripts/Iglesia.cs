using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iglesia : MonoBehaviour {

	public Evento evento;
	//cpntrolable desde el evento
	public float precio;
	public bool comprada = false;
	public GameObject gestorIglesia;

	// Use this for initialization
	void Awake () {
		GetComponent<BoxCollider2D>().enabled=false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void comprable(){
		//dar icono de comprable
		GetComponent<BoxCollider2D>().enabled=true;
	}
	public void comprar(){
		//dar icono de comprada
		GetComponent<BoxCollider2D>().enabled=false;
		comprada = true;
	}
	void OnMouseDown(){
		//Debug.Log (evento);
		if (FindObjectOfType<Player> ().canPress) {
			FindObjectOfType<Player> ().canPress = false;
			gestorIglesia.GetComponent<GestorIglesia> ().LanzarEvt (evento, this.gameObject);
		}
	}
}
