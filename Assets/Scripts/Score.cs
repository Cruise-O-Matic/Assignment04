using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int CurrentScore;

    public Text text;

    void Start()
    {
        text.text = CurrentScore.ToString();
    }

}
