using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Dialogue/New Dialogue")]

public class DialogueText : ScriptableObject
{
    // Start is called before the first frame update
    // public string speakerName;

    [TextArea(5,10)]
    public string [] paragraphs;
   
}