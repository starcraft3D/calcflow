﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBT_button : QuickButton
{

    protected override void ButtonEnterBehavior(GameObject other)
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    protected override void ButtonExitBehavior(GameObject other)
    {
        gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }
}