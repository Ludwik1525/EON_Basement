using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zinnia.Rule;

public class Test : GameObjectRule
{
    override protected bool Accepts(GameObject target)
    {
        return target.tag == "Floor";
    }
}
