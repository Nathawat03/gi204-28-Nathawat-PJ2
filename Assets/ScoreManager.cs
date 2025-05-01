using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public int ScoreCount;
    public Text ScoreText;
    void Start()
    {
      
        
    } // Start

    
    void Update()
    {
        ScoreText.text = ScoreCount.ToString();
        
    }// Update
    
}// ScoreManager
