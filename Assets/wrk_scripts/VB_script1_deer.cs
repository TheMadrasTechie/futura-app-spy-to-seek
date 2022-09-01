using UnityEngine;
using System.Collections;
using Vuforia;
public class VB_script1_deer : MonoBehaviour,IVirtualButtonEventHandler {
private GameObject VBButtonObject;
	GameObject gm;
	void Start () {
	VBButtonObject = GameObject.Find("scle_deer");
	gm=GameObject.Find("Deer");
	VBButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
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
