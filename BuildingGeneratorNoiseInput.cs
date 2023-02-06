using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingGeneratorNoiseInput : MonoBehaviour
{
    public int maxPieces = 20;
    public float perlinScaleFactor = 2f;
    public int randomVariationMin = -5;
    public int randomVariationMax = 10;
    public GameObject[] middleParts;
    public GameObject[] topParts;
    public GridSpawner gridSpawner;

    void Start()
    {
        gridSpawner = GetComponentInParent<GridSpawner>();
        Build();
    }


    public void Build()
    {
        //float sampledValue = PerlinNoise.instance.PerlinSteppedPosition(transform.position);
        float sampledValue = gridSpawner.PerlinSteppedPosition(transform.position);

        int targetPieces = Mathf.FloorToInt(maxPieces * (sampledValue));
        targetPieces += Random.Range(randomVariationMin, randomVariationMax);

        if (targetPieces <= 0)
        {
            return;
        }

        float heightOffset = 0;
        //     heightOffset += SpawnPieceLayer(baseParts, heightOffset);

        for (int i = 1; i < targetPieces; i++) //if base parts exits start from i = 2
        {
            heightOffset += SpawnPieceLayer(middleParts, heightOffset);
        }

        SpawnPieceLayer(topParts, heightOffset);
    }

    float SpawnPieceLayer(GameObject[] pieceArray, float inputHeight)
    {
        Transform randomTransform = pieceArray[Random.Range(0, pieceArray.Length)].transform;
        GameObject clone = Instantiate(randomTransform.gameObject, this.transform.position + new Vector3(0, inputHeight, 0), transform.rotation) as GameObject;
        Mesh cloneMesh = clone.GetComponentInChildren<MeshFilter>().mesh;
        Bounds baseBounds = cloneMesh.bounds;
        float heightOffset = baseBounds.size.y;

        clone.transform.SetParent(this.transform);

        //GeneratedObjectControl.instance.AddObject(clone);

        return heightOffset;
    }




}