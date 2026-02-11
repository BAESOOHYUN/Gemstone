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

    public string crystal_system;
    public List<string> color;
    public Transparency transparency;
    public List<string> lustre;
    public List<string> special_effects;

    public List<RefractiveIndex> refractive_indexs;
    public Birefringence birefringence;

    public Polariscope polariscope;
    public Pleochroism pleochroism;
    public List<string> inclusions; // 조건이 나뉘어 있을 경우 최대한 모든 내포물 특징을 요약하여 다 적기.

    public List<AbsorptionSpectrum> absorption_spectrums;
    public List<UVFluorescence> uv_fluorescences; // "무반응" 일때 null처리

    public SpecificGravity specific_gravity;
    public List<string> cleavage;
    public string fracture;

    public Hardness hardness;

    public bool is_synthetic;
    public bool is_treated;
    public List<string> treatment_types;

    [TextArea(3, 5)] public string comment;
}
