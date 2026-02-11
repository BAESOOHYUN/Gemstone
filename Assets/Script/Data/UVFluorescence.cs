using System;
using System.Collections.Generic;

[Serializable]
public class UVFluorescence 
{
    public LWFluorescence LW;
    public SWFluorescence SW;
}

[Serializable]
public class LWFluorescence
{
    public string color; // "Blue", "Orange", 색상 특징이 따로 없을때 null 가능. 
    public List<string> intensity; // "None", "Faint", "Medium", "Strong", "Very Strong" 순으로 반응 강해짐
                                   // "None~Strong"처럼 ~로 범위가 정해진 경우 "None", "Faint", "Medium", "Strong" 모두 쓸 것                               
                                   // 정보가 불분명할 시 "NOTKNOWN"
    public string note; 
}

[Serializable]
public class SWFluorescence
{
    public string color;
    public List<string> intensity;
    public string note;
}
