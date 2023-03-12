using UnityEngine;
using UnityEngine.UI;

public class NameTransfer : MonoBehaviour
{
        
    public static string theName;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreName()
    {
        theName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = theName + ", set speeds and click start to play";
    }

}
