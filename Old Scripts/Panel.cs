using UnityEngine;
using System.Collections;
using EnumScript;

public class Panel
{

	private TileState state;
	private Owner owner;

	public Panel(Owner o){
		Start (o);
	}

	// Use this for initialization
	void Start (Owner o)
	{
		this.owner = o;
		this.state = TileState.Normal;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//make sure the sprite component is looking in the right place

	}

	void setState(TileState s){
		this.state = s;
	}

	TileState getState(){
		return this.state;
	}

	void setOwner(Owner o){
		this.owner = o;
	}

	Owner getOwner(){
		return this.owner;
	}

}

