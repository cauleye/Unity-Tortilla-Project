using UnityEngine;
using System.Collections;

public class DragHandler : MonoBehaviour {

	public GameObject draggedObject; 
	public MouseMoveController hand; //This is to have acess to the hand's variables to check them

	public float moveSpeed = 1f;

	public float xOffSet;
	public float yOffSet;

	public float bottomLimitY;
	public float topLimitY;
	public float bottomLimitX;
	public float topLimitX;

	public bool beingHeld;
	public bool pickUpPlayed;

	public AudioSource audioSource;
	public AudioClip pickUp; //Clip plays on pick up
	public AudioClip putDown; //Clip plays on putting down

	// Use this for initialization
	void Start () {
		beingHeld = false;
		pickUpPlayed = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D other){
		if (other.transform.name == "Hand") {
			if (hand.handGrabbing == true && (hand.handFull == false || beingHeld == true)) {

				//Checks to see if pickup sound has played. If it hasn't it plays it, then sets pickUpPlayed to true
				if (pickUpPlayed == false) {
					audioSource.PlayOneShot (pickUp);
					pickUpPlayed = true;
				}

				//The Clamp function prevents the objects from being dragged off screen 
				other.transform.position = new Vector3 (Mathf.Clamp(other.transform.position.x + xOffSet, bottomLimitX, topLimitX), Mathf.Clamp(other.transform.position.y + yOffSet, bottomLimitY, topLimitY), other.transform.position.z);

				//Changes position of the dragged object using a Lerp function 
				draggedObject.transform.position = Vector2.Lerp (transform.position, other.transform.position, moveSpeed);
				hand.handFull = true;
				beingHeld = true;
			}
		}
	}

	void OnTriggerExit2D (Collider2D other){
		if (other.transform.name == "Hand") {
			if (pickUpPlayed == true){
				audioSource.PlayOneShot (putDown);
				beingHeld = false;
				pickUpPlayed = false; //Resets bool controlling if sound has played
			}
		}
	}

}
