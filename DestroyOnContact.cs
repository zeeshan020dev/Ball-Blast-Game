using UnityEngine;

public class DestroyOnContact : MonoBehaviour
{
    public GameObject explosionPrefab;
    public AudioClip hitSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            // 1. Visual Feedback
            if (explosionPrefab != null)
            {
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            }

            // 2. Audio Feedback
            if (hitSound != null)
            {
                // We use the Camera's position so the sound is always at full volume 
                // and not affected by 3D distance/panning.
                AudioSource.PlayClipAtPoint(hitSound, Camera.main.transform.position, 1.0f);
            }

            // 3. Score Update
            FindObjectOfType<GameManager>().AddScore(10);

            // 4. Cleanup
            Destroy(other.gameObject); // Destroy Bullet
            Destroy(gameObject);        // Destroy Enemy
        }
    }
}