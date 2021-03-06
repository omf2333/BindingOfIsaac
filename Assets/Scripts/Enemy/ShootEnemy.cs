﻿using UnityEngine;
using System;
public class ShootEnemy:Enemy
{
    public GameObject bulletPrefab;

    protected override void Attack()
    {
        if (coolDownAttack)
            return;
        GameObject normalBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity) as GameObject;
        normalBullet.GetComponent<BulletController>().bulletType = BulletType.Normal;
        normalBullet.GetComponent<BulletController>().GetPlayer(player.transform);
        normalBullet.AddComponent<Rigidbody2D>().gravityScale = 0;
        normalBullet.GetComponent<BulletController>().isEnemyBullet = true;
        StartCoroutine(CoolDown());
    }

    protected override void Death()
    {
        base.Death();
    }
}
