using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class GestoEventos : MonoBehaviour {

	public float tEvent;
	//public ArrayList lEventos;
	public float tiempoAcumuladoEvnt;
	public float tiempoAnimcion = 1f;
	public GameObject eventoCard;
	public GameObject eventoResp;
	public Evento eventNow;

	public GameObject objetoEvent;

	//falta probar animaciones y sonidos

	// Use this for initialization
	void Start () {		
		/*lEventos = new ArrayList ();
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
		*/
		//Debug.Log ("Evento lanzado");
		//tiempoAcumuladoEvnt = 0;
		//Text text = textoUI.GetComponent<Text> ();
		//text =lEventos.
		//Debug.Log ("aaaaaaaaa" + ((Evento)lEventos[0]).ToString());
		//Debug.Log (lEventos.Count);
		//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		//LanzarEvt((Evento)lEventos[0]);
		//text.text = ((Evento)lEventos [0]).P;


	}
	
	// Update is called once per frame
	void Update () {
		/*tiempoAcumuladoEvnt += Time.deltaTime;
		if(tiempoAcumuladoEvnt>tEvent){
			
		}*/

	}
	public void LanzarEvt(Evento evt, GameObject puntoEvent){
		
		objetoEvent = puntoEvent;

		eventNow = evt;
		eventoCard.SetActive (true);
		eventoCard.transform.FindChild ("Pregunta").gameObject.GetComponent<TextMeshProUGUI> ().text = eventNow.P;

		eventoCard.transform.FindChild ("Rest1").gameObject.GetComponent<Button> ().GetComponentInChildren<TextMeshProUGUI> ().text = eventNow.R1;
		eventoCard.transform.FindChild ("Rest1").gameObject.GetComponent<Button> ().onClick.AddListener (Respt1);

		eventoCard.transform.FindChild ("Rest2").gameObject.GetComponent<Button> ().GetComponentInChildren<TextMeshProUGUI> ().text = eventNow.R2;
		eventoCard.transform.FindChild ("Rest2").gameObject.GetComponent<Button> ().onClick.AddListener (Respt2);

		eventoCard.transform.FindChild ("Image").gameObject.GetComponent<Image> ().overrideSprite = (Sprite)Resources.Load (evt.img, typeof(Sprite));
	
	}
	public void Respt1(){		
		eventoCard.SetActive (false);
		int numero = (int)Math.Ceiling ((float)UnityEngine.Random.Range (0, eventNow.opcion1.Count));
		//objetoEvent.GetComponent<Animator> ().SetTrigger ((String)eventNow.opcion1 [numero].anim);
		//Esperar animacion
	
		//Debug.Log ("Respuesta1");
		//animacion
		StartCoroutine (Wait1 (numero));
	}

	public IEnumerator Wait1(int numero){
		yield return new WaitForSeconds(tiempoAnimcion);

		eventoResp.SetActive (true);
		eventoResp.transform.FindChild ("Text").gameObject.GetComponent<TextMeshProUGUI> ().text = (String)eventNow.opcion1 [numero].text;
		eventoResp.transform.FindChild ("ButtonExit").gameObject.GetComponent<Button> ().onClick.AddListener (ExitResp);
		GetComponent<Player> ().Modificar (eventNow.opcion1[numero].mod);

		yield return new WaitForSeconds (.5f);

		FindObjectOfType<Player> ().canPress = true;

	}
	public void Respt2(){
			
		eventoCard.SetActive (false);
		//Debug.Log ("Respuesta2");
		int numero = (int)Math.Ceiling ((float)UnityEngine.Random.Range (0, eventNow.opcion2.Count));
		//objetoEvent.GetComponent<Animator> ().SetTrigger ((String)eventNow.opcion2 [numero].anim);

		StartCoroutine (Wait2 (numero));
	}

	public IEnumerator Wait2(int numero){
		yield return new WaitForSeconds(tiempoAnimcion);

		eventoResp.SetActive (true);
		//random
		//primero el random luego animacion y luego texto
		eventoResp.transform.FindChild ("Text").gameObject.GetComponent<TextMeshProUGUI> ().text = (String)eventNow.opcion2[numero].text;
		eventoResp.transform.FindChild ("ButtonExit").gameObject.GetComponent<Button> ().onClick.AddListener (ExitResp);
		GetComponent<Player> ().Modificar (eventNow.opcion2[numero].mod);

		yield return new WaitForSeconds (.5f);

		FindObjectOfType<Player> ().canPress = true;
	}

	public void ExitResp(){
		eventoResp.SetActive (false);
		objetoEvent.GetComponent<BoxCollider2D> ().enabled = true;
	}
}
