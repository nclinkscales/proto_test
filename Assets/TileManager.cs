using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    Tile[,] tiles = new Tile[0, 0];

    public Tile GetTile(Vector2 pos)
    {
        return tiles[(int)pos.x, (int)pos.y];
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
