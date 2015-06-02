using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    SendMessage("Damage", 3.0f);
        SendMessage("TakeDamage", 30.0f);
        // SendMessage("Swing");    // This does not call the Swing method of child object Sword
        BroadcastMessage("Swing"); // But this one does.

        // Send message "MustHear" to all MonoBehaviors and its children.
        BroadcastMessage("MustHear");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
