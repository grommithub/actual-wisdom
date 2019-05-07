using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NextSubtitle : MonoBehaviour
{
    public List<string> subtitles = new List<string>();
    public TMP_Text box;

    public int subtitleIndex;

    private void Start()
    {
        box.text = subtitles[subtitleIndex];
    }
    public void ChangeBox()
    {
        subtitleIndex++;
        box.text = subtitles[subtitleIndex];
    }
}
