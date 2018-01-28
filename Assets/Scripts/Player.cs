using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public string img;
	public string nombre;
	public float adeptos;
	public float money;
	public float neutros;
	public float hereges;
	public int eventosT;

	public bool canPress = true;

	GestorUI UIManager;

	//falta poner estado de victoria y derrota

	// Use this for initialization
	void Start () {
		UIManager = FindObjectOfType<GestorUI> ();
	}

	public void Modificar(Evento.Modificacion mod){
		this.adeptos += mod.adeptos;
		this.money += mod.money;
		this.hereges += mod.hereges;

		UIManager.ActualizarUI ();

		if (money <= -50) {
			//final banca rota
		} else if (adeptos >= 80) {
			//final victoria
		} else if (hereges >= 30) {
			//final destrucción
		}
	}
}
