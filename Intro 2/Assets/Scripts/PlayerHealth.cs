using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Text hp;
    [SerializeField] private float _startHealth = 100;
    [SerializeField] private float _current;
    public float dmg = 10f;

    // Start is called before the first frame update
    void Start()
    {
        _current = _startHealth;
    }

    // Update is called once per frame

    public void Death()
    {

        if (_current <= 0)
        {
            print("Ik ben dood");
        }
    }

    void Update()
    {
        hp.text = "Health: " + _current;

        void OnTriggerEnter(Collider col)
        {
            _current -= dmg;
        }
    }
}
