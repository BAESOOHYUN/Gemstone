using System;
using System.Collections.Generic;

[Serializable]
public class Polariscope
{
    public List<string> type; //"SR", "DR", "AGG", "ADR", "없음" 등 
                              //"DR/ 종종 ADR"이라고 쓰인 경우 둘 다 리스트에 적음. ["DR", "ADR"]
                              // DR인 경우 (U+, U-, B+, B-) 추가
    public string note; //"투명도에 따라 다름" 같은 내용
}