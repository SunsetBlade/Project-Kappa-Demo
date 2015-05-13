using UnityEngine;
using System.Collections;
[RequireComponent (typeof (EntityComponent))]

public class ControllerComponent : MonoBehaviour
{
	public CombatManager cm;
	
	private EntityComponent entity;
	
	void Start ()
	{
		entity = this.GetComponent<EntityComponent>();
	}
	
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow))
		{
			cm.moveEntity(Direction.Up, entity);
		}
		else if (Input.GetKeyDown (KeyCode.DownArrow))
		{
			cm.moveEntity(Direction.Down, entity);
		}
		else if (Input.GetKeyDown (KeyCode.RightArrow))
		{
			cm.moveEntity(Direction.Right, entity);
		}
		else if (Input.GetKeyDown (KeyCode.LeftArrow))
		{
			cm.moveEntity(Direction.Left, entity);
		}

		if (Input.GetKeyDown (KeyCode.J))
		{
			Debug.Log("Entity #"+entity.ID+" has fired an attack");
			GetComponent<AudioSource>().Play();
			cm.attack(entity.basicAttackComponent, entity);
		}

	}
}

