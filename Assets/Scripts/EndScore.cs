using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    //float scoreText = Score.CurrentScore;
    string playerName = NameTransfer.theName;
    int playerScore = Score.CurrentScore;
    
    public GameObject displayText;
   // public static string finalscore = playerScore.ToString();


    public void Start()
    {
        displayText.GetComponent<Text>().text = "FINAL SCORE: " + playerScore;
        //text.text = CurrentScore.ToString();
    }
}
