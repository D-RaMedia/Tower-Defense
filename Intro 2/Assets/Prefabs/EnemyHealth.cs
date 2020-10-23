using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : PathFollower
{
    [SerializeField] private float _startHealth = 3;

    private float _currentHealth;

    private void Start()
    {
        _currentHealth = _startHealth;
    }

    // Called from UnityEvent
    public void TakeDamage(float dmg = 1f)
    {
        _currentHealth -= dmg;
        print("Taking Damage!");

        if (_currentHealth <= 0)
        {
            print("I'm Dead");
        }

    }
}
