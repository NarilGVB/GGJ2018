using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Localizacion : MonoBehaviour {

	public ArrayList lEventos;
	public GameObject gestorEventos;
	public int i;

	// Use this for initialization
	void Start () {
		lEventos = new ArrayList ();
		//crear evento
		Evento evt = new Evento();
		evt.txt1 = "bla bla bla1";
		evt.txt2 = "bla bla bla2";
		evt.P ="yo pregunto";
		evt.R1 = "Respuesta 1";
		evt.R2 = "Respuesta 2";		
		evt.img ="minion";
		evt.adeptos = 1;
		evt.adeptos2 = 1;
		evt.money = 1;
		evt.money2 = 1;
		evt.hereges = 1;
		evt.hereges2 = 1;
		lEventos.Add (evt);

		//crear evento
		evt = new Evento();
		evt.txt1 = "lsjkdfnvjusdodswncoi1";
		evt.txt2 = "sdkcvjofvjmrwkvmfklñ2";
		evt.P ="balksnasnlsnmcdasdpregunta";
		evt.R1 = "fsgdfvdfgddbvRespuesta 1";
		evt.R2 = "fvertvgertverRespuesta 2";		
		evt.img ="minion";
		evt.adeptos = 1;
		evt.adeptos2 = 1;
		evt.money = 1;
		evt.money2 = 1;
		evt.hereges = 1;
		evt.hereges2 = 1;
		lEventos.Add (evt);

	}

	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown(){			
		if (!(lEventos.Count == i - 1)) {
			GetComponent<BoxCollider2D> ().enabled = false;
			gestorEventos.GetComponent<GestoEventos> ().LanzarEvt ((Evento)lEventos [i],this.gameObject);
			i++;
		}
	}

}
