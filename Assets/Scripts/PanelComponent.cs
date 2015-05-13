using UnityEngine;
using System.Collections;
[RequireComponent (typeof (SpriteRenderer))]

public class PanelComponent : MonoBehaviour
{
	public Sprite red;
	public Sprite blue;
	public Sprite gray;
	
	private Owner _owner;
	private TileState _state;
	private SpriteRenderer image;
	
	void Start ()
	{
		this.owner = Owner.Red;
		this.state = TileState.Normal;
		this.image = this.GetComponent<SpriteRenderer>();
	}
	
	void Update ()
	{
		// do something
	}
	
	public void swapOwner()
	{
		if (_owner == Owner.Red)
		{
			_owner = Owner.Blue;
			image.sprite = blue;
		}
		else if (_owner == Owner.Blue)
		{
			_owner = Owner.Red;
			image.sprite = red;
		}
	}
	
	public void changeOwner(Owner newOwner)
	{
		_owner = newOwner;
		
		if (_owner == Owner.Red)
		{
			image.sprite = red;
		}
		else if (_owner == Owner.Blue)
		{
			image.sprite = blue;
		}
		else if (_owner == Owner.Neutral)
		{
			image.sprite = gray;
		}
	}
	
	public Owner owner
	{
		get { return _owner; }
		set { _owner = value; }
	}
	
	public TileState state
	{
		get { return _state; }
		set { _state = value; }
	}
}

