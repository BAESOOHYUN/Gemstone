using System;
using System.Collections.Generic;

[Serializable]
public class AbsorptionSpectrum
{
    public string color; //색상 특징이 따로 없을때 null 가능.
    public List<string> lines;
    public List<string> bands;
    public List<string> cutoff;
    public string note;
}