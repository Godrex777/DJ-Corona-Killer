﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    #region Singleton

     public static PlayerManager instace;

     void Awake()
     {
        instace = this;
     }
    #endregion

    public GameObject player;
}
