using System;
using UnityEngine;

[Serializable]
public class DialogueLine
{
    [Tooltip("Time (in seconds) when this line should appear.")]
    public float time;

    [Tooltip("Subtitle text for this time in the audio.")]
    [TextArea]
    public string text;
}
