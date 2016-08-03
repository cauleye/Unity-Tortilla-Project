using UnityEngine;
using System.Collections;

public class DragHandler : MonoBehaviour {

	public GameObject draggedObject; 
	public MouseMoveController hand; //This is to have acess to the hand's variables to check them

	//public Transform targetTransform;

	public float moveSpeed = 1f;

	public float xOffSet;
	public float yOffSet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//void OnTriggerEnter2D(Collider2D other) {
	//	if (other.transform.name == "Hand") {
	//		if (hand.holding == true) {
	//			draggedObject.transform.position = other.transform.position;
	//			//draggedObject.transform.position = Vector2.Lerp (transform.position, other.transform.position, moveSpeed);
	//		}
	//	}
	//}

	void OnTriggerStay2D(Collider2D other){
		if (other.transform.name == "Hand") {
			if (hand.holding == true) {
				Debug.Log ("True");
			}
			if (hand.holding == false) {
				Debug.Log ("False");
			}
			if (hand.holding == true) {
				

				other.transform.position = new Vector3 (other.transform.position.x + xOffSet, other.transform.position.y + yOffSet, other.transform.position.z);
				draggedObject.transform.position = Vector2.Lerp (transform.position, other.transform.position, moveSpeed);
			}
		}
	}

}
