using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cat : Animal
{
    
    void Start()
    {
        Noise = "meow!";
        //MakeNoise();
        //MakeNoise(Noise);
        //Reproduction();
    }

    public override string Reproduction()
    {
        //Debug.Log($"{name}: I give birth to kitten <3");
        return "<3 I give birth to kitten <3";
    }
}
