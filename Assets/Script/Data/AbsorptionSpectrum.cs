using UnityEngine;
using System;
using System.Collections.Generic;

[Serializable]
public class AbsorptionSpectrum
{
    [field: SerializeField] public List<string> lines;
    [field: SerializeField] public List<string> bands;
    [field: SerializeField] public List<string> cutoff;
    [field: SerializeField] public string note;
}
