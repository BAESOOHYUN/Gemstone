using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GemData
{
    [field: SerializeField] public int id;
    [field: SerializeField] public string korean_name;
    [field: SerializeField] public string english_name;
    [field: SerializeField] public string category;
    [field: SerializeField] public string group;

    [field: SerializeField] public List<string> crystal_system;
    [field: SerializeField] public List<string> color;
    [field: SerializeField] public List<string> transparency;
    [field: SerializeField] public string transparency_note;
    [field: SerializeField] public List<string> lustre;
    [field: SerializeField] public List<string> special_effects;

    [field: SerializeField] public RefractiveIndex refractive_index;
    [field: SerializeField] public List<RefractiveIndexSubtype> ri_subtypes;
    [field: SerializeField] public Birefringence birefringence;

    [field: SerializeField] public string polariscope;
    [field: SerializeField] public string polariscope_note;
    [field: SerializeField] public string pleochroism;
    [field: SerializeField] public List<string> inclusions;

    [field: SerializeField] public AbsorptionSpectrum absorption_spectrum;
    [field: SerializeField] public UVFluorescence uv_fluorescence;

    [field: SerializeField] public SpecificGravity specific_gravity;
    [field: SerializeField] public List<string> cleavage_fracture;

    [field: SerializeField] public Hardness hardness;

    [field: SerializeField] public bool is_synthetic;
    [field: SerializeField] public bool is_treated;
    [field: SerializeField] public List<string> treatment_types;

    [field: SerializeField, TextArea(3, 5)] public string comment;
}
