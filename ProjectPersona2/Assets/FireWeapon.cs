using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : MonoBehaviour
{
    [SerializeField] float timeToAttack;
    float timer;

    PlayerController playerController;

    [SerializeField] GameObject firePrefab;

    private void Awake()
    {
        playerController = GetComponentInParent<PlayerController>();
    }

    private void Update()
    {
        if (timer < timeToAttack)
        {
            timer = +Time.deltaTime;
            return;
        }

        timer = 0;
        SpawnFire();
    }

    private void SpawnFire()
    {
        GameObject fireball = Instantiate(firePrefab);
        fireball.transform.position = transform.position;
    }
}
