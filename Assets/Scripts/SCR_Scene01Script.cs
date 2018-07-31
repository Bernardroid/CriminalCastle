using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SCR_Scene01Script : MonoBehaviour {

    SCR_ChatManager chatManager;
    public Sprite ravenPortrait;
    public Sprite wandaPortrait;
    int stage=0;
    bool canProceed=true;
    bool isInCoroutine = false;
    
	// Use this for initialization
	void Start () {
        chatManager = gameObject.GetComponent<SCR_ChatManager>();
	}
	
    //How do i even dialogue manage am tireddsafadfgsdg
	void Update () {
		if(Input.anyKeyDown&&canProceed)
        {
            stage++;
            canProceed = false;
            StartStory();
        }
       

    }
    void StartStory()
    {
        if (!isInCoroutine)
        {
            isInCoroutine = true;
            StartCoroutine(StartStory(stage));
        }
    }
    IEnumerator StartStory(int _stage)
    {
        switch(_stage)
        {
            case 1:
                {
                    chatManager.currentState = SCR_ChatManager.ChatState.AnimateToShow;
                    yield return new WaitUntil(() => chatManager.currentState == SCR_ChatManager.ChatState.Showing);
                    chatManager.SetDialogue("Wanda", "Soy la capitana Wanda líder de esta estación policiaca, para probar tu desempeño te llevare a una pequeña misión.", wandaPortrait);
                    chatManager.currentState = SCR_ChatManager.ChatState.AnimateText;
                    yield return new WaitUntil(() => chatManager.currentState == SCR_ChatManager.ChatState.WaitingInput);


                }
                break;
            case 2:
                {
                    chatManager.SetDialogue("Raven", "¿Misión?  Pero aun no estoy lo suficiente preparada.", ravenPortrait);
                    chatManager.currentState = SCR_ChatManager.ChatState.AnimateText;
                    yield return new WaitUntil(() => chatManager.currentState == SCR_ChatManager.ChatState.WaitingInput);

                }
                break;
            case 3:
                {
                    chatManager.SetDialogue("Wanda", "No te preocupes yo te iré guiando en la batalla y si algo sale mal puedo calcinar a los enemigos con un chasquido de mis dedos, así que... ¿Estas lista?", wandaPortrait);
                    chatManager.currentState = SCR_ChatManager.ChatState.AnimateText;
                    yield return new WaitUntil(() => chatManager.currentState == SCR_ChatManager.ChatState.WaitingInput);

                }
                break;
            case 4:
                {
                    chatManager.SetDialogue("Raven", "Si, vamos!", ravenPortrait);
                    chatManager.currentState = SCR_ChatManager.ChatState.AnimateText;
                    yield return new WaitUntil(() => chatManager.currentState == SCR_ChatManager.ChatState.WaitingInput);
                }
                break;
            case 5:
                {
                    chatManager.SetDialogue("Raven", "(Bien mientras mas rápido comience podré encontrar las pistas para encontrar a esa “persona”)", ravenPortrait);
                    chatManager.currentState = SCR_ChatManager.ChatState.AnimateText;
                    yield return new WaitUntil(() => chatManager.currentState == SCR_ChatManager.ChatState.WaitingInput);
                }
                break;
            case 6:
                {
                    SceneManager.LoadScene("REE");
                }
                break;
        }


        Debug.Log("Im out"); 
        canProceed = true;
        isInCoroutine = false;

    }
}
