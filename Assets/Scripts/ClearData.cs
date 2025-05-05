using UnityEngine;

public class ClearData : MonoBehaviour
{
    public void ResetData()
    {
        saveController.Instance.ClearSave();
    }
}
