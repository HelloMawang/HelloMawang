using UnityEngine;
using System.Collections;

public class fire_candle : MonoBehaviour {

	public GameObject nofired_candle;
	public GameObject fired_candle;

	void Update(){
		
		Vector3 lp = nofired_candle.transform.position;
		float dis = Vector3.Distance (transform.position, lp);
		
		
		if (dis < 0.5f) {
			if(Input.GetKeyUp(KeyCode.Mouse0)){
				Destroy(nofired_candle);
				fired_candle.SetActive(true);
				
				GameObject.Find ("item").GetComponent <manage_inven> ().pop_item (this.gameObject);
				
				GameObject.Find ("item").GetComponent <manage_inven> ().push_item (this.gameObject);


				GameObject.Find ("blank").GetComponent<inven> ().dragitem = false ;
			}
		}
		
	}

}
