using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
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
            WonGame();
            if(bulletsCount<= 0)
                LoseGame();
        }
    }


    public void WonGame()
    {
        Debug.Log("won");
    }

    public void LoseGame()
    {
        Debug.Log("lose");
    }
}
