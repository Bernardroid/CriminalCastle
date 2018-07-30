using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_UnitsUI : MonoBehaviour {

    public GameObject unitsMenu;
    public GameObject characterMenu;

    public void OnUnitClicked()
    {
        unitsMenu.SetActive(false);
        characterMenu.SetActive(true);
    }

    public void OnBackToUnitsClicked()
    {
        unitsMenu.SetActive(true);
        characterMenu.SetActive(false);
    }

}
