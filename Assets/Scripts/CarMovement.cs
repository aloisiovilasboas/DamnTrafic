using UnityEngine;
using System.Collections;


public class CarMovement : MonoBehaviour {



//
//	private Vector3 target;
//	private Rigidbody rb;
//	private Vector3 direction;
//	private Node path;
//	public int speed;
//	public float carHeight;
//
//
//	Node arrayListToPath(ArrayList ar){
//
//		Node n = null;
//		if (ar.Count > 0) {
//			n = (Node)ar[0];
//			ar.RemoveAt(0);
//			n.setNeighbors (ar);
//			n = arrayListToPathHelper(n);
//		} 
//		return n;
//	}
//
//	Node arrayListToPathHelper(Node first){
//		
//		if (first != null) {
//			if (first.getNeighbors().Count > 0 ) {
//				Node second = (Node)first.getNeighbors() [0];
//				first.getNeighbors ().RemoveAt(0);
//				second.setNeighbors (first.getNeighbors ());
//
//				second = arrayListToPathHelper(second);
//
//				ArrayList l = new ArrayList ();
//
//				l.Add (second);
//				first.setNeighbors (l);
//			}
//		}
//		return first;
//	}
//	
//
//
//	Node setPathTeste(){
//
//		Vector3 posinit = new Vector3(10,carHeight,0);
//
//		ArrayList proximos = new ArrayList();
//		Node n4 = new Node (new Vector3 (100, carHeight, 0));
//		Node n3 = new Node (new Vector3 (0, carHeight, 0));
//		Node n2 = new Node (new Vector3 (0, carHeight, 10));
//		Node n1 = new Node (new Vector3 (10, carHeight, 10));
//
//		ArrayList n4prox = new ArrayList ();
//		n4.setNeighbors (n4prox);
//
//		ArrayList n3prox = new ArrayList ();
//		n3prox.Add (n4);
//		n3.setNeighbors (n3prox);
//
//		ArrayList n2prox = new ArrayList ();
//		n2prox.Add (n3);
//		n2.setNeighbors (n2prox);
//
//		ArrayList n1prox = new ArrayList ();
//		n1prox.Add (n2);
//		n1.setNeighbors (n1prox);
//
//		ArrayList raizProx = new ArrayList ();
//		raizProx.Add (n1);
//		Node raiz = new Node (posinit, raizProx);
//
//		return raiz;
//	}
//
//
//	Node setPathTeste2(){
//
//
////		Node n4 = new Node (new Vector3 (100, carHeight, 0));
////		Node n3 = new Node (new Vector3 (0, carHeight, 0));
////		Node n2 = new Node (new Vector3 (0, carHeight, 10));
////		Node n1 = new Node (new Vector3 (10, carHeight, 10));
////		Node n0 = new Node (new Vector3(10, carHeight,0));
////
////		ArrayList nos = new ArrayList ();
////
////		nos.Add (n0);
////		nos.Add (n1);
////		nos.Add (n2);
////		nos.Add (n3);
////		nos.Add (n4);
////
////		Node prox = arrayListToPath (nos);
////
////
////		return prox;
//	}
//
//
//	// Use this for initialization
//	void Start() {
//		
//		path = setPathTeste2();
//		rb = GetComponent<Rigidbody>();
//		direction = path.getPosition ();
//	}
//
//	void FixedUpdate() {
//
//		float step = speed * Time.deltaTime;
//		transform.position = Vector3.MoveTowards(transform.position, direction, step);
//		direction = findDirections ();
//	}
//
//	Vector3 findDirections(){
//
//		int pathLength = path.getNeighbors ().Count;
//		Debug.Log (pathLength);
//
//		if (transform.position.x == path.getPosition().x && transform.position.z == path.getPosition().z){
//			if(pathLength>0){
//				path = (Node)path.getNeighbors()[0];
//			}
//		}
//
//
//
//		return path.getPosition();
//	}
//
//
//
//
//	public class Node
//	{
//		private ArrayList neighbors;
//		private Vector3 position;
//
//		public void setNeighbors(ArrayList neighbors){
//			this.neighbors =neighbors;
//		}
//		public ArrayList getNeighbors(){
//			return this.neighbors ;
//		}
//		public void setPosition(Vector3 position){
//			this.position =position;
//		}
//		public Vector3 getPosition(){
//			return this.position ;
//		}
//
//
//		public Node(Vector3 position){
//			this.position =position;
//			neighbors = new ArrayList();
//		}
//			
//		public Node(Vector3 position, ArrayList neighbors){
//			this.position = position;
//			this.neighbors = neighbors;
//
//		}
//			
//	}

}
