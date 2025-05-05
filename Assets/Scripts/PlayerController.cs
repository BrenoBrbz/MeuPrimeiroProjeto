using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float speed = 5f;

    public string movementAxisName = "Vertical";

    public bool isPlayer = true;
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        if (isPlayer)
        spriteRenderer.color = saveController.Instance.colorPlayer;
        else
        spriteRenderer.color = saveController.Instance.colorEnemy;
    }

    void Update()
    {
        float moveInput = Input.GetAxis(movementAxisName);
        Vector3 newPosition = transform.position + Vector3.up * moveInput * speed * Time.deltaTime;
        newPosition.y = Mathf.Clamp(newPosition.y, - 4.5f, 4.5f);
        transform.position = newPosition;
        
    }
}
