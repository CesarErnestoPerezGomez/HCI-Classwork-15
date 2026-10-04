using UnityEngine;
using TMPro; 


public class CoinManager : MonoBehaviour
{
    public TextMeshProUGUI coinText;

    public int coinCount = 0;
    void Start()
    {
        UpdateCoinText();
    }

    public void AddCoin(int amount)
    {
        coinCount += amount;
        UpdateCoinText();
    }
    
    void UpdateCoinText()
    {
        coinText.text = "Coins Collected: " + coinCount.ToString();
    }
}
