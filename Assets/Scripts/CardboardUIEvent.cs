using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CardboardUIEvent : MonoBehaviour {
    public Color colorHover;
    public Color colorNatural;
    Image imageScript;

    void Awake() {
        imageScript = GetComponent<Image>();
    }

    public void OnPointEnterEvent() {
        imageScript.color = colorHover;
    }

    public void OnPointExitEvent()
    {
        imageScript.color = colorNatural;
    }
}
