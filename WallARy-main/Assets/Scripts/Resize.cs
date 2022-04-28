using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resize : MonoBehaviour
{
    GameObject paintingCanvas;
    RectTransform paintingCanvas_rt;
    int paintingCanvasHeight;
    float paintingCanvas_x;
    float paintingCanvas_y;

    // Start is called before the first frame update
    public void Start()
    {
        paintingCanvas = GameObject.Find("PaitingCanvas");
        paintingCanvas_rt = paintingCanvas.GetComponent<RectTransform>();
      

    }
    private void Update()
    {
        paintingCanvas_x = paintingCanvas_rt.sizeDelta.x;
        paintingCanvas_y = paintingCanvas_rt.sizeDelta.y;
        if (Input.GetKeyDown("t"))
        {
            //  paintingCanvas_rt.sizeDelta = new Vector2(paintingCanvas_rt.sizeDelta.y + 100 , paintingCanvas_rt.sizeDelta.x);
            paintingCanvas_rt.sizeDelta = new Vector2(paintingCanvas_x, paintingCanvas_rt.sizeDelta.y + 100);
        }
        if(Input.GetKeyDown("q"))
        {
            paintingCanvas_rt.sizeDelta = new Vector2(paintingCanvas_rt.sizeDelta.x + 100, paintingCanvas_rt.sizeDelta.y);
        }
    }



}
