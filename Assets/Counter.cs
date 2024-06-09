using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalCounter : MonoBehaviour
{
    public Text eggCountText;
    public Text chickCountText;
    public Text henCountText;
    public Text roosterCountText;

    public Image eggCountImage;
    public Image chickCountImage;
    public Image henCountImage;
    public Image roosterCountImage;

       void Start()
    {
        UpdateCounterUI();
    }
    void Update()
    {
        UpdateCounterUI();
    }
    void UpdateCounterUI()
    {
        GameObject[] eggs = GameObject.FindGameObjectsWithTag("Egg");
        GameObject[] chicks = GameObject.FindGameObjectsWithTag("Chick");
        GameObject[] hens = GameObject.FindGameObjectsWithTag("Hen");
        GameObject[] roosters = GameObject.FindGameObjectsWithTag("Rooster");

        eggCountText.text = "Eggs: " + eggs.Length;
        chickCountText.text = "Chicks: " + chicks.Length;
        henCountText.text = "Hens: " + hens.Length;
        roosterCountText.text = "Roosters: " + roosters.Length;
    }
}