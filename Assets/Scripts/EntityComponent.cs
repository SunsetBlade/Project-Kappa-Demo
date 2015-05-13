using UnityEngine;
using System.Collections;

public class EntityComponent : MonoBehaviour
{
	public float spacing = 1.0f;
	public float heightOffset = 1.0f;
	
	public int x = 2;
	public int y = 2;
	public Owner team;

	public int ID = 0;

	public int maxHP = 10;
	public int curHP = 10;

	public AttackComponent basicAttackComponent;
	public Direction facingDirection = Direction.Right;

	public CombatManager cM;

	void Start ()
	{
		basicAttackComponent = new AttackComponent();
		basicAttackComponent.damage = 10;
		cM = GameObject.Find("CombatManager").GetComponent<CombatManager>();
		cM.registerEntity(this);
	}

	void Update ()
	{
		this.transform.position = new Vector3 ((this.x - 1) * spacing, (this.y - 1) * spacing * 0.6f + heightOffset);
	}

	public bool takeDamage(int dmg){
		Debug.Log(ID+" taking damage");
		curHP -= dmg;
		if(curHP <= 0){
			Debug.Log("Entity #"+ID+" has died");
			return false;
		}else{
			return true;
		}
	}
}

