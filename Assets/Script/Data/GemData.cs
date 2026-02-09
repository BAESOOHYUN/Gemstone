using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GemData
{
    public int id;
    public string korean_name;
    public string english_name;
    public string category;
    public string group;

    public List<string> crystal_system;
    public List<string> color;
    public Transparency transparency;
    public List<string> lustre;
    public List<string> special_effects;

    public RefractiveIndex refractive_index;
    public List<RefractiveIndexSubtype> ri_subtypes;
    public Birefringence birefringence;

    public Polariscope polariscope;
    public string pleochroism;
    public List<string> inclusions;

    public AbsorptionSpectrum absorption_spectrum;
    public UVFluorescence uv_fluorescence;

    public SpecificGravity specific_gravity;
    public List<string> cleavage_fracture;

    public Hardness hardness;

    public bool is_synthetic;
    public bool is_treated;
    public List<string> treatment_types;

    [TextArea(3, 5)] public string comment;
}
