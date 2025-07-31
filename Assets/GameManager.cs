using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int money;
    int switches;


    [SerializeField] TextMeshProUGUI MoneyText; 
    [SerializeField] TextMeshProUGUI SwitchText;


    public void AddMoney() 
    {
        money += 10;
        Debug.Log("You got: " + money + " Dollars!");

        MoneyText.text = "Money: $" + money.ToString();
       
    
    }

    public void BuySwitch() 
    {
        if (money >= 999)
        {
            Debug.Log("You bought a Nintendo Switch 2!");
            switches += 1;

            SwitchText.text = "Scalped Switch 2s: " + switches.ToString();
            money -= 999;
            MoneyText.text = "Money: $" + money.ToString();
        }
        else 
        {
            Debug.Log("Come back when you're a little... Errrrmmmmm.... Richerrrr.");
        
        }
    
    
    
    }

    public void EnemyDefeated() 
    {
        money += 9999;
        MoneyText.text = "Money: $" + money.ToString();
    }


}
