using UnityEngine;
using System;
using System.Collections;

public class Caminhos : MonoBehaviour {

	private Node n;
	public float carHeight;
	public int mapSize;

	private int[][] mapa ;

	private static int SROADX  = 1; 
	private static int SROADZ = 2;




	// Use this for initialization
	void Start () {
		initializeMap ();
		//mapa = new int[][] { new int[mapSize]{}, new int[]{}};
		fillMap ();
		Debug.Log ("Tamanho "+mapa.GetLength(0)+" "+mapa.GetLength(1));

	
	}

	void initializeMap(){
		mapa =  new int[mapSize][] ;
		for (int i = 0; i < mapSize; i++) {
			mapa [i] = new int[mapSize];
		}
	}



	void fillMap(){

		foreach (Transform child in transform)
		{
			if (child.tag == "sroadX" )
			{
				int posX = (int)Math.Round(child.position.x);
				int posZ = (int)Math.Round(child.position.z);

				mapa[posX][posZ] = SROADX;
				
			}
			if (child.tag == "sroadZ" )
			{
				int posX = (int)Math.Round(child.position.x);
				int posZ = (int)Math.Round(child.position.z);

				mapa[posX][posZ] = SROADZ;

			}
		}
	}


	// Update is called once per frame
	void Update () {
	
	}
}
