using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImagePrefab : MonoBehaviour
{
    public RawImage image;
    public RawImage rwImgCopy;
    //  public ImageSelection imgselect;
    public bool isSelected = false;
    public ButtonManager btnManager;
    public PopulateMyPhotos populatePhotos;
    public GameObject selectedObject;
    // Start is called before the first frame update
    void Awake()
    {
        image = GetComponent<RawImage>();
    //    imgselect = FindObjectOfType<ImageSelection>();
    }
    private void Update()
    {
        
    }
    // Update is called once per frame
    public void OnClick()
    {
        if (populatePhotos.selectedImage != null && populatePhotos.selectedImage != this)
        {
            populatePhotos.selectedImage.isSelected = false;
            populatePhotos.selectedImage.selectedObject.SetActive(false);
        }
        isSelected = !isSelected;
        populatePhotos.selectedImage = this;
        selectedObject.SetActive(isSelected);
        populatePhotos.btnManager.FrameworkSelection();
        populatePhotos.btnManager.imgManager.imageToSave = image.mainTexture;
        //populateAddPhotos.btnManager.imgselect.rawImage.texture = image.mainTexture;
    }
}
