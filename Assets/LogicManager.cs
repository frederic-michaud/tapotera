using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    
    [ContextMenu("Increase score")]
    public void AddScore() {
        score++;
        scoreText.text = score.ToString();
    }
    
    public void resetGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
