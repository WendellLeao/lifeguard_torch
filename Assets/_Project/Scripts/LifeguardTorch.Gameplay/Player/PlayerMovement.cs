using UnityEngine;

namespace LifeguardTorch.Gameplay.Player
{
    public sealed class PlayerMovement : Player
    {
        [SerializeField] private float _moveSpeed;

        private float _horizontalMovement;
        
        protected override void Update()
        {
            base.Update();

            SetHorizontalMovement(Input.GetAxis("Horizontal"));
        }

        protected override void FixedUpdate()
        {
            base.FixedUpdate();

            HandleMovement();
        }
        
        private void HandleMovement()
        {
            GetRigidbody.velocity = new Vector2(_horizontalMovement * _moveSpeed, GetRigidbody.velocity.y);
        }

        private void SetHorizontalMovement(float movement)
        {
            _horizontalMovement = movement;
        }
    }
}
