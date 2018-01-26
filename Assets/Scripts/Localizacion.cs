using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class Localizacion : MonoBehaviour {

	[SerializeField]
	public List<Evento> lEventos = new List<Evento>();
	public GameObject gestorEventos;

	//se puede realizar un array de eventos y un gestor oersonalizado que a partir de 
	// cierta cantidad de eventos totales(en player) sacado se activen

	//o ponerlo todo en secuencia

	// Use this for initialization
	void Start () {
		/*
		//crear Defecto
		Evento evt = new Evento();


		evt.accion1 = new List<string>();
		evt.accion2 = new List<string>();
		evt.P ="";
		evt.R1 = "";
		evt.adeptos = 0;
		evt.money = 0;
		evt.hereges = 0;
		evt.R2 = "";
		evt.img ="minion";
		evt.adeptos2 = 0 ;
		evt.money2 = 0 ;
		evt.hereges2 = 0;
		lEventos.Add (evt);


		//Evento 1
		evt = new Evento();
		evt.txts1 = new ArrayList ();
		evt.aims1 = new ArrayList ();
		evt.txts2 = new ArrayList ();
		evt.txts2 = new ArrayList ();
		evt.P ="Ultimamente la población a dejado de hacer ejercicio. ¿Se te ocurre alguna forma de solucionarlo?";
		evt.R1 = "Dejalos ser";
		evt.txts1.Add("Lo vagos se te unen pero la mayoría se mueren de una ataque al corazón.");
		evt.adeptos = 3;
		evt.money = 0;
		evt.hereges = 0;
		evt.R2 = "Que recen haciendo el pino";	
		evt.txts2.Add("La gente fan del fitness se te une. Tus creyentes ganan vitalidad y te lo agradecen con donaciones.");			
		evt.img ="minion";
		evt.adeptos2 = 10 ;
		evt.money2 = 50 ;
		evt.hereges2 = 2;
		lEventos.Add (evt);

		//Evento 2
		evt = new Evento();
		evt.P ="Hay una escased de importación de pescado. ¿Con que sugieres que lo sustituyamos?";
		evt.R1 = "Con verdura.";
		evt.txts1.Add ("El aumento de la verdura en la dieta de una sociedad que consume demasiada proteina hace que las facturas " +
			"médicas de tus creyentes bajen y te donen más dinero.Tus medidas se han hecho populares entre los vegetarianos y ahora te siguen.");
		evt.adeptos = 10;
		evt.money = 50;
		evt.hereges = 0;
		evt.R2 = "Con carne.";	
		evt.txts2.Add("Tus seguidores compran carne pero debido a la subida de precios pueden donarte menos dinero.Los animalistas se manifiestan en tu contra por perpetuar el sufrimiento animal en la industria carnicera.");	
		evt.img ="minion";
		evt.adeptos2 = 5 ;
		evt.money2 = -10 ;
		evt.hereges2 = 0;
		lEventos.Add (evt);

		//Evento 3
		evt = new Evento();
		evt.P ="Hemos encontrado un ojeto extraño. ¿Deberíamos cogerlo o destruirlo?";
		evt.R1 = "Tomalo adoradlo pues es un regalo de dios.";
		evt.txts1.Add("Era una piedra radiactiva. Algunos creyentes han muerto de cancer y tienes que pagar una indemnización a su familia.");
		evt.adeptos = -5;
		evt.money = -50;
		evt.hereges = 0;
		evt.R2 = "";	
		evt.txts2.Add("");			
		evt.img ="minion";
		evt.adeptos2 = 0 ;
		evt.money2 = 0 ;
		evt.hereges2 = 0;
		lEventos.Add (evt);

		//Evento 4
		evt = new Evento();
		evt.P ="Un viejo vagabundo afirma que nuestro dios Cthulu es falso y que eres un vendemotos.";
		evt.R1 = "Encerradle en un psiquiátrico";
		evt.txts1.Add ("Consigues acallarle pero como el señor no tiene familia tienes que pagas la factura médica.");
		evt.adeptos = 0;
		evt.money = -10;
		evt.hereges = 0;
		evt.R2 = "Dejadle hablar. La verdad siempre sale a la luz.";	
		evt.txts2.Add("Pocos hacen caso al hombre devido a la aporofobia. No pierdes muchos seguidores pero la duda se siembra en algunos\ncorazones. ¿Será verdad que estarán adorando a un monstruo inventado?");	
		evt.img ="minion";
		evt.adeptos2 = -2 ;
		evt.money2 = 0 ;
		evt.hereges2 = 0;
		lEventos.Add (evt);

		//Evento 5
		evt = new Evento();
		evt.P ="Hay un enfermo con una diagnóstico desconocido. ¿Puedes curarle?";
		evt.R1 = "";
		evt.txts1.Add("");
		evt.adeptos = 0;
		evt.money = 0;
		evt.hereges = 0;
		evt.R2 = "";	
		evt.txts2.Add("");			
		evt.img ="minion";
		evt.adeptos2 = 0 ;
		evt.money2 = 0 ;
		evt.hereges2 = 0;
		lEventos.Add (evt);
		*/

	}

	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown(){	
		if (FindObjectOfType<Player> ().canPress) {
			FindObjectOfType<Player> ().canPress = false;
			if (lEventos.Count != 0) {
				int numero = (int)Math.Ceiling ((float)UnityEngine.Random.Range (0, lEventos.Count));

				GetComponent<BoxCollider2D> ().enabled = false;
				gestorEventos.GetComponent<GestoEventos> ().LanzarEvt ((Evento)lEventos [numero], this.gameObject);

				lEventos.Remove (lEventos [numero]);
			}
		}
	}

}
