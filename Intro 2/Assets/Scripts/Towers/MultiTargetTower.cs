using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiTargetTower : Tower
{
    private Enemy _target;
    protected override bool CanAttack()
    {
        Enemy[] enemies = EnemyInRangeChecker.GetallEnemiesInRange();
        if (enemies.Length <= 0) return false;
        foreach (var e in enemies) Targets.Add(e);
        return true;
    }
    protected override void Attack()
    {
        foreach (var target in Targets)
        {
            target.enemyHealth.GiveDamage(damage);
        }
        Targets.Clear();
    }
}
