using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    public GameObject StartPanel;
    private float fixedDeltaTime;

     void Awake()
    {
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }

     void Start()
    {
        Time.timeScale = 0.0f;
    }
    


    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitButton()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void StartButton()
     {

         StartPanel.SetActive(false);
         Time.timeScale = 1.0f;
        
     }
}
