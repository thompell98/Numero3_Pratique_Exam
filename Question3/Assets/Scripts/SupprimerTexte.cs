using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SupprimerTexte : MonoBehaviour {

    public Text texte;
    public float temps = 2;
	// Use this for initialization
	void Start () {
        ChangerTexte();
        DetruireTexte();
	}

    void ChangerTexte()
    {
        texte.text = "Bang";
    }

    void DetruireTexte()
    {
        Destroy(gameObject, temps);
    }
}
