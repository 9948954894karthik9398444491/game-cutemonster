using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public static gamemanager instance;
    public GameObject lives;
    public GameObject overpanel;
    int score = 0;
    int life = 3;
    bool gameover = false;
    public Text scoreT;
    private void Awake()
    {
        
            instance = this;

    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void increment()
    {
        if (!gameover)
        {
            score++;
            //Debug.Log($"Score Text: {scoreText.text}");
            //Debug.Log($"Score: {score.ToString()}");
            scoreT.text = score.ToString();
            //print(score);
        }
    }
    public void live()
    {
        if (life > 0)
        {
            life--;
           // print(life);
            lives.transform.GetChild(life).gameObject.SetActive(false);
        }
        if (life <= 0)
        {
            
            gameover = true;
            game();
        }
    }
    public void game()
    {
        spawner.instance.Stoping();
        GameObject.Find("monster").GetComponent<PLayer>().move = false;
        //var player = GameObject.Find("Player");
        //if (player != null)
        // player.GetComponent<PLayer>().move = false;
        overpanel.SetActive(true);
        //print("gameover");
    }
    public void Restart()
    {
        SceneManager.LoadScene("game");
    }
    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
}
