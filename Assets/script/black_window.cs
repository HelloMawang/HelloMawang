using UnityEngine;
using System.Collections;

public class black_window : MonoBehaviour {

	public GameObject black;
	public void blackscreen(float waittime){
		StartCoroutine (blackout(waittime));
	}
	IEnumerator blackout(float waittime){

		black.SetActive(true);

		yield return new WaitForSeconds(waittime);

		black.SetActive(false);

	}
}
