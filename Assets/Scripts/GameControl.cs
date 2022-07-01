using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameControl : MonoBehaviour 
{
    public bool paused;
    
    public static GameControl instance;        
    public Text scoreText;                  
    public GameObject gameOvertext;            
    public int score = 0;                     
    public bool gameOver = false;     
    public float scrollSpeed = -4.0f;
    

    void Awake(){
        if (instance == null)
            instance = this;
        else if(instance != this)
            Destroy (gameObject);
    }
    void Update(){
    if (gameOver && Input.GetKeyDown("space")) {
            Application.LoadLevel("Main");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                                                }
                                                
    if(Input.GetKeyUp(KeyCode.Escape)){
        if(!paused){    
				Time.timeScale = 0; 
				paused=true;
                    }else{     
				Time.timeScale = 1;   
				paused=false;  
                }  
                                    }
         }
    public void BirdScored(){
        if (gameOver)   
            return;
        score++;
        scoreText.text = "Score: " + score.ToString();
                            }
    public void BirdDied(){
        gameOvertext.SetActive (true);
        gameOver = true;
                        }
                        
}