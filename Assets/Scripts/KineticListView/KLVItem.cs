using UnityEngine;
using System.Collections;

public interface IKLVItem
{
    int GetIndex();
}

public class IKLVItemCtn : InterfaceContainer<IKLVItem>
{

}

public class KLVItem : IKLVItemCtn, IKLVItem 
{
    int m_Index;

    public int GetIndex()
    {
        return m_Index;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
