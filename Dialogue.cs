using System.Collections.Generic;
using UnityEngine;

namespace YourNamespace
{
    [CreateAssetMenu(menuName = "NPC Dialogues/Dialogue")]
    public class Dialogue : ScriptableObject
    {
        [Header("Dialogue Settings")]
        [SerializeField] private int dialogueId;
        [SerializeField] private AudioClip voiceLine;

        [Header("Simple Text (Optional)")]
        [TextArea]
        [SerializeField] private string dialogueText;

        [Header("Timed Lines (for subtitles, etc.)")]
        [SerializeField] private List<DialogueLine> timedLines;

        public int DialogueId => dialogueId;
        public AudioClip VoiceLine => voiceLine;
        public string DialogueText => dialogueText;
        public List<DialogueLine> TimedLines => timedLines;
    }
}