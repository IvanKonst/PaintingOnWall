using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetImage : MonoBehaviour
{
    public RawImage imageRawImage;
    public ImageManager imgManager;
    // Start is called before the first frame update
    void Awake()
    {
        imageRawImage = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Start()
    {
        imgManager = FindObjectOfType<ImageManager>();
        imageRawImage.texture = imgManager.imageToSave;
    }
}
