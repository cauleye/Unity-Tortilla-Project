using UnityEngine;
using System.Collections;

public class ChipSceneManager : MonoBehaviour {

	public int chipsEaten;
	public int totalChips;

	public LevelManager levelManager; 

	// Use this for initialization
	void Start () {
		chipsEaten = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//This calls the next scene when all the chips in the scene have been eaten. 
		if (chipsEaten == totalChips) {
			levelManager.LoadLevel ("07 Drink Coffee");
		}
	}
}
