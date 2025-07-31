using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int hp;

    [SerializeField] TextMeshProUGUI BossText;
    [SerializeField] GameManager gameManager;


    

    public void TakeDamage() 
    {
        hp -= 10;
            Debug.Log("Your boss's credibility went down to " +  hp);
        BossText.text = "Boss Credibility: " + hp.ToString();
        if (hp <= 0) 
        {
            Debug.Log("Your boss is fired, you've been promoted!");
            gameManager.EnemyDefeated();

            Debug.Log("Now to target your new boss!");
            hp += 1000;
            BossText.text = "Boss Credibility: " + hp.ToString();
        }
    }
}