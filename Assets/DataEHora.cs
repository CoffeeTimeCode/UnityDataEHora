using UnityEngine;
using System.Collections;
using System;

public class DataEHora : MonoBehaviour {
	public DateTime _inicio;

	void Start () { 
		_inicio = DateTime.Now; print (_inicio);

		//adicionar dias
		print (DateTime.Now.AddDays(2));

		//adicionar meses
		print (DateTime.Now.AddMonths(1));

		//adicionar anos
		print (DateTime.Now.AddYears(1));

		//adicionar horas
		print (DateTime.Now.AddHours(2));

		//adicionar minutos
		print (DateTime.Now.AddMinutes(1));

		//Pegar o dia
		print (DateTime.Now.Day);

		//Pegar o mês
		print (DateTime.Now.Month);

		//Pegar o ano
		print (DateTime.Now.Year);

		//Pegar a hora
		print (DateTime.Now.Hour);

		//Pegar os minutos
		print (DateTime.Now.Minute);

		//Pegar os segundos
		print (DateTime.Now.Second);

	}

	void Update () {}
}
