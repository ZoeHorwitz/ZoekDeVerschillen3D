using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
    {
        public void PlayGame()
        {
     
        //SampleScene.sceneNumber = 0;
        SceneManager.LoadScene("MenuScene");
        }
    private void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void QuitGame()
        {
            Application.Quit();
        }
    }

