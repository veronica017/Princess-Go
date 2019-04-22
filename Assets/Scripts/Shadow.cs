using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    // Start is called before the first frame update
    int healthPointsToDeduct = 3;
    public float spriteBlinkingTimer = 0.0f;
    public float spriteBlinkingMiniDuration = 0.1f;
    public float spriteBlinkingTotalTimer = 0.0f;
    public float spriteBlinkingTotalDuration = 1.0f;
    public bool startBlinking = false;
    void Start()
    {
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if(startBlinking == true)
         { 
            SpriteBlinkingEffect();
         }
    }

    void OnTriggerEnter2D(Collider2D obj){
         if(obj.CompareTag("Player")){
            Debug.Log(1);
            HealthPointManager.DeductHealthPoint(healthPointsToDeduct);
            startBlinking = true;
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
