using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour {

    public Camera UICamera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosW = UICamera.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit hittedObj;
            bool hitted = Physics.Raycast(mousePosW, Vector3.forward, out hittedObj, 100.0f);
            if (hitted)
            {
                hittedObj.collider.gameObject.SendMessage("OnPressed");
            }
            else Debug.Log("coming through");
        }
	}
}
