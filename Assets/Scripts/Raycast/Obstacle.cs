using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

    public int Id;

    void OnPressed()
    {
        Debug.Log("OnPressed " + Id);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
