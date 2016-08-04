using UnityEngine;
using System.Collections;

public class MakeTortillaSceneManager : MonoBehaviour {

	public bool meatIn;
	public bool cheeseIn;
	public bool tomatoIn;
	public bool pepperIn;

	public LevelManager levelManager;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (meatIn && cheeseIn && tomatoIn && pepperIn) {
			TortillaMade ();
		}


	}


	public void TortillaMade(){
	
	
	}  
}
