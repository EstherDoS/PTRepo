using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    private string noise;
    public string Noise     // encapsulation
    {
        get
        {
            return noise;
        }
        set
        {
            noise = value;
        }
    }

   
    public string MakeNoise()
    {
        return $"{noise}";
    }
    public void MakeNoise(string n)  // overloading
    {
        noise = n;
        Debug.Log($"{name}: {noise}");
    }

    public virtual string Reproduction() { return "";  }  // polymorphism


}
