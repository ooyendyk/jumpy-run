using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    private float score = 0f;
    private float scoreOut = 0f;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //NOTE: The following line is inefficient
        if (GameObject.Find("Player").GetComponent<PlayerController>().gameOver == false)
        {
            score = score + 50 * Time.deltaTime;
            scoreOut = Mathf.Round(score);
            scoreText.text = scoreOut.ToString();
        }
    }
}
