using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCR_DialogueUI : MonoBehaviour {

    public Sprite pauseSprite;
    public Sprite playSprite;
    private bool b_onPlay;

    public void OnPlayClicked(Image _img)
    {
        b_onPlay = !b_onPlay;
        if(b_onPlay)
        {
            _img.sprite = pauseSprite;
        }
        else
        {
            _img.sprite = playSprite;
        }
    }

}
