using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LevelGenerator : MonoBehaviour
{
    //public NavMesh surface;
    public int height = 10;
    public int width = 10;

    public GameObject wall;
    public GameObject player;

    private bool playerSpawned = false;

    private void Start()
    {
        GenerateLevel();

        //Update NavMesh

    }

    void GenerateLevel()
    {
        //Loop over the grid
        for (int x = 0; x <= width; x+=2)
        {
            for(int y = 0; y <= height; y+=2)
            {
                //should we place a wall?
                if (Random.value > .7f)
                {
                    //spawn a wall
                    Vector3 pos = new Vector3(x - width / 2f, 1f, y - height / 2f);
                    Instantiate(wall, pos, Quaternion.identity, transform);
                }

                else if (!playerSpawned) //should we spawn the player?
                {
                    //spawn player
                    Vector3 pos = new Vector3(x - width / 2f, 1.25f, y - height / 2f);
                    Instantiate(player, pos, Quaternion.identity);
                    playerSpawned = true;
                }
            }
        }
    }
}
