using UnityEngine;
using System.Collections;

public class puzzle_manage : MonoBehaviour {

	public GameObject[] marble = new GameObject[6];
	

	public void change_marble(GameObject input_marble){
		if (input_marble == marble [0]) {
			GameObject.Find("marble_area_6").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_1").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_2").GetComponent<puzzle_state>().change_marble();
		}
		if (input_marble == marble [1]) {
			GameObject.Find("marble_area_1").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_2").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_3").GetComponent<puzzle_state>().change_marble();
		}
		if (input_marble == marble [2]) {
			GameObject.Find("marble_area_2").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_3").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_4").GetComponent<puzzle_state>().change_marble();
		}
		if (input_marble == marble [3]) {
			GameObject.Find("marble_area_3").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_4").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_5").GetComponent<puzzle_state>().change_marble();
		}
		if (input_marble == marble [4]) {
			GameObject.Find("marble_area_4").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_5").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_6").GetComponent<puzzle_state>().change_marble();
		}
		if (input_marble == marble [5]) {
			GameObject.Find("marble_area_5").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_6").GetComponent<puzzle_state>().change_marble();
			GameObject.Find("marble_area_1").GetComponent<puzzle_state>().change_marble();
		}

		if (GameObject.Find ("marble_area_1").GetComponent<puzzle_state> ().marble_num == 5 &&
			GameObject.Find ("marble_area_2").GetComponent<puzzle_state> ().marble_num == 4 &&
			GameObject.Find ("marble_area_3").GetComponent<puzzle_state> ().marble_num == 3 &&
			GameObject.Find ("marble_area_4").GetComponent<puzzle_state> ().marble_num == 2 &&
			GameObject.Find ("marble_area_5").GetComponent<puzzle_state> ().marble_num == 1 &&
			GameObject.Find ("marble_area_6").GetComponent<puzzle_state> ().marble_num == 0) {
			print ("clear");
		}
	}
}
