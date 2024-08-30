using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target;  // El transform del jugador
    public float smoothSpeed = 0.125f;  // Qué tan suave se mueve la cámara
    public Vector3 offset;  // Offset de la cámara respecto al jugador

    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("Camera target not set!");
            return;
        }

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Opcional: hacer que la cámara mire siempre al jugador
        // transform.LookAt(target);
    }
}