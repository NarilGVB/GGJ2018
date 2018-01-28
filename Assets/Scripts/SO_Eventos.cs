using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Events",menuName = "Events")]
public class SO_Eventos : ScriptableObject {

	public List<Evento> Hospital = new List<Evento>();

	public List<Evento> Gim = new List<Evento>();

	public List<Evento> Tienda = new List<Evento>();

	public List<Evento> Parque = new List<Evento>();

	public List<Evento> Banco = new List<Evento>();

	public List<Evento> Empresa = new List<Evento>();

	public List<Evento> Estatua = new List<Evento>();
}
