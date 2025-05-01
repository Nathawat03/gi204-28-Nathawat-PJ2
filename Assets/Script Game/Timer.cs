using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    float elapsedTime;
    
    void Update()
    {
        elapsedTime += Time.deltaTime;
        int minutes = (int)elapsedTime / 60; 
        int seconds = (int)elapsedTime % 60;
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        
    } //Update Timer
    
}// Timer
