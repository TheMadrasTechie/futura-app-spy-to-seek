using UnityEngine;
using System.Collections;
using Vuforia;
public class VB_script1_dog : MonoBehaviour,IVirtualButtonEventHandler {
private GameObject VBButtonObject;
	GameObject gm;
	void Start () {
	VBButtonObject = GameObject.Find("scle_dog");
	gm=GameObject.Find("dog");
	//
	}
		public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){
			Debug.Log("scale_img.pressed");
			gm.gameObject.transform.localScale+=new Vector3(2f,2f,2f);
			
		}
		public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
			Debug.Log("scale_img.not pressed");
			//gm.gameObject.transform.Rotate(Vector3.right,3);
			
		}
}
