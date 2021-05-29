using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource UIAudioPlayer;
    public GameObject HelpScreen;
    public GameObject MainScreen;
    public AudioClip Button;
    public AudioClip MenuPopUp;
    public void Help()
    {
        UIAudioPlayer.Stop();
        UIAudioPlayer.PlayOneShot(Button);
        UIAudioPlayer.PlayOneShot(MenuPopUp);
        MainScreen.SetActive(false);
        HelpScreen.SetActive(true);
    }
    public void Home()
    {
        UIAudioPlayer.Stop();
        UIAudioPlayer.PlayOneShot(Button);
        HelpScreen.SetActive(false);
        MainScreen.SetActive(true);
    }
    public void StartExperience()
    {
        UIAudioPlayer.Stop();
        UIAudioPlayer.PlayOneShot(Button);
        SceneManager.LoadScene("MainExperience");
    }
}
