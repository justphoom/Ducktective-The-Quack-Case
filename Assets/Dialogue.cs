using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Dialogue : MonoBehaviour
{

    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                textComponent.text = lines[index];
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        textComponent.text = lines[index];
    }


    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = lines[index];
        }
        else
        {
            gameObject.SetActive(false);
            string scene_name = SceneManager.GetActiveScene().name;
            switch (scene_name)
            {
                case "Landing":
                    SceneManager.LoadScene("Tutorial Scene");
                    break;
                case "Main Game Introduction":
                    SceneManager.LoadScene("Main Game");
                    break;
                default:
                    break;
            }
        }
    }

}