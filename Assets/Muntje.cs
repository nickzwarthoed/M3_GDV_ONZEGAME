using System.Security.Cryptography;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Muntje : MonoBehaviour
{
    private TextMeshProUGUI coinText;
    private void Start()
    {
        //coinText = GameObject.FindWithTag("CoinText").GetComponent<TextMeshProUGUI>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("");
        if (collision.gameObject.tag == "Player")
        {
            //Player player = collision.gameObject.GetComponent<Player>();
            //player.coins += 1;
            //coinText.text = player.coin.ToString();
            Destroy(gameObject);
        }
    }
}