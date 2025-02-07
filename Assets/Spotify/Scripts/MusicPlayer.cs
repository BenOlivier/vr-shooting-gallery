using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;

    private bool isPlaying = false;

    public void UpdateCurrentSong(AudioClip song)
    {
        audioSource.clip = song;
        if (isPlaying) audioSource.Play();
    }

    [ContextMenu("Toggle")]
    public void TogglePlayPause()
    {
        if (!isPlaying)
        {
            audioSource.Play();
            isPlaying = true;
        }
        else
        {
            audioSource.Pause();
            isPlaying = false;
        }
    }

    public void UpdateVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
