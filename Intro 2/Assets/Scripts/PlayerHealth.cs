using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.UI;
using JetBrains.Annotations;

public class PlayerHealth : MonoBehaviour
{
    public int _startHealth = 100;
    public int _current;

    public HealthBar healthBar;


    // Start is called before the first frame update
    void Start()
    {
        _current = _startHealth;
        healthBar.SetMaxHealth(_startHealth);
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

    }

    public void TakenDamage(int damage)
    {
        _current -= damage;

        healthBar.SetHealth(_current);
    }
}
