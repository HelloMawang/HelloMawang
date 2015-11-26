using UnityEngine;
using System.Collections;

public class branch_to_lamp : MonoBehaviour {
	
	public GameObject branch;
	public GameObject breaked_lamp;
	public GameObject after_burn;
	public GameObject candle_area;
	public AudioSource break_sound;
	public AudioSource fire_start;
	public AudioSource fire_continue;
	void Update(){

		Vector3 lp = branch.transform.position;
		float dis = Vector3.Distance (transform.position, lp);


		if (dis < 0.5f) {
			if(Input.GetKeyUp(KeyCode.Mouse0)){

				candle_area.SetActive(true);

				GameObject.Find ("item").GetComponent <manage_inven> ().pop_item (branch);
				
				GameObject.Find ("blank").GetComponent<inven> ().dragitem = false ;
				StartCoroutine("fire");
			}
		}

	}

	public IEnumerator fire(){
		
		yield return new WaitForSeconds (0.1f);
		gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y-1f,gameObject.transform.position.z);
		yield return new WaitForSeconds (0.1f);
		gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y-1f,gameObject.transform.position.z);
		yield return new WaitForSeconds (0.1f);
		gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y-1f,gameObject.transform.position.z);
		yield return new WaitForSeconds (0.1f);
		gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y-1f,gameObject.transform.position.z);
		yield return new WaitForSeconds (0.1f);
		gameObject.transform.position = new Vector3(gameObject.transform.position.x,20f,gameObject.transform.position.z);


		breaked_lamp.SetActive(true);
		break_sound.Play();
		
		yield return new WaitForSeconds(1f);
		fire_start.Play ();
		GameObject.Find ("EventSystem").GetComponent<black_window> ().blackscreen (3f);
		yield return new WaitForSeconds(1f);
		fire_continue.Play();

		after_burn.SetActive (true);

	}
}
