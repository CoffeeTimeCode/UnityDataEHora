using UnityEngine;
using System.Collections;
using System;

public class DataEHora : MonoBehaviour {
	public DateTime _inicio;
	void Start () { _inicio = DateTime.Now; print (_inicio);}
	void Update () {}
}
