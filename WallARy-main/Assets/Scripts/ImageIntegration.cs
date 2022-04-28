using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ImageIntegration : MonoBehaviour
{
    public RawImage rawImg;
    public ImageManager imgManager;
    // Start is called before the first frame update
    void Awake()
    {
        rawImg = GetComponent<RawImage>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rawImg.texture = imgManager.imageToSave;
    }

}
