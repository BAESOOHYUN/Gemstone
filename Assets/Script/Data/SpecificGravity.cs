using UnityEngine;
using System;

[Serializable]
public class SpecificGravity
{
    [field: SerializeField] public float value;
    [field: SerializeField] public float tolerance_min;
    [field: SerializeField] public float tolerance_max;
}
