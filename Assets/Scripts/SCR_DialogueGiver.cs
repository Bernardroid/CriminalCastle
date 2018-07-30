using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_DialogueGiver : MonoBehaviour {


    public void GiveDialogue(string _chat, string _name)
    {
        SCR_ChatManager.charChat = _chat;
        SCR_ChatManager.charName = _name;
    }

}
