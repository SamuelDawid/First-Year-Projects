using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GridGeneretor : MonoBehaviour {

    public Transform parent;
    public GameObject player;
    public GameObject enemy;
    public GameObject enemy1;
    public int enemyAmount = 5;
    public int enemyAmount1 = 5;
    
    public GameObject[] tiles;
    public GameObject wall;

    public List <Vector3> createdTiles;

    public int tileAmount;
    public int tileOffset;
    public float waitTime;

    public float chanceUp;
    public float chanceRight;
    public float chanceDown;

    // Wall generation
    public float minY = 999999;
    public float maxY = 0;
    public float minX = 999999;
    public float maxX = 0;
    public float xAmount;
    public float yAmount;
    public float extraWallsX;
    public float extraWallsY;



    // Use this for initialization
    void Start () {
        parent = new GameObject().transform;
        parent.name = "LevelParent";
        StartCoroutine(GenerateLevel());
        
	}
	
	IEnumerator GenerateLevel()
    {
        for(int i =0; i < tileAmount; i++)
        {
            float dir = Random.Range(0f, 1f);
            int tile = Random.Range(0, tiles.Length);

            CreateTile(tile);
            CallMoveGen(dir);

            yield return new WaitForSeconds(waitTime);
            if(i == tileAmount -1)
            {
                End();
            }
        }
        yield return  0;
    }
    void CallMoveGen(float ranDir)
    {
        if(ranDir < chanceUp)
        {
            MoveGen(0);
        }
        else if (ranDir < chanceRight)
        {
            MoveGen(1);
        }
        else if (ranDir < chanceDown)
        {
            MoveGen(2);
        }
        else
        {
            MoveGen(3);
        }
    }
    void MoveGen(int dir)
    {
        switch(dir)
        {
            case 0:
                transform.position = new Vector3(transform.position.x, transform.position.y + tileOffset, 0);
                break;
            case 1:
                transform.position = new Vector3(transform.position.x + tileOffset, transform.position.y , 0);
                break;
            case 2:
                transform.position = new Vector3(transform.position.x, transform.position.y - tileOffset, 0);
                break;
            case 3:
                transform.position = new Vector3(transform.position.x - tileOffset, transform.position.y, 0);
                break;
        }
    }
    void CreateTile(int tileIndex)
    {
        if(!createdTiles.Contains(transform.position))
        {
            GameObject tileObject;

            tileObject = Instantiate(tiles[tileIndex], transform.position, transform.rotation) as GameObject;
            createdTiles.Add(tileObject.transform.position);
            tileObject.transform.parent = parent;
        }
       else
        {
            tileAmount++;
        }
    }
    void End()
    {
        CreatedWallValues();
        CreatWalls();
        SpawnObjects();
    }
    void SpawnObjects()
    {
         Instantiate(player, createdTiles[Random.Range(0, createdTiles.Count)], Quaternion.identity);
        for (int i = 0; i < enemyAmount; i++)
        {
            Instantiate(enemy, createdTiles[Random.Range(0, createdTiles.Count)], Quaternion.identity);
            
        }
        for (int i = 0; i < enemyAmount1; i++)
        {
            Instantiate(enemy1, createdTiles[Random.Range(0, createdTiles.Count)], Quaternion.identity);

        }
    }
    void CreatedWallValues()
    {
        for (int i = 0; i < createdTiles.Count; i++)
        {
            if(createdTiles[i].y < minY)
            {
                minY = createdTiles[i].y;
            }
            if (createdTiles[i].y > maxY)
            {
                maxY = createdTiles[i].y;
            }
            if (createdTiles[i].x < minX)
            {
                minX = createdTiles[i].x;
            }
            if (createdTiles[i].x > maxX)
            {
                maxX = createdTiles[i].x;
            }

            xAmount = ((maxX - minX) / tileOffset) + extraWallsX;
            yAmount = ((maxY - minY) / tileOffset) + extraWallsY;
        }
    }
    void CreatWalls()
    {
        for(int x = 0; x < xAmount; x++)
        {
            for(int y = 0; y< yAmount; y++)
            {
                if (!createdTiles.Contains(new Vector3((minX - (extraWallsX * tileOffset) / 2) + (x * tileOffset), (minY - (extraWallsY * tileOffset) / 2) + (y * tileOffset))))
                {
                    GameObject wallObj =(GameObject)Instantiate(wall, new Vector3((minX - (extraWallsX * tileOffset) / 2) + (x * tileOffset), (minY - (extraWallsY * tileOffset) / 2) + (y * tileOffset)), transform.rotation);
                    wallObj.transform.parent = parent;
                }
            }
        }
    }
   
}
