using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public interface IKineticListView
{
    void AddItem(IKLVItemCtn item);
    void RemoveItem(IKLVItemCtn item);
    void Refresh();
    void SetEnable(bool val);
}

public class IKineticListViewCtn : InterfaceContainer<IKineticListView>
{

}

public class KineticListView : IKineticListViewCtn, IKineticListView
{
    // Item container & item list
    public GameObject Container;
    private LinkedList<IKLVItemCtn> m_Items;

    bool m_Visible = true;

    public void AddItem(IKLVItemCtn item)
    {
        m_Items.AddLast(item);
        // Item's parent is container
        item.gameObject.transform.parent = Container.transform;
        // Re-position item.
    }

    public void RemoveItem(IKLVItemCtn item)
    {
        m_Items.Remove(item);
    }

    public void Refresh()
    {

    }

    public void SetEnable(bool val)
    {
        m_Visible = val;
        if (m_Visible)
            gameObject.SetActive(true);
        else gameObject.SetActive(false);
    }

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
