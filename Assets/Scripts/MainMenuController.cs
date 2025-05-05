using UnityEngine;
using TMPro;

public class MainMenuController : MonoBehaviour
{

    public TextMeshProUGUI uiWinner;
    
    void Start()
    {
        saveController.Instance.Reset();
        string lastWinner = saveController.Instance.GetLastWinner();

        if (lastWinner != "")
           uiWinner.text = "Jogador da Partida: " + lastWinner;
        else
           uiWinner.text = "";
    }

}
