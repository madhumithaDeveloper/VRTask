using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Lean.Transition.Method;

public class UIManager : MonoBehaviour
{
    public GameObject uIMenu;
    public GameObject notifyPlayerScore;
    public TextMeshProUGUI notifyGameStatusText;
    public TextMeshProUGUI notifyScoreText;
    public Button restartButton;
    public LeanTransformLocalScale leanTransformLocalScale;
    int minBulletCount;

    private void Awake()
    {
        minBulletCount = ScoreManager.instance.bulletsCount;
        restartButton.onClick.AddListener(() => SceneManager.LoadScene(0));
    }


    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.X))
        {
            uIMenu.SetActive(true);
        }
    }


    public void WonGame()
    {
        leanTransformLocalScale.BeginThisTransition();
        notifyPlayerScore.SetActive(true);
        notifyGameStatusText.text = "You Won!";
        notifyScoreText.text = "Bullets used: " + ScoreManager.instance.bulletsCount + "/" + minBulletCount + "\n Your score: " + ScoreManager.instance.currentScore;
    }


    public void LoseGame()
    {
        leanTransformLocalScale.BeginThisTransition();
        notifyPlayerScore.SetActive(true);
        notifyGameStatusText.text = "You Lose!";
        notifyScoreText.text = "Bullets used: " + ScoreManager.instance.bulletsCount + "/" + minBulletCount + "\n Your score: " + ScoreManager.instance.currentScore;
    }
}
