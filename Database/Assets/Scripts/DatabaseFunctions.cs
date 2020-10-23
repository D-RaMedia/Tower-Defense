using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine(DataBaseAddRequest());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DataBaseAddRequest()
    {
        WWW request = new WWW("hers.hosts1.ma-cloud.nl/create.php?name=Silvan&score=932");
        yield return request;
        print(request.text);
        Debug.Log(request.text);
    }
}
