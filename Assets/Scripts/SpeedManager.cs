using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedManager : MonoBehaviour
{
    public static float Speed;
    public Slider ChangeSpeed;
    public Text ShowSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AdjustSpeed()
    {
        Speed = ChangeSpeed.value;
        ShowSpeed.text = "CAR SPEED IS " + Speed.ToString();
    }
}
