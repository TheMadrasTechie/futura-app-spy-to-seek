using UnityEngine;
using System.Collections;
using Vuforia;
public class VB_script : MonoBehaviour,IVirtualButtonEventHandler {
private GameObject VBButtonObject;
	GameObject gm;
	void Start () {
	VBButtonObject = GameObject.Find("rotate");
	gm=GameObject.Find("dino");
	VBButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}
		public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){
			Debug.Log("rotate.pressed");
			gm.gameObject.transform.Rotate(Vector3.up*10);
		}
		public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
			Debug.Log("rotate.not pressed");
			
		}
}
