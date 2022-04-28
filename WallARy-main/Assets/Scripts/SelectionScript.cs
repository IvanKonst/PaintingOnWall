using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionScript : MonoBehaviour
{
    public GameObject childSelection;
    public int buttonclicked = 0;
    public void OnImageSelected()
    {
        if ( buttonclicked == 0 )
        {
            childSelection.SetActive(true);
            //  btnManager.imageSelected = true;
            
        }
        if(buttonclicked == 1)
        {
            childSelection.SetActive(false);
            buttonclicked = 0;
        }
        buttonclicked++;

    }
}
