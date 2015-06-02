using UnityEngine;
using System.Collections;

public class Attackable : MonoBehaviour {

    private void Damage(float damage)
    {
        Debug.Log("deal " + damage + " damage");
    }

    private void MustHear()
    {
        Debug.Log("attackable");
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
