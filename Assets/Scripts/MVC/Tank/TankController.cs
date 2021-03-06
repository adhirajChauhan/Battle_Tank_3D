﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{
    public TankController (TankModel tankModel , TankView tankPrefab)
    {
        TankModel = tankModel;
        TankView = GameObject.Instantiate<TankView>(tankPrefab);
        Debug.Log("tank view created");
    }

    public TankModel TankModel { get; }
    public TankView TankView { get; }
}


