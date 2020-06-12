using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public bool  GameOver = false;
private float ContagemFim = 3;
public int Score;
public Text scoreText;
    void Start(){
        Time.timeScale = 1;
    }
        
        private void FixedUpdate()
        {
            if(GameOver) return;
        }
    void update()
    {
        if(GameOver)
        {
            ContagemFim -= Time.deltaTime;
            if(ContagemFim<=0)
            {
                if(Input.GetKeyDown(KeyCode.Space)|| Input.GetMouseButtonDown(0))
                {
                   SceneManager.LoadScene("SampleScene");
                }
            }
        }
    }
      public void RestartGame(){
          SceneManager.LoadScene(0);
      }
 private void OnCollisionEnter(Collision col) {
     GameOver = true;
 }
}
