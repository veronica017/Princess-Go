using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject[] balls;
    public static bool[] ballFound = new bool[3];
    public static bool here;
    public static bool allFound;

    // Start is called before the first frame update
    void Start()
    {
        if (allFound)
        {
            gameObject.SetActive(false);
        }
        else
        {
            for (int i = 0; i < ballFound.Length; i++)
            {
                if (!ballFound[i])
                {
                    balls[i].SetActive(false);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!allFound)
        {
            for (int i = 0; i < ballFound.Length; i++)
            {
                if (ballFound[i])
                {
                    balls[i].SetActive(true);
                }
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            here = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            here = false;
        }

        CheckAllFound();
    }

    private void CheckAllFound()
    {
        foreach (bool i in ballFound)
        {
            if (!i)
            {
                return;
            }
        }
        allFound = true;
    }
}
