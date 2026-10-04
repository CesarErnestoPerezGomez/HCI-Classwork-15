using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinvalue = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CoinManager manager = FindObjectOfType<CoinManager>();
            if (manager != null)
            {
                manager.AddCoin(coinvalue);
            }
            Destroy(gameObject);
        }
    }
}
