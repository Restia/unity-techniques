using UnityEngine;
using System.Collections;

public class TestInterfaceCtrl : MonoBehaviour {

    // public IInterfaceContainer<ITestInterface>[] ObjList;
    public GameObject[] ObjList2;
    public IInterfaceIpml impl;
    // public MonoBehaviour[] ObjList3;

	// Use this for initialization
	void Start () {
        impl.GetInterface().TestFunc01();
        impl.GetInterface().TestFunc02();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
