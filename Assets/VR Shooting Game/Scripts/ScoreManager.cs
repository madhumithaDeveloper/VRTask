using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public UIManager uIManager;
    public int baseScore = 100;
    public int bulletsCount = 10;
    public int currentScore = 0;


    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }


    public void UpdateScore(int score)
    {
        currentScore += score;
        bulletsCount--;

        if(currentScore >= baseScore)
        {
            uIManager.WonGame();
            if(bulletsCount<= 0)
                uIManager.LoseGame();
        }
    }
}
