using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crow : Animal
{
    void Start()
    {
        Noise = "krah!";
        //MakeNoise(Noise);
        //Reproduction();
    }

    public override string Reproduction()
    {
        //Debug.Log($"{name}: I lay eggs <3");
        return "<3 I lay eggs <3";
    }
}
