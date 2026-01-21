using UnityEngine;

public class StatManager : MonoBehaviour
{
    public int collectedCoins;

    public void ChangeCoins(int amountCollected)
    {
        collectedCoins += amountCollected;
        collectedCoins = Mathf.Clamp(collectedCoins, 0, 99);
    }
}