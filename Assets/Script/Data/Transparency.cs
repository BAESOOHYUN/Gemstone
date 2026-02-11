using System;
using System.Collections.Generic;

[Serializable]
public class Transparency
{
    public List<string> type; //"TP", "STP", "TL", "STL", "O" 순으로 불투명해짐.
                              //"TP~O"처럼 ~로 범위가 정해진 경우 "TP", "STP", "TL", "STL", "O" 모두 쓸 것
    public string note;
}
