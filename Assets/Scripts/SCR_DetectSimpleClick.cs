using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SCR_DetectSimpleClick : MonoBehaviour {


    public void OnClick()
    {
        Debug.Log("AM DETECTED");
    }

    public void OnCharactersClicked()
    {
        SceneManager.LoadScene("UnitsMenu");
    }

    public void OnBackClicked()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnMissionsClicked()
    {
        SceneManager.LoadScene("SCN_UITest0.1");
    }

}
