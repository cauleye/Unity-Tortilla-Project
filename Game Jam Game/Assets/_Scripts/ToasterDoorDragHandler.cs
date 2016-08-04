using UnityEngine;
using System.Collections;

public class ToasterDoorDragHandler : MonoBehaviour {

	public GameObject draggedObject; 
	public MouseMoveController hand; //This is to have acess to the hand's variables to check them

	public float moveSpeed = 1f;

	public float xOffSet;
	public float yOffSet;

	public float topLimit = 0f;
	public float bottomLimit = -6.6f;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D other){
		if (other.transform.name == "Hand") {
			if (hand.handGrabbing == true) {
				//This keeps the x position of the new vector the same by setting the new x position to the old x position
				//The Clamp function marks the upper and lower bounds of how far the toaster door can be dragged
				other.transform.position = new Vector3 (draggedObject.transform.position.x + xOffSet, Mathf.Clamp(other.transform.position.y + yOffSet, bottomLimit, topLimit), other.transform.position.z);

				draggedObject.transform.position = Vector2.Lerp (transform.position, other.transform.position, moveSpeed);
			}
		}
	}

}
