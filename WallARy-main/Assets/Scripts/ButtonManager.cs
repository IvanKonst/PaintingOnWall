using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DanielLochner.Assets.SimpleScrollSnap;

public class ButtonManager : MonoBehaviour
{
    public ImageSelection imgselect;

    public FrameManager frameManager;

    public ImageManager imgManager;

    public GameObject OnboardingOne;
    public GameObject OnboardingTwo;
    public GameObject OnboardingThree;
    public GameObject livingRoom;
    public GameObject ChooseArtwork;
    public GameObject myPhotos;
    public GameObject frameSelection;

    public SimpleScrollSnap scroll;

    public Texture[] frames;

    public bool artWork;
    public bool imageSelected;
    public bool photoSelectionScreen;
    public void OnBoardingOneNextButton()
    {
        OnboardingOne.SetActive(false);
        OnboardingTwo.SetActive(true);
    }
    public void OnBoardingTwoNextButton()
    {
        OnboardingTwo.SetActive(false);
        OnboardingThree.SetActive(true);
    }
    public void OnBoardingThreeNextButton()
    {
        OnboardingThree.SetActive(false);
        livingRoom.SetActive(true);
    }
    public void LivingRoomButton()
    {
        livingRoom.SetActive(false);
        ChooseArtwork.SetActive(true);
        artWork = true;
    }
    public void ChooseArtworkBackButton()
    {
        ChooseArtwork.SetActive(false);
        livingRoom.SetActive(true);
    }
    public void ArtGalleryButton()
    {
        myPhotos.SetActive(false);
        ChooseArtwork.SetActive(true);
        artWork = true;
    }
    public void MyPhotosButton()
    {
        ChooseArtwork.SetActive(false);
        myPhotos.SetActive(true);
    }
    public void MyPhotosBackButton()
    {
        myPhotos.SetActive(false);
        ChooseArtwork.SetActive(true);
        artWork = true;
    }
    public void FrameSelectionBackButton()
    {
        frameSelection.SetActive(false);
        myPhotos.SetActive(true);
    }
    
    public void FrameworkSelection()
    {
        myPhotos.SetActive(false);
        frameSelection.SetActive(true);
    }
 
    public void ARPreviewButtonPressed()
    {
        DontDestroyOnLoad(imgselect);
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(frameManager);
        DontDestroyOnLoad(imgManager);
        SceneManager.LoadScene("DemoARScene Working");
    }
  
    public void RequestButtonPressed()
    {
        SceneManager.LoadScene("Request_UI");
    }

    private void Start()
    {
        scroll.OnPanelCentered.AddListener((page, index) =>
        {
            print(page + " " + index);
            print(frames[page]);
            frameManager.textureToSave = frames[page];
        });
    }
}
