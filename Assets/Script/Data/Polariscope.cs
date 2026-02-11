using System;
using System.Collections.Generic;

[Serializable]
public class Polariscope
{
    public List<string> type; //"SR", "DR", "AGG", "ADR", "없음" 등 
                              //"DR/ 종종 ADR"이라고 쓰인 경우 둘 다 리스트에 적음. ["DR", "ADR"]
                              //"DR/U+(U-, B+, B-)"로 쓰인 경우, "DR"만 적음.
    public string note; //"종종 ADR"을 여기에 씀. U+, U-, B+, B-도 여기에 씀.
}