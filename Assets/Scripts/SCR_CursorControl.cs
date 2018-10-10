using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_CursorControl : MonoBehaviour
{
    SCR_Tooltip toolTip;

    private void Start()
    {
        toolTip = FindObjectOfType<SCR_Tooltip>();
    }

    // Update is called once per frame
    void Update ()
    {
        //Cursor move -- Separated for a more natural feel
        if (Input.GetButtonDown("Horizontal"))
        {
            transform.position = new Vector3(transform.position.x + Input.GetAxisRaw("Horizontal"), transform.position.y, transform.position.z);
        }

        if (Input.GetButtonDown("Vertical"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Input.GetAxisRaw("Vertical"));
        }

        //Restrictions
        if (transform.position.x > Board.width)
        {
            transform.position = new Vector3(Board.width, transform.position.y, transform.position.z);
        }

        if (transform.position.x < 0)
        {
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }

        if (transform.position.z > Board.height-1)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Board.height-1);
        }

        if (transform.position.z < 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("SOMETHING ENTERED");
        if(other.gameObject.CompareTag("Unit"))
        {
            Debug.Log("IT WAS ME, DIO");
            toolTip.ShowTooltip(other.GetComponent<UnitStatus>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        toolTip.HideTooltip();
    }
}
