using UnityEngine;

public class fps : MonoBehaviour
{
    GUIStyle style;

    void Start()
    {
        style = new GUIStyle();
        style.fontSize = 40;  // <- grootte van de tekst
        style.normal.textColor = Color.white;
    }

    void OnGUI()
    {
        float fps = 1.0f / Time.deltaTime;
        GUI.Label(new Rect(10, 10, 100, 20), "FPS: " + Mathf.Round(fps));
    }
}
