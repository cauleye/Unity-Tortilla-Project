using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextManager : MonoBehaviour {

	//This script manages the three sets of text on the screen. Allowing to set each of their click effects differently

	//These variables are set in the inspector 
	public GameObject Text1;
	public GameObject Text2;
	public GameObject Text3; 

	public AudioSource audioSource;
	public AudioClip clickSound;

	// Use this for initialization
	void Start () {
		Text1.SetActive (true);
		Text2.SetActive (false);
		Text3.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void TextOneClick(){
		audioSource.PlayOneShot (clickSound);
		Text2.SetActive (true);
		Text1.SetActive (false);
	}

	public void TextTwoClick(){
		audioSource.PlayOneShot (clickSound);
		Text3.SetActive (true);
		Text2.SetActive (false);
	}

}
