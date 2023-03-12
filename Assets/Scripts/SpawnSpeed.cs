using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnSpeed : MonoBehaviour
{
    public static float CarSpawnSpeed = .30f;
    public Slider ChangeSpawnSpeed;
    public Text ShowSpawnSpeed;


    // Start is called before the first frame update
   /* void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }*/
    public void AdjustSpawnSpeed()
    {
        CarSpawnSpeed = ChangeSpawnSpeed.value;
        ShowSpawnSpeed.text = "SPAWN RATE IS " + CarSpawnSpeed.ToString();
    }
}
