using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;

[InitializeOnLoad]
public class BootLoaderEditor
{
    static BootLoaderEditor()
    {
        EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
    }

    private static void OnPlayModeStateChanged(PlayModeStateChange state)
    {
        if (state == PlayModeStateChange.ExitingEditMode)
        {
            string currentScenePath = SceneManager.GetActiveScene().path;
            PlayerPrefs.SetString("OriginalScenePath", currentScenePath);
            string bootScenePath = "Assets/Scenes/Boot.unity";
            SceneAsset bootScene = AssetDatabase.LoadAssetAtPath<SceneAsset>(bootScenePath);
            if (bootScene != null)
            {
                EditorSceneManager.playModeStartScene = bootScene;
            }
        }
    }
}

