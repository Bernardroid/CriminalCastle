using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_DetectObstacles : MonoBehaviour {

    Ray rayCast;
    RaycastHit rayHit;
	// Use this for initialization
	void Start ()
    {
        rayCast.direction = Vector3.up;
        rayCast.origin = transform.position;
        if (Physics.Raycast(rayCast, out rayHit, 0.5f))
        {
            if (rayHit.transform.CompareTag("Obstacle"))
            {
                gameObject.transform.GetComponent<SCR_FloorTileInfo>().walkable = false;
                GameObject.FindGameObjectWithTag("GameManager").GetComponent<SCR_InstaGrid>().DrawTileSet();
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
