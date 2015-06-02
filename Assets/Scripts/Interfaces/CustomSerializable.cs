using UnityEngine;
using System.Collections;

public interface ITestInterface
{
    void TestFunc01();
    void TestFunc02();
}

public class IInterfaceContainer<T> : MonoBehaviour
{
    private T m_CachedInterface;

    public T GetInterface()
    {
        // Cache the interface for performance
        if (m_CachedInterface == null)
        {
            T inter = (T)(gameObject.GetComponent(typeof(T)) as object);
            m_CachedInterface = inter;
        }
        return m_CachedInterface;
    }
}

public class IInterfaceIpml : IInterfaceContainer<ITestInterface>
{

}

public class CustomSerializable : IInterfaceIpml, ITestInterface
{
    public void TestFunc01()
    {
        Debug.Log("1");
    }

    public void TestFunc02()
    {
        Debug.Log("2");
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
