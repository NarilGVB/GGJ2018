using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Evento {
	[System.Serializable]
	public struct Accion{
		[TextArea(2,5)]
		public string text;
		public string anim;
		public Modificacion mod;
	}

	[System.Serializable]
	public struct Modificacion{
		public float adeptos;
		public float money;
		public float hereges;
	}

	[TextArea(2,5)]
	public string P;
	public string R1;
	public string R2;
	//public string txt1;
	//public string txt2;
	public bool textDouble;
	//primero textos
	public List<Accion> opcion1 = new List<Accion>();
	public List<Accion> opcion2 = new List<Accion>();

	public string img;
	public GameObject localidad;

}
