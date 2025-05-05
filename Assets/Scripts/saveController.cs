using UnityEngine;
using UnityEngine.SceneManagement;

public class saveController : MonoBehaviour
{
    public Color colorPlayer = Color.white;
    public Color colorEnemy = Color.white;

    public string nameEnemy;
    public string namePlayer;

    private string saveWinnerKey;

    private static saveController _instance;

    public static saveController Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<saveController>();

                if (_instance == null)
                {
                    GameObject singletonObject = new GameObject(typeof(saveController).Name);
                    _instance = singletonObject.AddComponent<saveController>();

                }

            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
    }

      public string GetName(bool isPlayer)
      {
        return isPlayer ? namePlayer : nameEnemy;
      }

      public void Reset()
      {
        nameEnemy = "";
        namePlayer = "";
        colorEnemy = Color.white;
        colorPlayer = Color.white;
      }

       public void SaveWinner(string winner)
      {
        PlayerPrefs.SetString(saveWinnerKey, winner);

      }

      public string GetLastWinner()
      {
        return PlayerPrefs.GetString(saveWinnerKey);

      }

      public void ClearSave()
      {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      }
}