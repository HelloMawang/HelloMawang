using UnityEngine;
using System.Collections;

public class sound_play : MonoBehaviour {

	public AudioSource sound_source;

	public void play_sound(){

		sound_source.Play ();
	}
	public void play_sound_this(AudioSource this_sound){
		this_sound.Play ();
	}
}
