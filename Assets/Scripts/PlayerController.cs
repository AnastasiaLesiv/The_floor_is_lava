using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody), typeof(AudioSource))]
public class PlayerController : MonoBehaviour

{
    public AudioSource[] sounds;
    [SerializeField] private float runSpeed = 15f;
    [SerializeField] private float jumpImpulse = 25f;
    private bool hasJumped = false;
    private Rigidbody rb;
    private bool checkDetection = false;
    [Range(0, 1)] public float volume;
    public bool randomJumpSound = false;

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
        if (Input.GetKeyDown(KeyCode.X) && !hasJumped)
        {
            Jump();
        }

        if (transform.position.y <= -12 && !checkDetection)
        {
            sounds[1].PlayOneShot(sounds[1].clip, volume);
            checkDetection = true;
            RestartGameWithDelay(2);
        }
    }
    void Jump()
    {
        rb.AddForce(Vector3.up * JumpImpulse, ForceMode.Impulse);
        hasJumped = true;
        sounds[0].pitch = randomJumpSound ? Random.Range(0.5f, 1.2f) : 1;
        sounds[0].PlayOneShot(sounds[0].clip, volume);
    }

    // Метод, який визивається, коли персонаж торкається землі
    void OnCollisionEnter(Collision collision)
    {
        // Якщо персонаж торкається землі, скидаємо флаг "пригав"
        hasJumped = false;
        if (collision.gameObject.CompareTag("Finish"))
        {
            sounds[2].PlayOneShot(sounds[2].clip, volume);
            sounds[3].PlayDelayed(0.5f);
            RestartGameWithDelay(2);
            
        }
    }
    public void RestartGameWithDelay(float delay)
    {
        // Викликаємо метод RestartGame через вказаний час delay
        Invoke("RestartGame", delay);
    }

    private void RestartGame()
    {
        // Отримуємо індекс поточної сцени
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Завантажуємо поточну сцену знову, щоб перезапустити гру
        SceneManager.LoadScene(currentSceneIndex);
    }
}


