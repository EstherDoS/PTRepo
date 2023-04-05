using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crow : Animal
{
    void Start()
    {
        Noise = "krah!";
        MakeNoise(Noise);
        Reproduction();
    }

    public override void Reproduction()
    {
        Debug.Log($"{name}: I lay eggs <3");
    }
}
