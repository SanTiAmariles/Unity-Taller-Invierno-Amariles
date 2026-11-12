using UnityEngine;

public class SirenRotation : MonoBehaviour
{
    public float rotationSpeed = 180f;

    private void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
