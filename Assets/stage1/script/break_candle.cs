using UnityEngine;
using System.Collections;

public class break_candle : MonoBehaviour {

	public GameObject this_item;
	public GameObject breaked_candle1;
	public GameObject breaked_candle2;
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseUpAsButton(){
		GameObject.Find ("item").GetComponent <manage_inven> ().pop_item(this_item);
		GameObject.Find ("item").GetComponent <manage_inven> ().push_item(breaked_candle1);
		GameObject.Find ("item").GetComponent <manage_inven> ().push_item(breaked_candle2);
	}

}
