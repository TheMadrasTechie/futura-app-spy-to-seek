using UnityEngine;
using System.Collections;
using Vuforia;
public class VB_script1 : MonoBehaviour,IVirtualButtonEventHandler {
private GameObject VBButtonObject;
	GameObject gm;
	void Start () {
	VBButtonObject = GameObject.Find("scale_img");
	gm=GameObject.Find("dino");
	VBButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}
		public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){
			//Debug.Log("scale_img.pressed");
			gm.gameObject.transform.localScale+=new Vector3(0.1f,0.1f,0.1f);
			
		}
		public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
			Debug.Log("scale_img.not pressed");
			//gm.gameObject.transform.Rotate(Vector3.right,3);
			
		}
}
