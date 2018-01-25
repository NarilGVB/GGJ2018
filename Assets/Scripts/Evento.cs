using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evento : MonoBehaviour {
	public string P;
	public string R1;
	public string R2;
	public string txt1;
	public string txt2;
	public string img;
	public GameObject localidad;

	//primera opcion
	public float adeptos;
	public float money;
	public float hereges;

	//segunda opcion
	public float adeptos2;
	public float money2;
	public float hereges2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public virtual string ToString(){
		return P + R1 + R2 + txt1 + txt2;
	}
	public void Respt1(Player player){
		player.adeptos += this.adeptos;
		player.money += this.money;
		player.hereges += this.hereges;
	}
	public void Respt2(Player player){
		player.adeptos += this.adeptos2;
		player.money += this.money2;
		player.hereges += this.hereges2;
	}
}
