using UnityEngine;
using UnityEngine.SceneManagement;

public static class BootLoader
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    static void OnRuntimeStart()
    {
        string originalPath = PlayerPrefs.GetString("OriginalScenePath");
        if (!string.IsNullOrEmpty(originalPath))
        {
            SceneManager.LoadScene(originalPath, LoadSceneMode.Additive);
            Scene originalScene = SceneManager.GetSceneByPath(originalPath);
            SceneManager.SetActiveScene(originalScene);
            SceneManager.UnloadSceneAsync("Boot");
        }
    }
}
