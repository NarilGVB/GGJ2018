using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

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
		Debug.Log ("Principio---------Se activa la iglesia numero: " + i);
		iglesias [i].GetComponent<Iglesia> ().comprable();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void LanzarEvt(Evento evt, GameObject iglesia){
		
		iglesiaS = iglesia;
		eventNow = evt;
		eventoCard.SetActive (true);
		eventoCard.transform.FindChild ("Pregunta").gameObject.GetComponent<TextMeshProUGUI> ().text = eventNow.P;

		eventoCard.transform.FindChild ("Rest1").gameObject.GetComponent<Button> ().GetComponentInChildren<TextMeshProUGUI> ().text = "Comprar";
		eventoCard.transform.FindChild ("Rest1").gameObject.GetComponent<Button> ().onClick.AddListener (comprar);

		eventoCard.transform.FindChild ("Rest2").gameObject.GetComponent<Button> ().GetComponentInChildren<TextMeshProUGUI> ().text = "No comprar";
		eventoCard.transform.FindChild ("Rest2").gameObject.GetComponent<Button> ().onClick.AddListener (noComprar);

		eventoCard.transform.FindChild ("Image").gameObject.GetComponent<Image> ().overrideSprite = (Sprite)Resources.Load (evt.img, typeof(Sprite));

	}
	public void comprar(){
		eventoCard.SetActive(false);
		iglesiaS.GetComponent<Iglesia> ().comprar();
		Debug.Log (eventNow.opcion1 [0]);
		Debug.Log ("HAY " + eventNow.opcion1.Count + " TANTAS OPCIONES EN ESTA IGLESIA");
		player.GetComponent<Player> ().Modificar (eventNow.opcion1 [0].mod);
		activarSig ();
		StartCoroutine (Wait ());
	}
	public void noComprar(){
		eventoCard.SetActive(false);
		StartCoroutine (Wait ());
	}

	public IEnumerator Wait(){

		yield return new WaitForSeconds (.5f);

		FindObjectOfType<Player> ().canPress = true;

	}
	public void activarSig(){
		i++;
		Debug.Log ("Continua---------Se activa la iglesia numero: " + i);
		if (i != iglesias.Length) {
			Debug.Log ("Hay " + iglesias.Length + " iglesias");
			iglesias [i].GetComponent<Iglesia> ().comprable();
		}
	}
}
