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

	//falta poner estado de victoria y derrota

	// Use this for initialization
	void Start () {
		//Debug
		nombre = "chutulu";
		adeptos = 100;
		money = 100;
		neutros = 50;
		hereges = 20;
		img = "ChutuluSketch";
	}

	public void Modificar(Evento.Modificacion mod){
		this.adeptos += mod.adeptos;
		this.money += mod.money;
		this.hereges += mod.hereges;
	}
}
