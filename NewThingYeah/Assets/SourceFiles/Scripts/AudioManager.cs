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
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
