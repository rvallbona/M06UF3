using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CanvasManager : MonoBehaviour
{
    [SerializeField] GameObject canvasInGame, canvasRecipies;
    public void ChangeScene(int nscene)
    {
        SceneManager.LoadScene(nscene);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void ChangeRecipiesCanvas()
    {
        canvasRecipies.SetActive(true);
        canvasInGame.SetActive(false);
    }
    public void BackRecipies()
    {
        canvasRecipies.SetActive(false);
        canvasInGame.SetActive(true);
    }

    //public void BackGame()
    //{
    //    canvasPauseMenu.SetActive(false);
    //    audioMenu.Stop();
    //    audioInGame.Play();
    //    Time.timeScale = 1;
    //    Cursor.lockState = CursorLockMode.Locked;
    //}
}
