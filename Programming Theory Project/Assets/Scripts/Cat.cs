using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cat : Animal
{
    
    void Start()
    {
        Noise = "meow!";
        MakeNoise(Noise);
        Reproduction();
    }

    public override void Reproduction()
    {
        Debug.Log($"{name}: I give birth to kitten <3");
    }
}
