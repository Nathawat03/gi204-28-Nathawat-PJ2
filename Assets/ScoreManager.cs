using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public int ScoreCount;
    public TextMeshProUGUI ScoreText;
    
    void Update()
    {
        ScoreText.text = ScoreCount.ToString($"Score: {ScoreCount}");
        
    }// Update
    
}// ScoreManager
