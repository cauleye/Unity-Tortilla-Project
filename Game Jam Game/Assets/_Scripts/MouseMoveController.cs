using UnityEngine;
using System.Collections;

public class MouseMoveController : MonoBehaviour {

	public GameObject hand;

	public SpriteRenderer spriteRenderer;
	public Sprite openHand;
	public Sprite closedHand;

	public bool handGrabbing;
	public bool handFull;

	private Vector3 mousePosition;
	public float moveSpeed = 0.1f;

	public float yOffSet = 0;
	public float xOffSet = 0;

	// Use this for initialization
	void Start () {
		spriteRenderer.sprite = openHand;
		handGrabbing = false;
		handFull = false;
	}
	
	// Update is called once per frame
	void Update () {

		// This gets the position of the mouse, turns it into a readable world position relative to the camera, and then sets that as the transform of the hand
		mousePosition = Input.mousePosition;
		mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);

		//These apply the offsets to the target transform in cases where you don't want the mouse to be in the direct middle of the sprite
		mousePosition.y += yOffSet;
		mousePosition.x += xOffSet;

		hand.transform.position = Vector2.Lerp (transform.position, mousePosition, moveSpeed); // Lerp moves the gameobject from it's transform to the target transform

		if (Input.GetMouseButton (0)) {
			spriteRenderer.sprite = closedHand; 
			handGrabbing = true;
		} else {
			spriteRenderer.sprite = openHand; 
			handGrabbing = false;
			handFull = false;
		}
	}
}
