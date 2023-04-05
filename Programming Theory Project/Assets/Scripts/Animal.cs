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

    // encapsulation (only visible for children) + polymorphism
    protected void MakeNoise()
    {  
        Debug.Log($"{name}: {noise}");
    }
    protected void MakeNoise(string n)  // overloading
    {  
        Debug.Log($"{name}: {noise}");
    }

    public virtual void Reproduction() { }  // polymorphism


}
