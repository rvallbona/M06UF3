using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour
{
    [SerializeField] GameObject canvasLoggin, canvasMainMenu, canvasInGame, canvasOptions, canvasCredits;
    public void ChangeInGameCanvas()
    {
        canvasInGame.SetActive(true);
        canvasMainMenu.SetActive(false);
    }
    public void ChangeOptionCanvas()
    {
        canvasOptions.SetActive(true);
        canvasMainMenu.SetActive(false);
    }
    public void ChangeCreditsCanvas()
    {
        canvasCredits.SetActive(true);
        canvasMainMenu.SetActive(false);
    }
    public void BackOptions()
    {
        canvasOptions.SetActive(false);
        canvasMainMenu.SetActive(true);
    }
    public void BackCredits()
    {
        canvasCredits.SetActive(false);
        canvasMainMenu.SetActive(true);
    }
    public void Logged()
    {
        canvasLoggin.SetActive(false);
        canvasMainMenu.SetActive(true);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
