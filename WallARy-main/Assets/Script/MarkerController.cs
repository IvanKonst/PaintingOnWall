using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarkerController : MonoBehaviour
{

    public Button placeMarkerButton;
    public Transform marker;
    public RawImage iconImg;
    public RawImageSave rawImgSave;
    public GameObject wall;
    //public Transform camera;
    
    private RaycastHit hitInfo;
    private bool isLock = false;

    void Start()
    {
        wall.SetActive(false);
    }

    public void Lock()
    {
        isLock = true;
        
        iconImg.texture = ImageSelection.texturetopass;
        placeMarkerButton.gameObject.SetActive(false);
        wall.SetActive(true);
        wall.transform.parent = null;
        marker.gameObject.SetActive(false);
    }

    void Update()
    {
        if (isLock) return;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hitInfo))
        {
            placeMarkerButton.enabled = true;

            marker.gameObject.SetActive(true);
            marker.position = hitInfo.point;

            LookUP();
        }
        else
        {
            marker.gameObject.SetActive(false);
            placeMarkerButton.enabled = false;
        }

    }

    private void LookUP()
    {
        var lookPos = Camera.main.transform.position - marker.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        marker.rotation = rotation;// Quaternion.Slerp(marker.rotation, rotation, Time.deltaTime * 0.1f);
        marker.Rotate(Vector3.up, 180);
    }
}
