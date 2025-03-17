using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Beam"))
        {
            //destroy beams
            Destroy(other.gameObject);

            //destroy enemies
            Destroy(gameObject);

            
        }
    }
}
