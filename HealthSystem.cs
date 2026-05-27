using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int health = 3;
    public void TakeDamage()
    {
        health--;
        if (health <= 0) Debug.Log("Game Over!");
    }
}
