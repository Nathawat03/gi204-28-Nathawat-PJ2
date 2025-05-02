using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int ScoreCount;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI WINTEXT;
    
  
    void Update()
    {
        ScoreText.text = ScoreCount.ToString($": {ScoreCount}");

        if (ScoreCount == 9 )
        {
            // WIN
            WINTEXT.gameObject.SetActive(true);
            Time.timeScale = 0;
            
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reset Game
            } // GetKeyDown KeyCode.R
            
        } // ScoreCount == 9 to WIN
        
    }// Update
    
}// ScoreManager
