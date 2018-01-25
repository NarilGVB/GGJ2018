using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public string img;
	public string name;
	public float adeptos;
	public float money;
	public float neutros;
	public float hereges;

	// Use this for initialization
	void Start () {
		//Debug
		name = "chutulu";
		adeptos = 100;
		money = 100;
		neutros = 50;
		hereges = 20;
		img = "ChutuluSketch";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
