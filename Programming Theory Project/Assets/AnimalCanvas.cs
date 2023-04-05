using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System; // for Type

public class AnimalCanvas : MonoBehaviour
{
    private GameObject animal;
    [SerializeField] private TextMeshProUGUI _animal;
    [SerializeField] private TextMeshProUGUI _text;

    private void Start()
    {
        animal = null;
        _text.text = "";
        _animal.text = "";
    }

    public void SetAnimal(string animalName)
    {
       animal = GameObject.Find(animalName);
        _animal.text = $"{animal.name}:";
        _text.text = "";
    }

    public void SetText(string action) {

        string s = "";

        if (action.Equals("noise")) {
            s = animal.GetComponent<Animal>().MakeNoise();
            //_text.text = $"{animal.name}: {s}";
            _text.text = $"{s}";
        }
        if (action.Equals("reproduce")) {
            s = animal.GetComponent<Animal>().Reproduction();
            _text.text = $"{s}";
        }
        
    }

    #region abandoned cause not working

    //Type aniT = animal.GetType();

    //Type animalT = Type.GetType(animal.name);
    //Debug.Log("animalT: "+animalT);

    //Type animalType = stringToType(animal.name);
    //Type stringToType(string from)
    //{
    //    return Type.GetType(from);
    //}
    #endregion


}
