using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;


public class TalkingWizard : MonoBehaviour
{
    
    public string enterToDialogueBox;
    public Flowchart talkChart;
    public GameObject curtain;
    private static int talkingToWizard = 0;
    public static bool completed;
    //private bool crystalBall = false;
    //public static bool hasThreeMarbles;
    private Inventory inventory;

    void Start(){
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

        if (completed)
        {
            curtain.SetActive(false);
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (talkingToWizard==0)
        {
            Block target=talkChart.FindBlock(enterToDialogueBox);
            talkChart.ExecuteBlock(target);
            talkingToWizard++;
        }
        else if (talkingToWizard>=1 && !BallController.allFound)
        {
            Block target=talkChart.FindBlock("Busy");
            talkChart.ExecuteBlock(target);
            talkingToWizard++;
        }
        else{
            Block target=talkChart.FindBlock("Finish");
            talkChart.ExecuteBlock(target);
            completed = true;
        }
    }

}