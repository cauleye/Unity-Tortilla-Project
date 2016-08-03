using UnityEngine;
using System.Collections;

public class TortillaEatingSceneManager : MonoBehaviour {

	public int tortillaPartsEaten;
	public int tortillaPartsTotal;

	public LevelManager levelManager;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (tortillaPartsTotal == tortillaPartsEaten) {
			levelManager.LoadLevel("06 Eat Chips");
		}
	}
}
