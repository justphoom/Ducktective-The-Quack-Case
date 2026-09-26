using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingScript : MonoBehaviour
{
    // public GameObject gameLabel;
    public GameObject startButton;
    public GameObject DialogueBox;
    public GameObject logo;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        // gameLabel.SetActive(true);
        startButton.SetActive(true);
        DialogueBox.SetActive(false);
        logo.SetActive(true);
    }

    public void startGame()
    {
        // gameLabel.SetActive(false);
        startButton.SetActive(false);
        DialogueBox.SetActive(true);
        logo.SetActive(false);
        audio.Play();
    }
}
