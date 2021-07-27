using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLoader : MonoBehaviour
{
    public Transform block;
    Transform ironBlock;
    Transform homeBlock;

    private void Start()
    {
        LoadPrefabs();
        LoadMap();
    }

    private void LoadPrefabs()
    {
        block = Resources.Load<Transform>("Prefabs/block");
        ironBlock = Resources.Load<Transform>("Prefabs/ironBlock");
        homeBlock = Resources.Load<Transform>("Prefabs/homeBlock");
    }

    private void LoadMap()
    {
        string[] map_str = System.IO.File.ReadAllLines(@"Assets/Maps/map1.txt");
        GenerateMap(map_str);
    }

    private void GenerateMap(string[] map_str)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Transform t = null;
                if (map_str[i][j] == 'b')
                {
                    t = Instantiate(block, new Vector3(j - 4.5f, 5.5f - (i + 1), 0), block.rotation) as Transform;
                }
                else if (map_str[i][j] == 'i')
                {
                    t = Instantiate(ironBlock, new Vector3(j - 4.5f, 5.5f - (i + 1), 0), ironBlock.rotation) as Transform;
                }
                else if (map_str[i][j] == 'h')
                {
                    t = Instantiate(homeBlock, new Vector3(j - 4.5f, 5.5f - (i + 1), 0), homeBlock.rotation) as Transform;
                }
            }
        }
    }
}
