using UnityEngine;
using System.Collections;
[RequireComponent (typeof (EntityComponent))]

public class AiComponent : MonoBehaviour
{
	public CombatManager cm;
	
	private EntityComponent entity;
	
	void MoveRandom()
	{
		int value = Random.Range(0, 4);
		
		if (value == 0)
		{
			cm.moveEntity(Direction.Up, entity);
		}
		else if (value == 1)
		{
			cm.moveEntity(Direction.Down, entity);
		}
		else if (value == 2)
		{
			cm.moveEntity(Direction.Right, entity);
		}
		else if (value == 3)
		{
			cm.moveEntity(Direction.Left, entity);
		}
	}
	
	void Start ()
	{
		entity = this.GetComponent<EntityComponent>();
		
		InvokeRepeating("MoveRandom", 2.0f, 2.0f);
	}
	
	void Update ()
	{
	}
}

