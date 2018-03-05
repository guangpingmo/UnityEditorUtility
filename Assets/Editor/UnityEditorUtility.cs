using UnityEngine;
using UnityEditor;

public static class UnityEditorUtility{
    #region menu extension.
    [MenuItem("Utility/Prefs/CleanPlayerPrefs")]
    public static void CleanPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }

    [MenuItem("Utility/Prefs/CleanEditorPrefs")]
    public static void CleanEditorPrefs()
    {
        EditorPrefs.DeleteAll();
    }
    #endregion
}
