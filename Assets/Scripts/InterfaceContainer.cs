using UnityEngine;
using System.Collections;

public class InterfaceContainer<InterfaceName> : MonoBehaviour {

    private InterfaceName m_CachedInterface;

    public InterfaceName GetInterface()
    {
        if (m_CachedInterface == null)
        {
            InterfaceName temp = (InterfaceName)(gameObject.GetComponent(typeof(InterfaceName)) as object);
            m_CachedInterface = temp;
        }
        return m_CachedInterface;
    }
}