using UnityEngine;
using System.Collections;

public class book_touch : MonoBehaviour {

	public GameObject book_magnified;



	void OnMouseUpAsButton(){

		book_magnified.SetActive (true);

	}
	void Update(){
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			book_magnified.SetActive(false);
		}
	}
}
