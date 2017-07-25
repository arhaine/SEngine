using UnityEngine;
using UnityEditor;

static class CreateCharacterComponentContainer
{
    [MenuItem("Assets/Create/CharacterComponentContainer")]
    public static void CreateYourScriptableObject()
    {
        ScriptableObjectUtility2.CreateAsset<CharacterComponentContainer>();
    }
}
