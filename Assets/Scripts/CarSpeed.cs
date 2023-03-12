using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSpeed : MonoBehaviour
{
    public static float ForwardSpeed = 8f;
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
        ForwardSpeed = ChangeSpeed.value;
        ShowSpeed.text = "CAR SPEED IS " + ForwardSpeed.ToString();
    }
}
