using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mosaic
{
    public class WaterDisplay : MonoBehaviour
    {
        int min = 0;
        int max = 1;

        float[,] waterHeights = new float[100, 2];
        Terrain terrain;

        // Use this for initialization
        void Start()
        {
            terrain = transform.GetComponent<Terrain>();

        }

        // Update is called once per frame
        void Update()
        {

        }

        void updateWaterHeights()
        {
            terrain.terrainData.SetHeights(0, 0, waterHeights);
        }

        void createNewHeightMap()
        {
            for (int i = 0; i < waterHeights.GetLength(0); i++)
            {
                for (int j = 0; j < waterHeights.GetLength(1); j++)
                {
                    waterHeights[i, j] = Random.Range(min, max);
                }
            }
        }
    }
}
