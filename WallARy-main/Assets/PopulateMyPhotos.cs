using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateMyPhotos : MonoBehaviour
{
    public ImagePrefab imgPrefab;

    public Transform myPhotosGrid;

    public ButtonManager btnManager;

    public ImagePrefab selectedImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PopulateWithPhotos(Texture texture)
    {
        
        ImagePrefab newObj;
        newObj = Instantiate(imgPrefab, myPhotosGrid);
        newObj.populatePhotos = this;
        newObj.btnManager = btnManager;
        newObj.GetComponent<RawImage>().texture = texture;
    }
  

}
