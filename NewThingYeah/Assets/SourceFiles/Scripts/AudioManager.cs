using UnityEngine;
using System.Collections.Generic;
public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    private AudioSource systemsource;
    private List<AudioSource> activeSources;

    #region awake
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            systemsource = GetComponent<AudioSource>();
            activeSources = new List<AudioSource>();
        }
        else{
            Destroy(gameObject);
        }
    }
    #endregion awake
    
    
    #region audioplayback

    public void play(AudioClip clip)
    {
        systemsource.Stop();
        systemsource.clip = clip;
        systemsource.Play();
    }

    public void playoneshot(AudioClip clip)
    {
        systemsource.PlayOneShot(clip);
    }

    public void stop()
    {
        systemsource.Stop();
    }

    public void pause()
    {
        systemsource.Pause();
    }

    public void resume()
    {
        systemsource.UnPause();
    }
        
        
    #endregion audioplayback
        
        #region audio3d
        
        public void play(AudioClip clip, AudioSource source)
        {
            if (!activeSources.Contains(source))
            {
                activeSources.Add(source);
            }
            systemsource.Stop();
            systemsource.clip = clip;
            systemsource.Play();
        }

       

        public void stop(AudioSource source)
        {
            if (activeSources.Contains(source))
            {
                activeSources.Remove(source);
            }
            source.Stop();
        }

        public void pause(AudioSource source)
        {
            source.Pause();
        }

        public void resume(AudioSource source)
        {
            source.UnPause();
        }
        public void playoneshot(AudioClip clip, AudioSource source)
        {
            source.PlayOneShot(clip);
        }
        #endregion audio3d
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
