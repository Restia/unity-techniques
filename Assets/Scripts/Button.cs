using UnityEngine;
using System.Collections;

public interface IButton
{
    void SetEnable(bool val);
    void SetEventListener(Button.EventListener eventListener);
    void SetText(string text);
    void SetSize(float width, float height);
}

[ExecuteInEditMode]
public class Button : MonoBehaviour, IButton {
    // Child GameObjects
    public GameObject TextObject;

    // Component caches
    private BoxCollider2D m_BoxCollider2D;

    // Events
    public delegate void EventListener();
    private EventListener m_EventListener;

    // Button enable
    public bool m_Enable = true;

    // Button size
    public float Width;
    public float Height;

    //--------------------------------------------------------------
    public void SetEnable(bool val)
    {
        m_Enable = val;
    }

    public void SetEventListener(EventListener eventListener)
    {
        m_EventListener = eventListener;
    }

    public void SetText(string text)
    {
        TextObject.GetComponent<TextMesh>().text = text;
    }

    public void SetSize(float width, float height)
    {
        Width = width;
        Height = height;
        // Collider size
        m_BoxCollider2D.size = new Vector2(Width, Height);
    }
    //--------------------------------------------------------------

    void OnMouseDown()
    {
        if (!m_Enable) return;
        Debug.Log("down");
    }

    void OnMouseUp()
    {
        if (!m_Enable) return;
        Debug.Log("up");
    }

    void OnMouseUpAsButton()
    {
        if (!m_Enable) return;

        Debug.Log("button");
        if (m_EventListener != null)
            m_EventListener();
    }


    // Cache all necessary components
    void Awake()
    {
        m_BoxCollider2D = GetComponent<BoxCollider2D>();
    }

	// Use this for initialization
	void Start () {
        SetSize(Width, Height);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
