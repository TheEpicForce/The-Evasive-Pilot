﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunController : MonoBehaviour {

    public bool isFiring;

    public EnemyBulletController bullet;

    public float bulletSpeed;

    public float timeBetweenshots;

    private float shotCounter;

    public Transform firePoint;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (isFiring)
        {

                EnemyBulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as EnemyBulletController;

                newBullet.enemyBulletspeed = bulletSpeed;

        }
    }
}