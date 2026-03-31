using UnityEngine;
using System.Collections.Generic;

public class AudioPlayer : MonoBehaviour
{
    public List<AudioClip> audioClips = new List<AudioClip>();
    public int selectedIndex = 0;

    public void PlaySelected()
    {
        if (selectedIndex >= 0 && selectedIndex < audioClips.Count)
        {
            AudioManager.instance.play(audioClips[selectedIndex]);
        }
    }

    public void Stop()
    {
        AudioManager.instance.stop();
    }

    public void Pause()
    {
        AudioManager.instance.pause();
    }

    public void Resume()
    {
        AudioManager.instance.resume();
    }
}
