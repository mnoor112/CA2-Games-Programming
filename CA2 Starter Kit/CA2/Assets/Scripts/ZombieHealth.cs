﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : HealthComponent
{
    public GameObject splatter;
    public GameManager manager;


     void Start()
    {
        manager =  GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();

    }

    public override void KillCharacter()
    {
        
        manager.RecordZombieDeath();
        Instantiate(splatter);
        base.KillCharacter();
    }
}
