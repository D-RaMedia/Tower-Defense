using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCoroutine : MonoBehaviour
{
    // Start is called before the first frame update
    private MeshRenderer renderer;
    private bool spacePressed = false;
    void Start()
    {
        for(int i = 0; i < 500; i++)
        {
            Instantiate(GameObject.CreatePrimitive(PrimitiveType.Cube));
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Fade());
        }
    }

    IEnumerator Asdf()
    {
        for (int i = 0; i < 500; i++)
        {
            Instantiate(GameObject.CreatePrimitive(PrimitiveType.Cube));
        }
        yield return null;
    }

    IEnumerator Fade()
    {
        while (true)
        {
            Material mat = renderer.material;
            mat.color += new Color(0.2f, 0.2f, 0.2f);
            yield return null;
        }
    }

    void SayHellaNoCo()
    {
        Debug.Log("Hello World");
        Debug.Log("Hello World Again");
    }
}
