using UnityEngine;
using System.Collections;

public class Battlefield
{

	Panel[][] panels;

	public Battlefield(int x, int y){
		Start (x,y);
	}

	// Use this for initialization
	void Start (int x, int y) {
		panels = new Panel[x][y];
	}
}
