using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MusicLooper : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioClip musicClip;
    [SerializeField] private AudioClip musicClipLoop;

    private void Awake()
    {
        musicSource.clip = musicClip;
        musicSource.loop = false;
        musicSource.Play();
    }
    private void Update()
    {
        if(!musicSource.isPlaying)
        {
            musicSource.clip = musicClipLoop;
            musicSource.loop = true;
            musicSource.Play();
            Destroy(this);
        }
    }
}
