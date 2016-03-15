using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class keypress : MonoBehaviour
{
    public Text outputText;
    int counter = 0;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            counter++;
            outputText.text = "Key Press : " + counter;
        }
    }
}
