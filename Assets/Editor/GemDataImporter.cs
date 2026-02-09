using UnityEngine;
using UnityEditor;
using System.IO;

public class GemDataImporter : EditorWindow
{
    private string jsonPath = "";
    private GemDatabase targetDatabase;

    [MenuItem("Tools/Gem Data/Import JSON")]
    public static void ShowWindow()
    {
        GetWindow<GemDataImporter>("Gem Data Importer");
    }

    void OnGUI()
    {
        GUILayout.Label("보석 JSON 데이터를 ScriptableObject로 변환", EditorStyles.boldLabel);

        jsonPath = EditorGUILayout.TextField("JSON 파일 경로", jsonPath);
        if (GUILayout.Button("파일 선택"))
            jsonPath = EditorUtility.OpenFilePanel("JSON 선택", "Assets", "json");

        targetDatabase = (GemDatabase)EditorGUILayout.ObjectField("대상 Database", targetDatabase, typeof(GemDatabase), false);

        if (GUILayout.Button("JSON → ScriptableObject 변환"))
        {
            ImportGemData();
        }
    }

    void ImportGemData()
    {
        if (string.IsNullOrEmpty(jsonPath) || targetDatabase == null)
        {
            Debug.LogError("JSON 경로와 대상 Database를 모두 선택하세요");
            return;
        }

        string jsonText = File.ReadAllText(jsonPath);
        GemDatabaseWrapper wrapper = JsonUtility.FromJson<GemDatabaseWrapper>(jsonText);

        if (wrapper?.gems == null)
        {
            Debug.LogError("올바른 JSON 형식이 아닙니다!");
            return;
        }

        // 기존 데이터 클리어
        targetDatabase.gems.Clear();

        // JSON 데이터 → ScriptableObject 변환
        foreach (var jsonGem in wrapper.gems)
        {
            GemData gemData = new GemData
            {
                id = jsonGem.id,
                korean_name = jsonGem.korean_name,
                english_name = jsonGem.english_name,
                category = jsonGem.category,
                group = jsonGem.group,
                crystal_system = jsonGem.crystal_system,
                color = jsonGem.color,
                transparency = jsonGem.transparency,
                transparency_note = jsonGem.transparency_note,
                lustre = jsonGem.lustre,
                special_effects = jsonGem.special_effects,

                refractive_index = jsonGem.refractive_index,
                ri_subtypes = jsonGem.ri_subtypes,
                birefringence = jsonGem.birefringence,

                polariscope = jsonGem.polariscope,
                polariscope_note = jsonGem.polariscope_note,
                pleochroism = jsonGem.pleochroism,
                inclusions = jsonGem.inclusions,

                absorption_spectrum = jsonGem.absorption_spectrum,
                uv_fluorescence = jsonGem.uv_fluorescence,

                specific_gravity = jsonGem.specific_gravity,
                cleavage_fracture = jsonGem.cleavage_fracture,
                hardness = jsonGem.hardness,

                is_synthetic = jsonGem.is_synthetic,
                is_treated = jsonGem.is_treated,
                treatment_types = jsonGem.treatment_types,
                comment = jsonGem.comment
            };

            targetDatabase.gems.Add(gemData);
        }

        EditorUtility.SetDirty(targetDatabase);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

        Debug.Log($"{targetDatabase.gems.Count}개 보석 데이터 임포트 완료");
    }
}

// JSON 래퍼 클래스 (최상위 gems 배열 처리)
[System.Serializable]
public class GemDatabaseWrapper
{
    public GemData[] gems;
}
