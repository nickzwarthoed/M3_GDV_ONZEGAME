using UnityEngine;

public class Proegwerk : MonoBehaviour
{
    Vector2 som1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("hoi");
        som1 = new Vector2(3, 4);
        Debug.Log(som1.magnitude);
        Debug.Log(som1.normalized);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
