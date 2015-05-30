using UnityEngine;
using System.Collections;

public class Button_Controller : MonoBehaviour {

    public Button CustomButton;
    public IButton m_iCustomButton;

    void Awake()
    {
        m_iCustomButton = (IButton)(CustomButton.GetComponent(typeof(IButton)) as object);
        m_iCustomButton.SetText("TestBtn");
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
