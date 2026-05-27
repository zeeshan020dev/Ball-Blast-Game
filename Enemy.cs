using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;
    public GameObject explosionParticles; // Particle System Requirement
    public AudioClip hitSound;             // Sound System Requirement

    void Update()
    {
        // Move towards the player
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            // Add score and destroy as before
            FindObjectOfType<GameManager>().AddScore(10);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Player"))
        {
            // REQUIREMENT: Health System Implementation
            FindObjectOfType<GameManager>().TakeDamage(1);

            // Visual feedback
            Destroy(gameObject);
        }
    }
}
