using UnityEngine;
using System.Collections;

public class puzzle_state : MonoBehaviour {
	

	public GameObject[] marble = new GameObject[6];
	public int marble_num;
	private int i;
	// 0 : purple, 1 : green, 2 : red, 3 : blue, 4 : orange, 5 : yellow
	void Start(){
		i = marble_num;
		for(int j=0;j<10;j++)
		marble [i].SetActive (true);

	}
	public void change_marble(){
		marble [marble_num].SetActive (false);
		if (marble_num != 5) {
			marble_num++;
		} else {
			marble_num=0;
		}
		marble [marble_num].SetActive (true);

	}
}
