using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_SelectUnit : MonoBehaviour {

    RaycastHit hitInfo;

    GameObject[] units;

    GameObject unitSelected;

	void Start ()
    {
        hitInfo = new RaycastHit();

        units = GameObject.FindGameObjectsWithTag("Unit");
	}
	
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo))
            {
                if (hitInfo.transform.CompareTag("Unit"))
                {
                    Debug.Log("Unit Selected!");
                    DeselectAllUnits();
                    hitInfo.transform.GetComponent<Renderer>().material.color = Color.blue;
                    hitInfo.transform.GetComponent<UnitStatus>().isSelected = true;
                    unitSelected = hitInfo.transform.gameObject;
                }
                else
                {
                    DeselectAllUnits();
                }
            }
            //In case they click outside the board
            else
            {
                DeselectAllUnits();
            }
        }
	}

    void DeselectAllUnits()
    {
        unitSelected = null;
        for(int i = 0; i < units.Length; i++)
        {
            units[i].GetComponent<UnitStatus>().isSelected = false;
            if (units[i].GetComponent<SCR_DragRoom>().b_piecePermaLocked)
            {
                units[i].GetComponent<Renderer>().material.color = Color.gray;
            }
            else
            {
                units[i].GetComponent<Renderer>().material.color = Color.white;
            }
        }
    }
}
