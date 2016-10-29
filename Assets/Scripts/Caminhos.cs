using UnityEngine;
using System;
using System.Collections;

public class Caminhos : MonoBehaviour {

	private Node n;
	public float carHeight;
	public int mapSize;
	public int blockSize;

	private int[][] mapa ;

	private static int SROADX = 1; 
	private static int SROADZ = 2;




	// Use this for initialization
	void Start () {
		initializeMap ();
		//mapa = new int[][] { new int[mapSize]{}, new int[]{}};
		fillMap ();
	//	Debug.Log ("Tamanho "+mapa.GetLength(0)+" "+mapa.GetLength(1));

	
	}

	void initializeMap(){
		mapa =  new int[(mapSize*2)+1][] ;
		for (int i = 0; i <= mapSize*2; i++) {
			mapa [i] = new int[(mapSize*2)+1];
		}
	}



	void fillMap(){

		for (int i = 0; i < transform.childCount; i++) {
			Transform child = transform.GetChild (i);
			if (child.tag == "sroadX" || child.tag == "sroadZ")
			{
				int scale = 1;
				int posX = (int)Math.Round(child.position.x);
				int posZ = (int)Math.Round(child.position.z);

				posX += 50;
				posZ += 50;
				scale = scale * 5;

				posX = posX / scale;
				posZ = posZ / scale;


				if (child.tag == "sroadX") {
					mapa [posX] [posZ] = SROADX;
					Debug.Log ("Road x added: "+posX+ " "+posZ);

				} else {
					mapa [posX] [posZ] = SROADZ;
					Debug.Log ("Road z added: "+posX+ " "+posZ);
				}

				
			}

		}
	}


	// Update is called once per frame
	void Update () {
	
	}
}
