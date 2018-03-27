using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatcherDisplay : MonoBehaviour {

	public Image[] eggPlaceholders;
	public Sprite iconEggFilled;
	public Sprite iconEggEmpty;
	public Text eggTotalText;
	public Button nextButton;

	public void OnChangeEggTotal(int total) {
		for(int i = 0; i < eggPlaceholders.Length; i++) {
			if (i < total) {
				eggPlaceholders [i].sprite = iconEggFilled;
			} else {
				eggPlaceholders [i].sprite = iconEggEmpty;
			}
		}

		eggTotalText.text = "Egg Collected : " + total;

		if (total >= eggPlaceholders.Length) {
			nextButton.gameObject.SetActive (true);
		} else {
			nextButton.gameObject.SetActive (false);
		}
	}
}
