using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AudioPlayer))]
public class AudioPlayerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        AudioPlayer player = (AudioPlayer)target;

        if (Application.isPlaying)
        {
            if (GUILayout.Button("Play Selected"))
            {
                player.PlaySelected();
            }

            if (GUILayout.Button("Stop"))
            {
                player.Stop();
            }

            if (GUILayout.Button("Pause"))
            {
                player.Pause();
            }

            if (GUILayout.Button("Resume"))
            {
                player.Resume();
            }
        }
    }
}
