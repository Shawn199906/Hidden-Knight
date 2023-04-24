using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEditor;

public class Generater : MonoBehaviour
{
    public Tilemap tilemap;
    public TileBase tile;
    public int row;
    public int col;
    private int TotalPlace;
    private int PlaceCount;
    //Start place and end place must be odd
    public Vector2Int startPlace;
    public Vector2Int endPlace;
    public List<List<int>> mapGenerate;

    enum Direction
    {
        up=1,right,down,left
    }
    //0 is the place not marked, 1 is the wall, 2 is the place marked
    
    private void Start()
    {
        TotalPlace = row * col;
        row = row * 2 + 1;
        col = col * 2 + 1;
        mapGenerate = new List<List<int>>();
        for (int i=0;i<row;i++)
        {
            mapGenerate.Add(new List<int>());
            for (int j=0;j<col;j++)
            {
                if (i%2==0||j%2==0)
                {
                    mapGenerate[i].Add(1);
                }
                else
                {
                    mapGenerate[i].Add(0);
                }
            }
        }
        PlaceCount = 1;
        mapGenerate[startPlace.x][startPlace.y] = 2;
        DFS(startPlace);
        DrawTilemap();
    }

    private void DFS(Vector2Int currentPlace)
    {
        if (PlaceCount==TotalPlace||currentPlace==endPlace)
        {
            return;
        }
        List<int> accessDir = new List<int>();
        while (true)
        {
            HasAccess(accessDir,currentPlace);
            if (accessDir.Count>0)
            {
                int RandomIndex = Random.Range(0,accessDir.Count);
                Vector2Int nextPlace = OpenUp(currentPlace,(Direction)accessDir[RandomIndex]);
                PlaceCount++;
                accessDir.RemoveAt(RandomIndex);
                DFS(nextPlace);
            }
            else
            {
                break;
            }
        }
    }

    private void HasAccess(List<int> dirList, Vector2Int currentPlace)
    {
        dirList.Clear();
        for (int i=(int)Direction.up;i<=(int)Direction.left;i++)
        {
            Vector2Int neighbor = GetNeighbor(currentPlace,(Direction)i);
            if (neighbor.x>0 && neighbor.y>0 && neighbor.x<row && neighbor.y<col && mapGenerate[neighbor.x][neighbor.y]==0)
            {
                dirList.Add(i);
            }
        }
    }

    private Vector2Int GetNeighbor(Vector2Int currentPlace, Direction direction)
    {
        switch (direction)
        {
            case Direction.up:
                return new Vector2Int(currentPlace.x,currentPlace.y-2);
            case Direction.right:
                return new Vector2Int(currentPlace.x+2, currentPlace.y);
            case Direction.down:
                return new Vector2Int(currentPlace.x, currentPlace.y+2);
            case Direction.left:
                return new Vector2Int(currentPlace.x-2, currentPlace.y);
            default:
                return new Vector2Int(0,0);
        }
    }

    private Vector2Int OpenUp(Vector2Int currentPlace, Direction direction)
    {
        Vector2Int nextPlace = GetNeighbor(currentPlace, direction);
        mapGenerate[nextPlace.x][nextPlace.y]= 2;
        switch (direction)
        {
            case Direction.up:
                mapGenerate[currentPlace.x][currentPlace.y-1]= 2;
                break;
            case Direction.right:
                mapGenerate[currentPlace.x+1][currentPlace.y] = 2;
                break;
            case Direction.down:
                mapGenerate[currentPlace.x][currentPlace.y + 1] = 2;
                break;
            case Direction.left:
                mapGenerate[currentPlace.x-1][currentPlace.y] = 2;
                break;
            default:
                break;
        }
        return nextPlace;
    }

    private void DrawTilemap()
    {
        for (int i=0;i<row;i++)
        {
            for (int j=0;j<col;j++)
            {
                if (mapGenerate[i][j]==1)
                {
                    tilemap.SetTile(new Vector3Int(i,j,0),tile);
                }
            }
        }
    }
}
