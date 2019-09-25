﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value = 0;
    public int maxValue = 2;
    
    public void UpdateToMaxValue()
    {
        value = maxValue;
    }

    // Update is called once per frame
    public void UpdateToNumber(int number)
    {
        value = number;
    }
}
