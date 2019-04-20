using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueHolder : MonoBehaviour
{
    public string dialogue;
    private DialogueManager dMan;
    // Start is called before the first frame update
    void Start()
    {
        dMan = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //print("triggered");
        if (other.gameObject.tag == "Player")
        {
            //print("it is player");
            //if (Input.GetKeyUp(KeyCode.Space))
            //{
                dMan.ShowBox(dialogue);
            //}
        }
    }
}
