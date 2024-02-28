using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float runSpeed = 15f;
    [SerializeField] private float jumpImpulse = 25f;
    private bool hasJumped = false;
    private Rigidbody rb;

    public float JumpImpulse
    {
        get => jumpImpulse;
        set => jumpImpulse = value;
    }

    public float RunSpeed
    {
        get => runSpeed;
        set => runSpeed = value;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * RunSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && !hasJumped)
        {
            Jump();
        }
    }
    void Jump()
    {
        // Додаємо силу стрибка до ригідного тіла персонажа
        GetComponent<Rigidbody>().AddForce(Vector3.up * JumpImpulse, ForceMode.Impulse);

        // Встановлюємо флаг "пригав"
        hasJumped = true;
    }

    // Метод, який визивається, коли персонаж торкається землі
    void OnCollisionEnter(Collision collision)
    {
        // Якщо персонаж торкається землі, скидаємо флаг "пригав"
        hasJumped = false;
    }
}


