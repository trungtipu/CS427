﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityHelper : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<PlayerController>().enabled = false;
    }
}
