using UnityEngine;
using System.Collections;

public class Damageable : MonoBehaviour {

    private void TakeDamage(float damage)
    {
        Debug.Log("take " + damage + " damage");
    }

    private void MustHear()
    {
        Debug.Log("damageable");
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
