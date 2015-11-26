using UnityEngine;
using System.Collections;

public class inven : MonoBehaviour {
	public GameObject invenob;

	public bool dragitem;
	void Start(){
		invenob.SetActive (false);
		dragitem = false;
	}
	/*
	void OnMouseEnter(){
		invenob.SetActive (true);
	}
	void OnMouseExit(){
		invenob.SetActive (false);
	}
	*/

	void Awake(){
		
		dragitem = false;
	}
	void Update(){

		Vector3 scrSpace = Camera.main.WorldToScreenPoint (transform.position);

		Vector3 curScreenSpace = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, scrSpace.z);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenSpace) ;

		Vector3 mousepos = curPosition;
		if(mousepos.x > -9f && mousepos.x <-2f && mousepos.y>5f && mousepos.y <7f){
			invenob.SetActive(true);
		}
		else if(dragitem == false){	

			invenob.SetActive(false);
		}
	}
}
