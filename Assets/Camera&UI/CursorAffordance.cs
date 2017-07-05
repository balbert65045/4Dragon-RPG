using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorAffordance : MonoBehaviour {

    // Use this for initialization
	[SerializeField] Texture2D walkCursor = null;
	[SerializeField] Texture2D AttackCursor = null;
	[SerializeField] Texture2D UnkownCursor = null;
	[SerializeField] Vector2 cursorHotspot = new Vector2 (96, 96);

    CameraRaycaster CameraRaycaster; 

    void Start () {
        CameraRaycaster = GetComponent<CameraRaycaster>();
	}
	
	// Update is called once per frame
	void Update () {
		switch (CameraRaycaster.layerHit)
		{case Layer.Walkable:
			Cursor.SetCursor (walkCursor, cursorHotspot, CursorMode.Auto);
			break;
		case Layer.Enemy:
			Cursor.SetCursor (AttackCursor, cursorHotspot, CursorMode.Auto);
			break;
		case Layer.RaycastEndStop:
			Cursor.SetCursor (UnkownCursor, cursorHotspot, CursorMode.Auto);
			break;
		default:
			Debug.LogError ("Dont Know what cursor to show");
			return;
		}
        //Debug.Log(CameraRaycaster.layerHit);
	}
}
