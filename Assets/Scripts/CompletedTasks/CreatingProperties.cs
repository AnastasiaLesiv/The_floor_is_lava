using System;
using UnityEngine;

namespace MainPlayer.UnityEngine
{
    public class PlayerMovement : PlayerTransform
    {
        [SerializeField] private float runSpeed = 3f;
        [SerializeField] private float jumpImpulse = 10f;
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
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * JumpImpulse, ForceMode.Impulse);
            }
        }
    }
}