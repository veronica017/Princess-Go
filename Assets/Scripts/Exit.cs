using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;
using UnityEngine.UI;


public class Exit : MonoBehaviour
{
    public Flowchart talkChart;
    public static bool here;
    public GameObject Win;
    public static bool keyFound;
    public GUISkin theSkin;
    public static bool gameEnd;
     //public Texture2D textureToDisplay;

    void Start(){
         //GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2, textureToDisplay.width, textureToDisplay.height), textureToDisplay);
        Win.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            here = true;
            if (!keyFound)
            {
                Block target = talkChart.FindBlock("Soldier");
                talkChart.ExecuteBlock(target);
            }
            else
            {
                Block target = talkChart.FindBlock("Win");
                talkChart.ExecuteBlock(target);
                gameEnd = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            here = false;
        }
    }

    private void OnGUI()
    {
        GUI.skin = theSkin;

        if (gameEnd)
        {
           // GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2, 500, 100), "You win!");
            Win.SetActive(true);
            // GUI.Label(new Rect(10, 40, textureToDisplay.width, textureToDisplay.height), textureToDisplay);
            Time.timeScale = 0;
        }
    }
}