using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Посилання на об'єкт, за яким слідує камера
    public float smoothSpeed = 0.125f; // Параметр плавності
    public Vector3 offset; // Відстань між камерою та персонажем

    void LateUpdate()
    {
        // Перевіряємо, чи вказаний об'єкт існує
        if (target != null)
        {
            // Вираховуємо нову позицію камери з плавним переходом
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            
            // Встановлюємо позицію камери
            transform.position = smoothedPosition;
        }
    }
}
