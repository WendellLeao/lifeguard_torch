using UnityEngine;

namespace LifeguardTorch.Gameplay.Player
{
    public sealed class PlayerJump : Player
    {
        [SerializeField] private float _jumpForce;

        [SerializeField] private float _rayDistance = 0.06f;

        [SerializeField] private LayerMask _whatIsGround;
        
        private bool _isJumping = false;
        
        protected override void Update()
        {
            base.Update();

            _isJumping = Input.GetKeyDown(KeyCode.Space);
        }

        protected override void FixedUpdate()
        {
            base.FixedUpdate();

            HandleJump();
        }

        private void HandleJump()
        {
            if (_isJumping && IsGrounded())
            {
                _isJumping = false;
                
                GetRigidbody.AddForce(new Vector2(GetRigidbody.velocity.x, _jumpForce));
            }
        }
        
        private bool IsGrounded()
        {
            Bounds bounds = GetBoxCollider.bounds;
            
            Vector2 origin = bounds.center;
            Vector2 size = bounds.size;
            
            RaycastHit2D raycastHit = Physics2D.BoxCast(origin, size, 0f, Vector2.down, _rayDistance, _whatIsGround);

            return raycastHit.collider != null;
        }
    }
}
