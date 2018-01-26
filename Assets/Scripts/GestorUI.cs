using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GestorUI : MonoBehaviour {

	Player player;

	[SerializeField]
	TextMeshProUGUI adeptos;
	[SerializeField]
	TextMeshProUGUI herejes;
	[SerializeField]
	TextMeshProUGUI dinero;

	[SerializeField]
	Image S_adeptos;
	[SerializeField]
	Image S_herejes;

	public void ActualizarUI(){
		adeptos.text = player.adeptos + "%";
		herejes.text = player.hereges + "%";
		dinero.text = player.money + "";

		S_adeptos.fillAmount = player.adeptos * 0.01f;
		S_herejes.fillAmount = player.hereges * 0.01f;
	}

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<Player> ();
		ActualizarUI ();
	}
}
