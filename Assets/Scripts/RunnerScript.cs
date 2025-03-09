using UnityEngine;

public class RunnerScript : MonoBehaviour
{
    public GameObject gameOverPanel; 
    public letterSpawnerLetter LetterSpawner; // Assign this in the Inspector
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -8) {
            Debug.Log("Game over");
            GameObject obj = GameObject.FindGameObjectWithTag("GameOver");
            
            gameOverPanel.SetActive(true);    
            LetterSpawner.Stop();
            
            
          }
        }
}
