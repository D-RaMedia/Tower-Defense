using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTargetTower : Tower
{
    private Enemy _target;

    protected override bool CanAttack()
    {
        Enemy enemy = EnemyInRangeChecker.GetFirstEnemyInRange();
        if (enemy == null) return false;
        Targets.Add(enemy);
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
