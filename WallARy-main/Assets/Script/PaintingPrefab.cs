using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PaintingPrefab : MonoBehaviour
{
    public RawImage image;
    public bool isSelected = false;
    public PopulateArkworkGallery populateAddPhotos;
    public GameObject selectedObject;
    // Start is called before the first frame update
    void Awake()
    {
        image = GetComponent<RawImage>();
    }

    // Update is called once per frame
    public void  OnClick()
    {
        if(populateAddPhotos.selectedPainting != null && populateAddPhotos.selectedPainting != this)
        {
            populateAddPhotos.selectedPainting.isSelected = false;
            populateAddPhotos.selectedPainting.selectedObject.SetActive(false);
        }
        isSelected = !isSelected;
        populateAddPhotos.selectedPainting = this;
        selectedObject.SetActive(isSelected);
        populateAddPhotos.btnManager.FrameworkSelection();
        populateAddPhotos.btnManager.imgManager.imageToSave = image.mainTexture;
        //populateAddPhotos.btnManager.imgselect.rawImage.texture = image.mainTexture;
    }
}
