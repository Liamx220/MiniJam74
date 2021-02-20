using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destry_explosion : MonoBehaviour
{
    private void FixedUpdate()
    {
        Destroy(gameObject, 0.5f);
    }
}
