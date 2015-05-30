using UnityEngine;
using System.Collections;

public class RaycastObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosW = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hittedObj = Physics2D.Raycast(mousePosW, Vector2.zero, 100.0f);
            if (hittedObj.collider != null)
            {
                hittedObj.collider.gameObject.SendMessage("OnPressed");
            }
            else Debug.Log("coming through");
        }
	}
}
