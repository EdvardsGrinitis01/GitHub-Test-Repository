using UnityEngine;

public class StatManager : MonoBehaviour
{
    public int collectedCoins;
    public int currentCheckpoint;

    public void ChangeCoins(int amountCollected)
    {
        collectedCoins += amountCollected;
        collectedCoins = Mathf.Clamp(collectedCoins, 0, 99);
    }

    public void TriggerCheckpoint(int chechpointIndex)
    {
        currentCheckpoint = chechpointIndex;
    }
}