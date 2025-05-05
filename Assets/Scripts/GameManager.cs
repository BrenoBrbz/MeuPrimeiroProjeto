using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public BallController ballController;

    public Transform playerPaddle;
    public Transform enemyPaddle;

    public static int playerScore = 0;
    public static int enemyScore = 0;

    public TextMeshProUGUI textPointPlayer;
    public TextMeshProUGUI textPointEnemy;

    public int winPoints = 10;

    public GameObject screenEndGame;

    public TextMeshProUGUI textEndGame;

    void Awake()
    {
      Instance = this;
    }

    void Start()
    {
      ResetGame();  
    }

    // Update is called once per frame
    void ResetGame()
    {
        playerPaddle.position = new Vector3(7f, 0f, 0f);
        enemyPaddle.position = new Vector3(-7f, 0f, 0f);

        ballController.ResetBall();

        playerScore =0;
        enemyScore = 0;

        textPointEnemy.text = enemyScore.ToString();
        textPointPlayer.text = playerScore.ToString();

    }

    public static void ScorePlayer()
    {
      playerScore++;
      Instance.textPointPlayer.text = playerScore.ToString();
      Instance.CheckWin();
    }

    public static void ScoreEnemy()
    {
      enemyScore++;
      Instance.textPointEnemy.text = enemyScore.ToString();
      Instance.CheckWin();
    }

    public void CheckWin()
{
    if (enemyScore >= winPoints || playerScore >= winPoints)
    {
       //ResetGame();
       EndGame();
    }
}
   
   public void EndGame()
   {
     screenEndGame.SetActive(true);
     string winner = saveController.Instance.GetName(playerScore > enemyScore);
     textEndGame.text = "Vitória " + winner;
     saveController.Instance.SaveWinner(winner);
     Invoke("LoadMenu", 2f);
   }

   private void LoadMenu()
   {
    SceneManager.LoadScene("Menu");
   }

}
