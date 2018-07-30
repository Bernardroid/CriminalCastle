using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_PieceLock : MonoBehaviour {

    public SCR_DragRoom currentPiece;

    RaycastHit hitInfo;

	void Start () {

        hitInfo = new RaycastHit();
		
	}
	
	void Update ()
    {

        //Get reference to current piece
        if(Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo) && (hitInfo.transform.CompareTag("Room") || hitInfo.transform.CompareTag("Unit")))
            {
                currentPiece = hitInfo.transform.GetComponent<SCR_DragRoom>();
                if(currentPiece.b_piecePermaLocked)
                {
                    Debug.Log("Piece is perma locked!");
                    currentPiece = null;
                }
            }
        }

        if(Input.GetMouseButtonUp(0))
        {
            currentPiece = null;
        }
		
        //PermaLock piece
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (currentPiece == null)
                return;

            //Check here if it can be perma locked
            currentPiece.b_piecePermaLocked = true;

        }

        //Reset permalocks with leftAlt + 5
        //if(Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.Alpha5))
        //{
        //    GameFlow.ResetPermaLocks();
        //}
	}

    
}
