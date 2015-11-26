using UnityEngine;
using System.Collections;

public class DDalKKak : MonoBehaviour {

	public AudioSource ddalkkak;

	void Update(){
		if (Input.GetKeyUp (KeyCode.Mouse0)) {
			ddalkkak.Play ();
		}
	}
}
