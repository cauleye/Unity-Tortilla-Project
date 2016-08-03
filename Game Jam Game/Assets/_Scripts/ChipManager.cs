using UnityEngine;
using System.Collections;

public class ChipManager : MonoBehaviour {

	public ChipSceneManager chipSceneManager;
	public AudioSource audioSource;
	public AudioClip crunch;

	public SpriteRenderer selfRenderer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D (Collider2D other){
		if (other.transform.name == "Hand") {
			//Checks to see if player let up on a right click
			if (Input.GetMouseButtonUp(0)){
				EatChip ();
			}
		}
	}

	public void EatChip(){
		chipSceneManager.chipsEaten += 1;
		audioSource.PlayOneShot (crunch);
		selfRenderer.enabled = false;
	}
}
