using UnityEngine;
using Unity.Mathematics;

public class haai : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float moveDistance = 5f;

    private Vector3 startPosition;
    private quaternion startRotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        bool invert = false;
        float distance = math.fmod(Time.time*moveSpeed, 1);
        if (math.fmod(Time.time*moveSpeed, 2) > 1)
        {
            distance = 1 - distance;
            invert = true;
        }

        transform.rotation = startRotation;

        transform.position = startPosition + (transform.up*(distance - 0.5f) * moveDistance);

        if (invert)
        {
            transform.rotation = startRotation * Quaternion.Euler(0, 0, 180);
        }
        else
        {
            transform.rotation = startRotation;
        }
    }
}
