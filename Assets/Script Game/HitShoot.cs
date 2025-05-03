using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitShoot : MonoBehaviour
{

    void Start()
    {
        Destroy(this.gameObject, 5f);
    } // start
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("HIT!!");
            Destroy(other.gameObject);
        }
        
    }//OnTriggerEnter2D Gems Points
}
