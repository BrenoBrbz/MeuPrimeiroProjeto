using UnityEngine;
using UnityEngine.UI;

public class ColorSelectionButton : MonoBehaviour
{
    public Button uiButton;
    public Image paddleReference;

    public bool isColorPlayer = false;

    public void OnButtonClick()
    {
        paddleReference.color = uiButton.colors.normalColor;

        if (isColorPlayer)
        {
            saveController.Instance.colorPlayer = paddleReference.color;
        }
        else
        {
            saveController.Instance.colorEnemy = paddleReference.color;
        }
    }
}