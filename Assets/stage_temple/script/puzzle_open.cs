using UnityEngine;
using System.Collections;

public class puzzle_open : MonoBehaviour {


	public GameObject fountine_puzzle;

	void OnMouseUpAsButton(){
		
		fountine_puzzle.SetActive (true);
		
	}
}
