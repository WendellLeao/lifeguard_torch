using UnityEngine;

namespace LifeguardTorch.Gameplay.Player
{
    public abstract class Player : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private BoxCollider2D _boxCollider;
        
        protected virtual void Update(){}
        protected virtual void FixedUpdate(){}
        
        protected Rigidbody2D GetRigidbody => _rigidbody;
        protected BoxCollider2D GetBoxCollider => _boxCollider;
    }
}
