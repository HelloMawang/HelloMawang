using UnityEngine;
using System.Collections;

public class axe_to_chicken : MonoBehaviour {

	public GameObject chicken;
	public GameObject chicken_blood;

	bool onlyone = false;
	// Update is called once per frame
	void Update () {
		Vector3 lp = chicken.transform.position;
		float dis = Vector3.Distance (transform.position, lp);
		
		
		if (dis < 2f && chicken.activeSelf) {

			if(Input.GetKeyDown(KeyCode.Mouse0)){

				StartCoroutine("slash");




			}
		}
	
	}
	IEnumerator slash(){

		if (!onlyone) {
			GameObject.Find ("EventSystem").GetComponent <sound_play> ().play_sound (); 
			onlyone = true;
		
		}
		
		GameObject.Find ("EventSystem").GetComponent<black_window> ().blackscreen (6.0f);
		Destroy (chicken);
		GameObject.Find ("item").GetComponent <manage_inven> ().push_item(chicken_blood);
		GameObject.Find ("item").GetComponent <manage_inven> ().pop_item(this.gameObject);

		
		GameObject.Find ("blank").GetComponent<inven> ().dragitem = false ;


		yield return null;
	}
}
