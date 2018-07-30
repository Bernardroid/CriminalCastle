using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_DragRoom : MonoBehaviour {

    RaycastHit hitInfo;
    public LayerMask floorMask;

    Color highlightColor;
    Color startingColor;

    Renderer renderer;

    bool b_dragLocked;

    public bool b_piecePermaLocked;

    private void Start()
    {
        b_piecePermaLocked = false;

        renderer = GetComponent<Renderer>();
        startingColor = renderer.material.color;
        highlightColor = Color.yellow;

        hitInfo = new RaycastHit();
    }

    private void OnMouseEnter()
    {
        if (GetComponent<UnitStatus>().isSelected)
            return;

        if (b_piecePermaLocked)
        {
            renderer.material.color = Color.gray;
        }
        else
        {
            renderer.material.color = highlightColor;
        }
    }

    private void OnMouseExit()
    {
        if (GetComponent<UnitStatus>().isSelected)
            return;

        if (GetComponent<SCR_DragRoom>().b_piecePermaLocked)
        {
            renderer.material.color = Color.gray;
        }
        else
        {
            renderer.material.color = startingColor;
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            b_piecePermaLocked = false;
        }
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, floorMask))
            {
                if ((hitInfo.transform.CompareTag("Floor") || hitInfo.transform.CompareTag("Unit")) && GetComponent<UnitStatus>().isSelected && !b_piecePermaLocked)
                {
                    if (hitInfo.transform.GetComponent<Renderer>().material.color == Color.cyan)
                    {
                        transform.position = new Vector3(hitInfo.transform.position.x, 1.0f, hitInfo.transform.position.z);
                    }
                    GetComponent<SCR_ShowUnitRange>().ShowRange();
                }
            }
        }
        if(Input.GetMouseButtonUp(0) && GetComponent<UnitStatus>().isSelected)
        {
            GetComponent<SCR_ShowUnitRange>().ClearTiles();
            b_piecePermaLocked = true;
            GetComponent<SCR_ShowUnitRange>().b_tileSet = false;
        }
    }
}
