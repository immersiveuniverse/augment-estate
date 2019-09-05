using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

	public GameObject hInt, hOut, panelHelp, tv;

	void Start(){
		hInt.SetActive (false);
		hOut.SetActive (false);
		tv.SetActive (false);	
	}

	public void SetInteriorActive(){
		hInt.SetActive (true);
		hOut.SetActive (false);
		tv.SetActive (false);
	}

	public void SetOutsideActive(){
		hInt.SetActive (false);
		tv.SetActive (false);
		hOut.SetActive (true);
	}

	public void OnClickBtnHelp(){

		if (panelHelp.activeSelf==true) {
			panelHelp.SetActive (false);
		}else if (panelHelp.activeSelf==false) {
			panelHelp.SetActive (true);
		}
	}

	public void OnCLickBtnInfo(){
		if (tv.activeSelf==true) {
			tv.SetActive (false);
		}else if (tv.activeSelf==false) {
			hOut.SetActive (false);
			hInt.SetActive (false);
			tv.SetActive (true);

		}
	}
}
