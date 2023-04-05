using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCanvas : MonoBehaviour
{
    public GameObject screen;

    public void HideScreen() {
        if (screen.activeInHierarchy)
            screen.SetActive(false);
    }
}
