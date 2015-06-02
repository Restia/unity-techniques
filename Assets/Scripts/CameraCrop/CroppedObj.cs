using UnityEngine;
using System.Collections;

public class CroppedObj : MonoBehaviour {

    public Color FillColor;

	// Use this for initialization
	void Start () {
        renderer.material.renderQueue = 3002;
        renderer.material.SetColor("_Color", FillColor);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
