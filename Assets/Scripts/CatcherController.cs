using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatcherController : MonoBehaviour {

	private CatcherDisplay catcherDisplay;
	private int totalEgg = 0;

	void Start() {
		catcherDisplay = GetComponent<CatcherDisplay> ();
	}

	void OnTriggerEnter2D(Collider2D hit) {
		if (hit.tag == "Egg") {
			totalEgg++;
			catcherDisplay.OnChangeEggTotal (totalEgg);
		}
	}

	void OnTriggerExit2D(Collider2D hit) {
		if (hit.tag == "Egg") {
			totalEgg--;
			catcherDisplay.OnChangeEggTotal (totalEgg);
		}
	}
}
