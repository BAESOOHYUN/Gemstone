using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "GemDatabase", menuName = "Gem/Gem Database", order = 1)]
public class GemDatabase : ScriptableObject
{
    public List<GemData> gems;
}
