using UnityEngine;
using System.Collections;

public class touch_to_sound : MonoBehaviour {

	public AudioSource AS;
	public void sound_play(){
		GameObject.Find ("EventSystem").GetComponent<sound_play> ().play_sound_this (AS);
	}
}
