using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DialogueBox : MonoBehaviour
{

    [SerializeField]
    int dialogueIndex
        = 0;
    [SerializeField] TextMeshProUGUI SpeakerText;
    [SerializeField] TextMeshProUGUI YappingText;
    [TextArea]
    [SerializeField] List<string> dialogue;
    void Start()
    {
        dialogueIndex = 0;
        YappingText.text = dialogue[dialogueIndex];
    }


    public void NextDialogue()
    {
        dialogueIndex += 1;
        if (dialogueIndex >= dialogue.Count)
        {
            dialogueIndex = 0;
            YappingText.text = dialogue[dialogueIndex];
        }
        else
        {
            YappingText.text = dialogue[dialogueIndex];
        }
    }
}