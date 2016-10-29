﻿using UnityEngine;
using System.Collections;

public class Node {

	private ArrayList neighbors;
	private Vector3 position;

	public void setNeighbors(ArrayList neighbors){
		this.neighbors =neighbors;
	}
	public ArrayList getNeighbors(){
		return this.neighbors ;
	}
	public void setPosition(Vector3 position){
		this.position =position;
	}
	public Vector3 getPosition(){
		return this.position ;
	}


	public Node(Vector3 position){
		this.position =position;
		neighbors = new ArrayList();
	}

	public Node(Vector3 position, ArrayList neighbors){
		this.position = position;
		this.neighbors = neighbors;

	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}