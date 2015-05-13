using UnityEngine;
using System.Collections;

public class AttackComponent
{

	int _damage;
	Element _element;

	//array of x/y coordiantes to represent the affected tiles assuming impact of attack @ 0,0

	public int damage
	{
		get { return _damage; }
		set { _damage = value; }
	}
	
	public Element state
	{
		get { return _element; }
		set { _element = value; }
	}

}

