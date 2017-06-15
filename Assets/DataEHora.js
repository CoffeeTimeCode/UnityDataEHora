#pragma strict
public var _inicio : Date;
function Start () {
	_inicio = new Date().Now; print(_inicio);
	
	//adicionar dias
	print (new Date().Now.AddDays(2));

	//adicionar meses
	print (new Date().Now.AddMonths(1));

	//adicionar anos
	print (new Date().Now.AddYears(1));

	//adicionar horas
	print (new Date().Now.AddHours(2));

	//adicionar minutos
	print (new Date().Now.AddMinutes(1));

	//Pegar o dia
	print (new Date().Now.Day);

	//Pegar o mês
	print (new Date().Now.Month);

	//Pegar o ano
	print (new Date().Now.Year);

	//Pegar a hora
	print (new Date().Now.Hour);

	//Pegar os minutos
	print (new Date().Now.Minute);

	//Pegar os segundos
	print (new Date().Now.Second);
}
function Update () {}