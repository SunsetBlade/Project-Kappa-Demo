﻿using UnityEngine;
using System.Collections;

public class CombatManager : MonoBehaviour
{
	public GameObject tilePrefab;
	public float spacing = 1.0f;
	public float heightOffset = 1.0f;
	
	private PanelComponent[,] panels;
	public ArrayList allEntities = new ArrayList();

	private int nextID = 1000;
	
	public void Initialize(int rows, int columns)
	{
		panels = new PanelComponent[columns, rows];
		
		for (int y = 0; y < rows; y++)
		{
			for (int x = 0; x < columns; x++)
			{
				panels[x,y] = (Instantiate(tilePrefab, new Vector3(x * spacing, y * spacing * 0.6f), Quaternion.identity) as GameObject).GetComponent<PanelComponent>();
			}
		}
		GetComponent<AudioSource>().Play();
	}

	public void registerEntity(EntityComponent e){
		e.ID = nextID;
		nextID += 1;
		allEntities.Add(e);
		Debug.Log ("Entity #"+e.ID+" has been registered with the CombatManager");
	}

	public void attack(AttackComponent a, EntityComponent entity){
		//applies the attack to all entities who did not fire it
		ArrayList toKill = new ArrayList();
		foreach (EntityComponent e in allEntities){
			if(!e.Equals(entity)){
				if(!e.takeDamage(a.damage)){
					Debug.Log("Entity was killed!");
					toKill.Add (e);
				}
			}
		}
		foreach (EntityComponent e in toKill){
			allEntities.Remove(e);
		}
	}

	public void moveEntity(Direction direction, EntityComponent entity)
	{
		int xOffset = 0;
		int yOffset = 0;
		
		if (direction == Direction.Up)
		{
			yOffset = 1;
		}
		else if (direction == Direction.Down)
		{
			yOffset = -1;
		}
		else if (direction == Direction.Right)
		{
			xOffset = 1;
		}
		else if (direction == Direction.Left)
		{
			xOffset = -1;
		}
		
		if (entity.x + xOffset > 0 && entity.x + xOffset <= 6 &&
		    entity.y + yOffset > 0 && entity.y + yOffset <= 3)
		{
			if (panels[entity.x + xOffset - 1, entity.y + yOffset - 1].owner == entity.team)
			{
				entity.x += xOffset;
				entity.y += yOffset;
			}
		}
	}
	
	void Start ()
	{
		Initialize(3, 6);
	}
	
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.F))
		{
			int rx = Random.Range(0, 6);
			int ry = Random.Range(0, 3);
			
			panels[rx, ry].swapOwner();
		}
		else if (Input.GetKeyDown (KeyCode.H))
		{
			int rows = 3;
			int columns = 6;
			
			for (int y = 0; y < rows; y++)
			{
				for (int x = 0; x < columns; x++)
				{
					if (x < 3)
					{
						panels[x,y].changeOwner(Owner.Red);
					}
					else
					{
						panels[x,y].changeOwner(Owner.Blue);
					}
				}
			}
		}
	}
}

