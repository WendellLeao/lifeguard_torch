using UnityEngine;

namespace LifeguardTorch.Game.Player
{
    public sealed class PlayerMovement : Player
    {
        [SerializeField] private float _moveSpeed;

        private float _horizontalMovement;
        
        public override void Tick(float deltaTime)
        {
            base.Tick(deltaTime);
            
            SetHorizontalMovement(Input.GetAxis("Horizontal"));
        }
        
        public override void FixedTick(float deltaTime)
        {
            base.FixedTick(deltaTime);
            
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
