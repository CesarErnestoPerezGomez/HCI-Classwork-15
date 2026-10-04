using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class FinishLine : MonoBehaviour
{
    private int requiredCoins = 3;
    [SerializeField] private GameObject winCanvas;
    private bool completed;

    private void Awake()
    {
        winCanvas.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CoinManager manager = other.GetComponent<CoinManager>();
            if (manager != null)
            {
                if (manager.coinCount >= requiredCoins)
                {
                    completed = true;
                    winCanvas.SetActive(true);
                }
                else
                {
                    Debug.Log("You did not collected all the coins to win");
                }
            }
        }
    }
}