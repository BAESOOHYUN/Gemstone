using System;
using System.Collections.Generic;

[Serializable]
public class AbsorptionSpectrum
{
    public List<string> lines;
    public List<string> bands;
    public List<string> cutoff;
    public string note;
}
