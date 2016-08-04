using UnityEngine;
using System.Collections;

public class ChopManager : MonoBehaviour {

	public SpriteRenderer spriteRenderer;

	public Sprite whole;
	public Sprite chopped;

	public bool chopping;

	public AudioSource audioSource;
	public AudioClip chopSound;

	// Use this for initialization
	void Start () {
		spriteRenderer.sprite = whole; 
		chopping = false; 
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			chopping = true;
		} else {
			chopping = false;
		}
	}

	void OnTriggerStay2D(Collider2D other){
		if (Input.GetKeyDown ("space")) {
			if (other.transform.name == "Knife") {
				Chop ();
			}
		}
	}


	public void Chop (){
		audioSource.PlayOneShot (chopSound);
		spriteRenderer.sprite = chopped; 
	}
}
