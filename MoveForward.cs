using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 20f;
    void Update() { transform.Translate(Vector3.forward * speed * Time.deltaTime); }
}