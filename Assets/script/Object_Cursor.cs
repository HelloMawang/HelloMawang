using UnityEngine;
using System.Collections;

public class Object_Cursor : MonoBehaviour {

	public GameObject cursor_hand;

	IEnumerator OnMouseEnter(){

		Vector3 scrSpace = Camera.main.WorldToScreenPoint (cursor_hand.transform.position);
		//Vector3 offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y, scrSpace.z));


		Cursor.visible = false;
		
		cursor_hand.SetActive (true);
		while (true) {
			Vector3 curScreenSpace = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, scrSpace.z);
			Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenSpace) ;
			cursor_hand.transform.position = curPosition;
			yield return null;
		}


	}
	void OnMouseExit() {
		Cursor.visible = true;
		cursor_hand.SetActive (false);

	}

}
