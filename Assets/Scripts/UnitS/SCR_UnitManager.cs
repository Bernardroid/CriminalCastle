using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_UnitManager : MonoBehaviour
{
    public SCR_Grid gridManager;
    public GameObject[] unitsPrefabs;
    public GameObject[] playedUnits;
    public GameObject pointer;
    public int finishedUnits;
    public int currentUnit;
    public int currentX;
    public int currentY;
    

    // Use this for initialization
    void Start()
    {
        Invoke("SelectUnit", 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        Controls();
    }

    void SelectunitOnClick()
    {

    }

    void SelectUnit()
    {

        if (currentUnit > playedUnits.Length)
        {
            currentUnit = 0;
        }
        else if (currentUnit < 0)
        {
            currentUnit = playedUnits.Length - 1;
        }

        playedUnits[currentUnit].GetComponent<SCR_Unit>().isSelected = true;

        currentX = gridManager.NodeFromWorldPoint(playedUnits[currentUnit].transform.position).gridX;
        currentY = gridManager.NodeFromWorldPoint(playedUnits[currentUnit].transform.position).gridY;
        MovePointer();
    }

    void NextUnit()
    {
        if (finishedUnits<playedUnits.Length)
        {
            playedUnits[currentUnit].GetComponent<SCR_Unit>().isSelected = false;

            currentUnit++;
            if (currentUnit > playedUnits.Length)
            {
                currentUnit = 0;
            }
            playedUnits[currentUnit].GetComponent<SCR_Unit>().isSelected = true;

            currentX = gridManager.NodeFromWorldPoint(playedUnits[currentUnit].transform.position).gridX;
            currentY = gridManager.NodeFromWorldPoint(playedUnits[currentUnit].transform.position).gridY;
            MovePointer();
        }
        else
        {
            FinishTurn();
        }
    }
    
    void PastUnit()
    {
        if (finishedUnits < playedUnits.Length)
        {
            playedUnits[currentUnit].GetComponent<SCR_Unit>().isSelected = false;

            currentUnit--;
            if (currentUnit < 0)
            {
                currentUnit = playedUnits.Length - 1;
            }
            playedUnits[currentUnit].GetComponent<SCR_Unit>().isSelected = true;

            currentX = gridManager.NodeFromWorldPoint(playedUnits[currentUnit].transform.position).gridX;
            currentY = gridManager.NodeFromWorldPoint(playedUnits[currentUnit].transform.position).gridY;
            MovePointer();
        }
        else
        {
            FinishTurn();

        }
    }
    void MovePointer()
    {
        if(currentX>=gridManager.gridSize.x)
        {
            currentX = (int)gridManager.gridSize.x-1;
        }
        else if(currentX<0)
        {
            currentX = 0;
        }

        if (currentY >= gridManager.gridSize.y)
        {
            currentY = (int)gridManager.gridSize.y-1;
        }
        else if (currentY<0)
        {
            currentY = 0;
        }
        pointer.transform.position = gridManager.grid[currentX, currentY].position+Vector3.up;
    }
    void SelectTile()
    {
        Debug.Log(gridManager.NodeFromWorldPoint(pointer.transform.position).isWalkable);
        if(gridManager.NodeFromWorldPoint(pointer.transform.position).isWalkable)
        {
            playedUnits[currentUnit].transform.position = gridManager.NodeFromWorldPoint(pointer.transform.position).position;
            playedUnits[currentUnit].GetComponent<SCR_Unit>().hasMoved = true;
        }
        NextUnit();
    }
    void FinishTurn()
    {

    }

    void ResetUnitsStats()
    {
        finishedUnits = 0;
        for(int i=0; i<playedUnits.Length;i++)
        {
            playedUnits[i].GetComponent<SCR_Unit>().hasMoved = false;
            playedUnits[i].GetComponent<SCR_Unit>().isSelected = false;
        }
    }

    void InstantiateUnitsOnStart()
    {
        //BernyHelpu
    }

    void Controls()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            PastUnit();
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            NextUnit();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentY++;
            MovePointer();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentY--;
            MovePointer();
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentX--;
            MovePointer();
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentX++;
            MovePointer();
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            SelectTile();
        }

    }


}
