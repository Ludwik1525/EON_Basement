using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelChanger : MonoBehaviour
{

    public GameObject[] models;
    private int currentModel;
    // Start is called before the first frame update
    void Start()
    {
        currentModel = 0;
    }


    public void ChangeModel(float direction)
    {
        int tempModel;

        if(direction > 0) tempModel = currentModel + 1;
        else tempModel = currentModel - 1;

        if (tempModel > models.Length-1) tempModel = 0;
        else if (tempModel < 0) tempModel = models.Length-1;

        models[currentModel].SetActive(false);
        models[tempModel].SetActive(true);
        currentModel = tempModel;
    }
}
