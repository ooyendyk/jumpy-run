using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{

    private int numOfUiElements = 3;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HERE");
    }

    // Update is called once per frame
    void Update()
    {
        //NOTE: The following line is inefficient
        if (GameObject.Find("Player").GetComponent<PlayerController>().gameOver == true)
        {
            Debug.Log("Game over: Invoking interface");
            ActivateChildren(numOfUiElements);
        }

    }

    void ActivateChildren(int numOfUiElements)
    {
        for (int i = 0; i < numOfUiElements; i++)
        {
            gameObject.transform.GetChild(i).gameObject.SetActive(true);
        }
    }
}
