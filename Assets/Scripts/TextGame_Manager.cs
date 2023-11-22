using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextGame_Manager : MonoBehaviour {
    // variable int
    public int hunger, sanity;

    // variable textmesh pro
    public TextMeshProUGUI hungerTextValue, sanityTextValue, storyTextValue;

    // variable string
    public string start;

    // declare game object
    public GameObject hungerText, sanityText, level1_Choices, stats, mainScreen, choices;

    // Start is called before the first frame update
    void Start() {
        hunger = 0;
        sanity = 100;
        start = "can you see me?";
    }

    // Update is called once per frame
    void Update() {
        // textmeshpro.variable = value int
        hungerTextValue.text = hunger.ToString();
        sanityTextValue.text = sanity.ToString();
        storyTextValue.text = start;
    }

    // buttons
    public void StartButton() {
        choices.SetActive(true);
        hungerText.SetActive(true);
        sanityText.SetActive(true);
        mainScreen.SetActive(false);
    }
    public void ExitButton() {
        Application.Quit();
    }


    public void Yes() {
        sanity -= 10;
        hunger += 5;
        start = "Good";
        level1_Choices.SetActive(false);
    }
    public void No() {
        sanity -= 10;
        hunger += 80;
        start = "Oh ?";
        level1_Choices.SetActive(false);
    }
    public void DontAnswer() {
        sanity -= 80;
        hunger += 40;
        start = "How boring";
        level1_Choices.SetActive(false);
    }
}

