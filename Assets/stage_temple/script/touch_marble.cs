using UnityEngine;
using System.Collections;

public class touch_marble : MonoBehaviour {


	void OnMouseUpAsButton(){
		GameObject.Find ("temple-fountain_zoomin").GetComponent<puzzle_manage> ().change_marble (this.gameObject);
	}
}
