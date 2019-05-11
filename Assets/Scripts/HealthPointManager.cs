using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthPointManager : MonoBehaviour
{
    static public float healthPoint;
    public Texture2D textureToDisplay;
    static public int initialHealthPoint = 60;
    public Slider healthBar;
    private const float coef = 0.4f;
    static int gameEnd = 0;
    public GUISkin theSkin;
   

    //Text text;

    void Start()
    {
        //text = GetComponent<Text>();
        healthBar = GetComponent<Slider>();
        healthPoint = initialHealthPoint;
        healthBar.value = healthPoint;
    }

    void Update()
    {
        healthPoint -= coef * Time.deltaTime;
        if (healthPoint < 0)
        {
            //GameObject.FindGameObjectWithTag("Player").SetActive(false);
            gameEnd = 1;
            Time.timeScale = 0;
        }
        //text.text = "" + healthPoint;
        healthBar.value = healthPoint;
    }

    public static void AddHealthPoints(int healthPointsToAdd)
    {
        healthPoint = healthPoint + healthPointsToAdd;
    }
    public static void DeductHealthPoint(int healthPointsToDeduct)
    {
        healthPoint = healthPoint - healthPointsToDeduct;
    }

    private void OnGUI()
    {
        GUI.skin = theSkin;

        if (gameEnd == 1)
        {
            //GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2, 500, 100), "Game Over!");
            GUI.Label(new Rect(10, 40, textureToDisplay.width, textureToDisplay.height), textureToDisplay);
            
            Time.timeScale = 0;
           //SceneManager.LoadScene (0);
        }
    }
}
