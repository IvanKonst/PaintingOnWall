using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetFrame : MonoBehaviour
{

    public RawImage frameRawImage;
    public FrameManager frameManager;
    // Start is called before the first frame update
    private void Awake()
    {
        frameRawImage = GetComponent<RawImage>();
    }
    void Start()
    {
        frameManager = FindObjectOfType<FrameManager>();    
        frameRawImage.texture = frameManager.textureToSave;
    }

    // Update is called once per frame
    void Update()
    {

    }

}
