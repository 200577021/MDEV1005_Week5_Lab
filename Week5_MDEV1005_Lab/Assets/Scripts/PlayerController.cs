using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed =5.0f;
    public GameObject beamPrefab;
    public Transform beamSpawnPoint;

    private Vector2 moveValue;

    private void Awake()
    {
        moveValue = Vector2.zero;   
    }

    private void Update()
    {
        Move();
    }
    public void OnMove(InputAction.CallbackContext ctx)
    {
        moveValue = ctx.ReadValue<Vector2>();
    }

    public void OnAttack(InputAction.CallbackContext ctx)
    {
        if(ctx.performed)
        {
            Instantiate(beamPrefab, beamSpawnPoint.position, beamSpawnPoint.rotation);

        }

    }
    private void Move()
    {

        transform.Translate(new Vector3(moveValue.x, moveValue.y, 0) * speed * Time.deltaTime);
    }
}
