using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GestorIglesia : MonoBehaviour {

	public GameObject[] iglesias;
	public int i;
	public GameObject eventoCard;
	public Evento eventNow;
	public GameObject iglesiaS;
	public GameObject player;
	//se activan en secuencia
	//necesito una pruebas de iglesias
	//tambien falta escena de selecion para configurar el player

	// Use this for initialization
	void Start () {
		iglesias = GameObject.FindGameObjectsWithTag ("Iglesia");
		iglesias [i].GetComponent<Iglesia> ().comprable();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void LanzarEvt(Evento evt, GameObject iglesia){
		iglesiaS = iglesia;
		eventNow = evt;
		eventoCard.SetActive (true);
		eventoCard.transform.FindChild ("Pregunta").gameObject.GetComponent<Text> ().text = eventNow.P;

		eventoCard.transform.FindChild ("Rest1").gameObject.GetComponent<Button> ().GetComponentInChildren<Text> ().text = "Comprar";
		eventoCard.transform.FindChild ("Rest1").gameObject.GetComponent<Button> ().onClick.AddListener (comprar);

		eventoCard.transform.FindChild ("Rest2").gameObject.GetComponent<Button> ().GetComponentInChildren<Text> ().text = "No comprar";
		eventoCard.transform.FindChild ("Rest2").gameObject.GetComponent<Button> ().onClick.AddListener (noComprar);

		eventoCard.transform.FindChild ("Image").gameObject.GetComponent<Image> ().overrideSprite = (Sprite)Resources.Load (evt.img, typeof(Sprite));

	}
	public void comprar(){
		eventoCard.SetActive(false);
		iglesiaS.GetComponent<Iglesia> ().comprar();
		player.GetComponent<Player> ().Modificar (eventNow.opcion1 [0].mod);
		activarSig ();
	}
	public void noComprar(){
		eventoCard.SetActive(false);
	}
	public void activarSig(){
		i++;
		if (i != iglesias.Length) {
			iglesias [i].GetComponent<Iglesia> ().comprable();
		}
	}
}
