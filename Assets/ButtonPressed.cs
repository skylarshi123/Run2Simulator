using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPressed : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void onPressed()
    {
        //Image image = GetComponent<Image>(); //pointer to the image
        //image.color = Color.blue;
        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        
    }
}