using UnityEngine;

public class Wallet : MonoBehaviour
{
    [SerializeField] private int coins = 0;

    public int Coins => coins;

    public void AddCoins(int amount)
    {
        if (amount <= 0)
            return;

        coins += amount;

        Debug.Log("Монеты: " + coins);
    }

    public bool SpendCoins(int amount)
    {
        if (amount <= 0 || coins < amount)
            return false;

        coins -= amount;
        return true;
    }
}

