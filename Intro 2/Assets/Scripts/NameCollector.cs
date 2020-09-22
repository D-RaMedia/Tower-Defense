using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameCollector : MonoBehaviour
{
    private GameObject anObjectIWantTheNameOf;
    private NameHolder objectNameHolder;
    private string objectAlternativeName;
    // Start is called before the first frame update
    void Start()
    {
        anObjectIWantTheNameOf = GameObject.Find("MyGameObjectONe");
        Debug.Log("Ik heb het volgende object gevonden " + anObjectIWantTheNameOf);

        anObjectIWantTheNameOf.GetComponent<NameHolder>();
        //objectAlternativeName = objectNameHolder.Foo();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
