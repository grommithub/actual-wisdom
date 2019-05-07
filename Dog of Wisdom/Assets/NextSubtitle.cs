using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NextSubtitle : MonoBehaviour
{
    public List<string> subtitles = new List<string>();
    private AudioSource audio;
    public List<AudioClip> audioclips = new List<AudioClip>();
    public TMP_Text box;

    public int subtitleIndex;
    public int audioindex;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
        box.text = subtitles[subtitleIndex];
    }
    public void PlayAudio()
    {
        audioindex++;
        audio.PlayOneShot(audioclips[audioindex]);
    }
    public void OnlyChangeTextBox()
    {
        subtitleIndex++;
        box.text = subtitles[subtitleIndex];
        
    }
    public void Both()
    {
        OnlyChangeTextBox();
        PlayAudio();

    }
}
