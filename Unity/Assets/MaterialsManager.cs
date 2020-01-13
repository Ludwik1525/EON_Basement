using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialsManager : MonoBehaviour
{
    public Material floorMaterial;
    public Material innerWallsMaterial;
    public Material outerWallsMaterial;
    public Material ceilingMaterial;

    private GameObject ceiling, floor, outerWalls, innerWalls;

    void Start()
    {
        ceiling = GameObject.Find("Ceiling");
        floor = GameObject.Find("Floor");
        outerWalls = GameObject.Find("OuterWalls");
        innerWalls = GameObject.Find("InnerWalls");


        SetCeilingMaterial();
        SetFloorMaterial();
        SetInnerWallsMaterial();
        SetOuterWallsMaterial();
    }

    void SetCeilingMaterial()
    {
        foreach (Transform segment in ceiling.transform)
        {
            foreach (Transform ceilingTile in segment)
            {
                if (ceilingTile.tag != "Custom")
                {
                    ceilingTile.gameObject.GetComponentInChildren<Renderer>().material = ceilingMaterial;
                }
            }
        }
    }

    void SetFloorMaterial()
    {
        foreach (Transform segment in floor.transform)
        {
            foreach (Transform floorTile in segment)
            {
                if (floorTile.tag != "Custom")
                {
                    floorTile.gameObject.GetComponentInChildren<Renderer>().material = floorMaterial;
                }
            }
        }
    }

    void SetInnerWallsMaterial()
    {
        foreach (Transform segment in innerWalls.transform)
        {
            foreach (Transform innerWall in segment)
            {
                if (innerWall.tag != "Custom")
                {
                        innerWall.gameObject.GetComponentInChildren<Renderer>().material = innerWallsMaterial;
                }
            }
        }
    }

    void SetOuterWallsMaterial()
    {
        foreach (Transform segment in outerWalls.transform)
        {
            foreach (Transform outerWall in segment)
            {
                if (outerWall.tag != "Custom")
                {
                            outerWall.gameObject.GetComponentInChildren<Renderer>().material = outerWallsMaterial;
                }
            }
        }
    }

}
