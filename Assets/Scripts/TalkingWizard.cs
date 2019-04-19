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
    public GameObject door;
    public GameObject wizard;
    private int talkingToWizard = 0;
    //static int enterTimes=0;
    private bool crystalBall = false;
    void start(){
        curtain.SetActive(true);
        door.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (talkingToWizard==0)
        {
            Block target=talkChart.FindBlock(enterToDialogueBox);
            talkChart.ExecuteBlock(target);
            talkingToWizard++;
        }
        else if (talkingToWizard>=1 && talkingToWizard<=2 && !crystalBall)
        {
            Block target=talkChart.FindBlock("Busy");
            talkChart.ExecuteBlock(target);
            talkingToWizard++;
        }
        else{
            Block target=talkChart.FindBlock("Finish");
            talkChart.ExecuteBlock(target);
            door.SetActive(true);
           
            //Destroy(curtain, 2);
            //Destroy(gameObject, 2);

        }
    }

}