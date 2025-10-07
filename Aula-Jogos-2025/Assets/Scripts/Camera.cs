using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform target;         // O player
    public float smoothSpeed = 5f;   // Velocidade da c�mera
    public Vector3 offset = new Vector3(0f, 0f, -10f); // Mant�m a c�mera atr�s da cena

    void LateUpdate()
    {
        if (target == null) return;

        // Posi��o desejada (posi��o do player + offset)
        Vector3 desiredPosition = new Vector3(target.position.x + offset.x, target.position.y + offset.y, offset.z);

        // Movimento suave
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
    }
}