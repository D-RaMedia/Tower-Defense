using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public AudioSource Damage;
    public ParticleSystem Explosion;

    // Start is called before the first frame update
    void Start()
    {
        Damage = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Gate")
        {
            Damage.Play();
            Explode();
            Destroy(collision.gameObject);
            Debug.Log("hit");
        }
    }

    void Explode()
    {
        Instantiate(Explosion);
        Explosion.Play();
    }
}
