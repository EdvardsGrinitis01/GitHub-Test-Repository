using UnityEngine;


public class CoinScript : MonoBehaviour
{
    public int collectedCoins;
    private object statManager;
    public GameObject Collectable;
 

    public void ChangeCoins(int amountCollected)
    {
        collectedCoins += amountCollected;
        collectedCoins = Mathf.Clamp(collectedCoins, 0, 99);
    }
}