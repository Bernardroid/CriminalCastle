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
                    chatManager.SetDialogue("????", "Raven, tenemos un problema en Santa Monica Norte. Hay reportes de actividad sospechosa. Reune a tu equipo investiga. Tienen 5 minutos para partir.", wandaPortrait);
                    chatManager.currentState = SCR_ChatManager.ChatState.AnimateText;
                    yield return new WaitUntil(() => chatManager.currentState == SCR_ChatManager.ChatState.WaitingInput);


                }
                break;
            case 2:
                {
                    chatManager.SetDialogue("Raven", "Wanda por lo menos dime que se espera de mi equipo.", ravenPortrait);
                    chatManager.currentState = SCR_ChatManager.ChatState.AnimateText;
                    yield return new WaitUntil(() => chatManager.currentState == SCR_ChatManager.ChatState.WaitingInput);

                }
                break;
            case 3:
                {
                    chatManager.SetDialogue("Wanda", "Raven puede ser relacionado con la muerte de tu madre. Porfavor no pierdas mas el tiempo.", wandaPortrait);
                    chatManager.currentState = SCR_ChatManager.ChatState.AnimateText;
                    yield return new WaitUntil(() => chatManager.currentState == SCR_ChatManager.ChatState.WaitingInput);

                }
                break;
            case 4:
                {
                    chatManager.SetDialogue("Raven", "... Okay.", ravenPortrait);
                    chatManager.currentState = SCR_ChatManager.ChatState.AnimateText;
                    yield return new WaitUntil(() => chatManager.currentState == SCR_ChatManager.ChatState.WaitingInput);
                }
                break;
            case 5:
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
