using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : Health
{
    public GameObject healthBar;
    public override void GiveDamage(float amount)
    {
        base.GiveDamage(amount);
        Debug.Log("Animate");
        healthBar.GetComponent<Animator>().Play("DMGAnim");
        healthBar.GetComponent<Animator>().Play("DMGAnim", -1, 0);
        if (health <= 0) Destroy(this.gameObject);
    }
}
