using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_ShowUnitRange : MonoBehaviour {

    RaycastHit hitInfo;
    SCR_FloorTileInfo tileBelow;

    public bool b_tileSet = false;

    private void Start()
    {
        hitInfo = new RaycastHit();
    }

    private void Update()
    {
        if (!GetComponent<UnitStatus>().isSelected)
            return;

        //Cast ray beneath unit to check which tile it's on
        if(Physics.Raycast(transform.position, Vector3.down, out hitInfo) && !b_tileSet)
        {
            if(hitInfo.transform.CompareTag("Floor"))
            {
                //Debug.Log("Piece is above tile: (" + hitInfo.transform.GetComponent<SCR_FloorTileInfo>().xPos + "," + hitInfo.transform.GetComponent<SCR_FloorTileInfo>().yPos + ")");
                tileBelow = hitInfo.transform.GetComponent<SCR_FloorTileInfo>();
                b_tileSet = true;
            }
        }
    }

    public void ShowRange()
    {
        int tempRange = GetComponent<UnitStatus>().range;

        Vector2 currentPos = new Vector2();

        if (tileBelow != null)
        {
            currentPos = new Vector2(tileBelow.xPos, tileBelow.yPos);


            //Tomando en cuenta el rango, cambiar material de tiles debajo para mostrarlo
            for (int i = tileBelow.xPos - tempRange; i <= tileBelow.xPos + tempRange; i++)
            {
                for (int j = tileBelow.yPos - tempRange; j <= tileBelow.yPos + tempRange; j++)
                {
                    if (i >= 0 && i < Board.width && j >= 0 && j < Board.height)
                    {
                        Vector2 tempVec = new Vector2(i, j);

                        if (SumIndex(currentPos, tempVec).x + SumIndex(currentPos, tempVec).y <= tempRange)
                        {
                            if (Board.Tiles[i, j].GetComponent<SCR_FloorTileInfo>().walkable)
                            {
                                if (SumIndex(currentPos, tempVec).x + SumIndex(currentPos, tempVec).y == tempRange)
                                {
                                    Board.Tiles[i, j].GetComponent<Renderer>().material.color = Color.red;
                                }
                                else
                                {
                                    Board.Tiles[i, j].GetComponent<Renderer>().material.color = Color.cyan;
                                }
                            }
                        }
                    }
                }
            }
        }
    }


    Vector2 SumIndex(Vector2 _first, Vector2 _second)
    {
        Vector2 tempVec;
        tempVec.x = Mathf.Abs(_second.x - _first.x);
        tempVec.y = Mathf.Abs(_second.y - _first.y);

        return tempVec;
    }

    public void ClearTiles()
    {
        for(int i = 0; i < Board.Tiles.GetLength(0); i++)
        {
            for(int j = 0; j < Board.Tiles.GetLength(1); j++)
            {
                if (Board.Tiles[i, j].GetComponent<SCR_FloorTileInfo>().walkable)
                {
                    Board.Tiles[i, j].GetComponent<Renderer>().material.color = Color.white;
                }
                else
                {
                    Board.Tiles[i, j].GetComponent<Renderer>().material.color = Color.black;
                }
            }
        }
    }
}
