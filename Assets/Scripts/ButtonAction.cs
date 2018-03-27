using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAction : MonoBehaviour {

	public void gotoScene(string scene) {
		SceneManager.LoadScene (scene);
	}
}
