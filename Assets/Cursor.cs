using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour {

    // Use this for initialization
    CameraRaycaster CameraRaycaster;
    void Start () {
        CameraRaycaster = GetComponent<CameraRaycaster>();
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(CameraRaycaster.layerHit);
	}
}
