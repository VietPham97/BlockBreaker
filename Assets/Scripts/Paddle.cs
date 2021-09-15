using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField]
    private float screenWidthInUnits = 16f;
    [SerializeField]
    private float minX = 1f;
    [SerializeField]
    private float manX = 15f;

    private float positionY = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosXInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, positionY);
        paddlePos.x = Mathf.Clamp(mousePosXInUnits, minX, manX);
        transform.position = paddlePos;
    }
}
