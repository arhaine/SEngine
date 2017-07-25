using UnityEngine;
using UnityEditor;

static class CreateCharacterPreset
{
    [MenuItem("Assets/Create/BaseCharacterPreset")]
    public static void CreateYourScriptableObject()
    {
        ScriptableObjectUtility2.CreateAsset<BaseCharacterPreset>();
    }

}