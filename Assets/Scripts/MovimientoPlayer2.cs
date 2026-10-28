using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoPlayer2 : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 movimiento;
    public void OnMoveArrows(InputValue value)
    {
        movimiento = value.Get<Vector2>();
        if (movimiento.x != 0)
        {
            movimiento.y = 0;
        }
        movimiento.Normalize();
    }

    void Update()
    {
        if (movimiento != Vector2.zero)
        {
            transform.right = movimiento;
        }
        transform.Translate(Vector3.right * movimiento.x * speed * Time.deltaTime, Space.World);
        transform.Translate(Vector3.up * movimiento.y * speed * Time.deltaTime, Space.World);
    }
}
