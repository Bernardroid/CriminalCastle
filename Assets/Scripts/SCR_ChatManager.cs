using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCR_ChatManager : MonoBehaviour {

    public enum ChatState
    {
        Hidden = 0,
        Showing,
        AnimateToShow,
        AnimateToHide,
        AnimateText,
        WaitingInput
    };

    [HideInInspector]
    public static float textSpeed = 0.05f;
    [HideInInspector]
    public static string charName="";
    [HideInInspector]
    public static string charChat="";
    bool isHidden = true;
    float dialogueShowHide = 0.5f;
    bool isTextShowing = false;
    bool isInCoroutine = false;

    public ChatState currentState;

    private Text uiName;
    private Text uiChat;
    private Image dialogueBox;
    public Image charImage;

    void Start()
    {
        uiName = GameObject.FindGameObjectWithTag("uiName").GetComponent<Text>();
        uiChat = GameObject.FindGameObjectWithTag("uiChat").GetComponent<Text>();
        dialogueBox = GameObject.FindGameObjectWithTag("uiBox").GetComponent<Image>();
        currentState = ChatState.Hidden;
    }

    // Update is called once per frame
    void Update () {

		switch(currentState)
        {
            case ChatState.Hidden:
                {
                    uiName.color = new Color(uiName.color.r, uiName.color.g, uiName.color.b, 0);
                    uiChat.color = new Color(uiChat.color.r, uiChat.color.g, uiChat.color.b, 0);
                    dialogueBox.color = new Color(dialogueBox.color.r, dialogueBox.color.g, dialogueBox.color.b, 0);
                    isHidden = true;
                }
                break;
            case ChatState.Showing:
                {
                    uiName.color = new Color(uiName.color.r, uiName.color.g, uiName.color.b, 1);
                    uiChat.color = new Color(uiChat.color.r, uiChat.color.g, uiChat.color.b, 1);
                    dialogueBox.color = new Color(dialogueBox.color.r, dialogueBox.color.g, dialogueBox.color.b, 1);
                    isHidden = false;
                }
                break;
            case ChatState.AnimateToShow:
                {
                    if(isInCoroutine==false)
                    {
                        isInCoroutine = true;
                        StartCoroutine(AnimateShowText(dialogueShowHide));                        
                    }
                }
                break;
            case ChatState.AnimateToHide:
                {
                    if (isInCoroutine == false)
                    {
                        isInCoroutine = true;
                        StartCoroutine(AnimateHideText(dialogueShowHide));
                    }
                }
                break;
            case ChatState.AnimateText:
                {
                    if(isInCoroutine==false)
                    {
                        isInCoroutine = true;
                        StartCoroutine(AnimateText(charName,charChat,textSpeed));
                    }

                }
                break;
            case ChatState.WaitingInput:
                {

                }
                break;
        }
        /*
        if(Input.GetKeyDown(KeyCode.Q))
        {
            currentState = ChatState.AnimateToShow;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            currentState = ChatState.AnimateToHide;

        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            if (!isInCoroutine)
            {

                charName = "Patrick";
            charChat = "Welcome to Bikini Bottom You Naughty Bitch.";
            currentState = ChatState.AnimateText;
            }

        }
        else if(Input.GetKeyDown(KeyCode.R))
        {
            if (!isInCoroutine)
            {
                charName = "Bob";
                charChat = "Whatcha mean?";
                currentState = ChatState.AnimateText;
            }
        }
        */
    }
    public void SetDialogue(string _charName, string _charDialogue, Sprite _charSprite)
    {
        charName = _charName;
        charChat = _charDialogue;
        charImage.sprite = _charSprite;
    }
    IEnumerator AnimateShowText(float _timeToShow)
    {
        float alpha = 0.0f;
        float time = 0.0f;

        while (time<_timeToShow)
        {
            time += Time.deltaTime;
            alpha = time*2;
            uiName.color = new Color(uiName.color.r, uiName.color.g, uiName.color.b, alpha);
            uiChat.color = new Color(uiChat.color.r, uiChat.color.g, uiChat.color.b, alpha);
            charImage.color = new Color(charImage.color.r, charImage.color.g, charImage.color.b, alpha);
            dialogueBox.color = new Color(dialogueBox.color.r, dialogueBox.color.g, dialogueBox.color.b, alpha);
            yield return new WaitForEndOfFrame();

        }

        isInCoroutine = false;
        currentState = ChatState.Showing;
    }
    IEnumerator AnimateHideText(float _timeToShow)
    {
        float alpha = 1.0f;
        float time = 0.0f;

        while (time < _timeToShow)
        {
            time += Time.deltaTime;
            alpha = time*2;
            uiName.color = new Color(uiName.color.r, uiName.color.g, uiName.color.b, 1-alpha);
            uiChat.color = new Color(uiChat.color.r, uiChat.color.g, uiChat.color.b, 1-alpha);
            dialogueBox.color = new Color(dialogueBox.color.r, dialogueBox.color.g, dialogueBox.color.b, 1-alpha);
            yield return new WaitForEndOfFrame();

        }

        isInCoroutine = false;
        currentState = ChatState.Hidden;
    }
    IEnumerator AnimateText(string  _charName,string _animText, float _durChar)
    {
        uiName.text = _charName;
        int letter =0;
        string animText= _animText;
        charChat = "";

        while (letter < animText.Length)
        {

            charChat += animText[letter];
            letter++;
            uiChat.text = charChat;
            yield return new WaitForSeconds(_durChar);
        }
        isInCoroutine = false;
        currentState = ChatState.WaitingInput;
    }

}
