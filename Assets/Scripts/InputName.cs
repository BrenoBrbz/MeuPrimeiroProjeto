using UnityEngine;
using TMPro;

public class InputName : MonoBehaviour
{
    
    public bool isPlayer;
    public TMP_InputField inputField;
    
    void Start()
    {
        inputField.onValueChanged.AddListener(UpdateName);
    }

    
    public void UpdateName(string name)
    {
        if (isPlayer)
        saveController.Instance.namePlayer = name;
        else
        saveController.Instance.nameEnemy = name;
    }
}
