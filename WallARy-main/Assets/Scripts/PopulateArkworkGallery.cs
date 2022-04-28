using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateArkworkGallery : MonoBehaviour
{
    public Texture[] images;

    public PaintingPrefab paintingPrefab;

    public Transform artGalleryGrid;

    public ButtonManager btnManager;

    public PaintingPrefab selectedPainting;

    void Start()
    {
     
        
    }

    // Update is called once per frame
    void Update()
    {
        if (btnManager.artWork)
        {
            Populate();
            btnManager.artWork = false;
        }
    }
    void Populate()
    {
        PaintingPrefab newObj;

        for(int i = 0; i< images.Length; i++)
        {
            newObj = Instantiate(paintingPrefab, artGalleryGrid);
            newObj.image.texture = images[i];
            newObj.populateAddPhotos = this;
        }
    }

}
