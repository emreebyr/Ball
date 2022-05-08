using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{

    public Text timerText;
    private float startTime;
    private bool finnished = false;
    public GameObject gameOverPanel;
    Trigger erisim;

    

    // Start is called before the first frame update
    void Start()
    {
        erisim = GetComponent<Trigger>();
    }

    // Update is called once per frame
     void Update()
    {
        if (finnished)
        return;
        float t = Time.time - startTime;    
        string minutes = ((int) t /60) . ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;

    }
    
        public void Finnish()
        {   
            finnished = true;
            timerText.color = Color.yellow;
            erisim.score = erisim.score -1;
            Invoke("GameFinish",2.5f);
            

        }

            public void GameFinish()
            {
                gameOverPanel.SetActive(true);
            }
}
