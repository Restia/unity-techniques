using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {

    public int HUDId;

    void OnPressed()
    {
        Debug.Log("Mouse pressed at HUD id = " + HUDId);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    }
}
