using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
/// <summary>
/// This makes an object move randomly in a set of directions, with some random time delay in between each decision
/// </summary>
public class Bat : MonoBehaviour
{
    int healthPointsToDeduct = 6;
   
    internal Transform thisTransform;
    public float spriteBlinkingTimer = 0.0f;
    public float spriteBlinkingMiniDuration = 0.1f;
    public float spriteBlinkingTotalTimer = 0.0f;
    public float spriteBlinkingTotalDuration = 1.0f;
    public bool startBlinking = false;
 
    // The movement speed of the object
    public float moveSpeed = 0.3f;
    public Vector3 startpoint=new Vector3(0,-1/2);
 
    // A minimum and maximum time delay for taking a decision, choosing a direction to move in
    public Vector2 decisionTime = new Vector2(1, 4);
    internal float decisionTimeCount = 0;
 
    // The possible directions that the object can move int, right, left, up, down, and zero for staying in place. I added zero twice to give a bigger chance if it happening than other directions
    internal Vector3[] moveDirections = new Vector3[] { Vector3.right, Vector3.left, Vector3.up, Vector3.down };
    internal int currentMoveDirection;
 
    // Use this for initialization
    void Start()
    {
        // Cache the transform for quicker access
        thisTransform = this.transform;
 
        // Set a random time delay for taking a decision ( changing direction, or standing in place for a while )
        decisionTimeCount = Random.Range(decisionTime.x, decisionTime.y);
 
        // Choose a movement direction, or stay in place
        ChooseMoveDirection();
    }
 
    // Update is called once per frame
    void Update()
    {
        // Move the object in the chosen direction at the set speed
        thisTransform.position += moveDirections[currentMoveDirection] * Time.deltaTime * moveSpeed;
 
        if (decisionTimeCount > 0) decisionTimeCount -= Time.deltaTime;
        else
        {
            // Choose a random time delay for taking a decision ( changing direction, or standing in place for a while )
            decisionTimeCount = Random.Range(decisionTime.x, decisionTime.y);
 
            // Choose a movement direction, or stay in place
            ChooseMoveDirection();
        }
        if(transform.position.y<-3/2)
        {
            thisTransform.position=startpoint;
        }
        if(transform.position.y>0)
        {
            thisTransform.position=startpoint;
        }
        if(startBlinking == true)
         { 
            SpriteBlinkingEffect();
         }
       
    }
 
    void ChooseMoveDirection()
    {
        // Choose whether to move sideways or up/down
        currentMoveDirection = Mathf.FloorToInt(Random.Range(0, moveDirections.Length));
    }

    void OnTriggerEnter2D(Collider2D obj){
        
        if(obj.CompareTag("Player")){
            Debug.Log(1);
            HealthPointManager.DeductHealthPoint(healthPointsToDeduct);
            startBlinking = true;
            //PlayerController.Sprite();
        }
            
    }

    private void SpriteBlinkingEffect()
      {
        spriteBlinkingTotalTimer += Time.deltaTime;
        if(spriteBlinkingTotalTimer >= spriteBlinkingTotalDuration)
        {
              startBlinking = false;
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
      }
}
 