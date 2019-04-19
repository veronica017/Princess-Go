using System;
using System.Collections;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //private Rigidbody2D myRigidbody;
    private BoxCollider2D boxCollider;

    //public GameObject gameObject;
    [Header("What NPC wants to say:")]
    public String npcTalk;

    [Header("Text's position:")]
    public int x;
    public int y;

    static String showText = "";
    //static float now;
    static int meetNPC = 0;
    private IEnumerator coroutine;

    void Start()
    {
        //myRigidbody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            meetNPC = 1;
            showText = npcTalk;

            print("You have to find a key");
            //print(myRigidbody.transform.position);
            print(boxCollider.transform.position);
            StartCoroutine(DeleteText());
        }
    }

    void OnGUI()
    {
        //print(Time.time);
        GUI.Label(new Rect(x, y, 100, 500), showText);
    }

    private IEnumerator DeleteText()
    {
        yield return new WaitForSeconds(2);
        showText = "";
        meetNPC = 0;
    }

}