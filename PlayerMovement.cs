using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 15f;
    public float xRange = 10f; // Keep player within screen bounds
    public GameObject bulletPrefab;
    public AudioClip shootSound; // NEW: Slot for shooting sound

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        // Move on the X axis
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        // Keep player on screen
        if (transform.position.x < -xRange) transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        if (transform.position.x > xRange) transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        // Inside Update:
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            if (shootSound != null)
            {
                AudioSource.PlayClipAtPoint(shootSound, transform.position);
            }
        }
    }
    

}