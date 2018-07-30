using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour {

    public static GameObject[,] Tiles;

    public static int width = 15;
    public static int height = 10;

    public enum TileTypes
    {
        EMPTY = 0,
        DIRT = 1,
    }

}
