using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float moveSpeed;
	private Animator anim;
    private bool playerMoving;
    private Vector2 lastMove;
    private Rigidbody2D myRigidbody;
  
    //private bool firstenterkitchen;
    //private bool firstentercorrider;
    private string lastSceneName;
   
    //public static int talkingToWizard;
    // Start is called before the first frame update
    void Start()
    {
        //talkingToWizard=0;
        anim = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        //isAttack=false;
        
        /*firstenterkitchen=false;
        Scene currentScene = SceneManager.GetActiveScene ();
        lastSceneName="Hall";*/
    }


    // Update is called once per frame
    void Update()
    {
        playerMoving = false;
        /*Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        if (sceneName == "kitchen" && !firstenterkitchen && lastSceneName=="Hall"){
            if(lastSceneName=="Hall")
                myRigidbody.transform.position = new Vector2(-2,0);
            else if(lastSceneName=="Corridor")
                myRigidbody.transform.position = new Vector2(2,0);
            firstenterkitchen=true;
            lastSceneName=sceneName;
        }
        if (sceneName != "kitchen"){
            firstenterkitchen=false;
        }
        if (sceneName == "Corridor" && !firstentercorrider && lastSceneName=="kitchen"){
            myRigidbody.transform.position = new Vector2(-2,0);
            firstentercorrider=true;
            lastSceneName=sceneName;
        }
        if (sceneName != "Corridor"){
            firstentercorrider=false;
        }*/
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f) {
        	//transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
            myRigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, myRigidbody.velocity.y);
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f) {
        	//transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            playerMoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed);
        }

        if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
        {
            myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y);
        }

        if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, 0f);
        }

        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        anim.SetBool("PlayerMoving", playerMoving);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);

        
    }
    /*public void Sprite()
      {
        spriteBlinkingTotalTimer += Time.deltaTime;
        if(spriteBlinkingTotalTimer >= spriteBlinkingTotalDuration)
        {
              //startBlinking = false;
             spriteBlinkingTotalTimer = 0.0f;
             this.gameObject.GetComponent<SpriteRenderer> ().enabled = true;   // according to 
                      //your sprite
             return;
          }
     
     spriteBlinkingTimer += Time.deltaTime;
     if(spriteBlinkingTimer >= spriteBlinkingMiniDuration)
     {
         spriteBlinkingTimer = 0.0f;
         if (this.gameObject.GetComponent<SpriteRenderer> ().enabled == true) {
             this.gameObject.GetComponent<SpriteRenderer> ().enabled = false;  //make changes
         } else {
             this.gameObject.GetComponent<SpriteRenderer> ().enabled = true;   //make changes
         }
     }
      }*/
}
