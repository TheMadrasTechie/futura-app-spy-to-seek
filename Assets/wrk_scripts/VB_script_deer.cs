using UnityEngine;
using System.Collections;
using Vuforia;
public class VB_script_deer : MonoBehaviour,IVirtualButtonEventHandler {
private GameObject VBButtonObject;
	GameObject gm;
	void Start () {
	VBButtonObject = GameObject.Find("rotate_deer");
	gm=GameObject.Find("Deer");
	VBButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}
		public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){
			Debug.Log("rotate.pressed");
			gm.gameObject.transform.Rotate(Vector3.left*10);
		}
		public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
			Debug.Log("rotate.not pressed");
			
		}
}
