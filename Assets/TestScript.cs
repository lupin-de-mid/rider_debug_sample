using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update start");
        Foo();
        Debug.Log("Update end");
    }

    void Foo()
    {
        Debug.Log("Foo start");
        Bar();
        Debug.Log("Foo end");
    }

    void Bar()
    {
        Debug.Log("Bar");
    }
}
