using UnityEngine;
using System.Collections;

public class EntityComponent : MonoBehaviour
{
	public float spacing = 1.0f;
	public float heightOffset = 1.0f;
	
	public int x = 2;
	public int y = 2;
	public Owner team;
	
	void Start ()
	{
	}
	
	void Update ()
	{
		this.transform.position = new Vector3 ((this.x - 1) * spacing, (this.y - 1) * spacing * 0.6f + heightOffset);
	}
}

