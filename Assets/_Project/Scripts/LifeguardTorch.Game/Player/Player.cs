using UnityEngine;

namespace LifeguardTorch.Game.Player
{
    public abstract class Player : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody;

        [SerializeField] private BoxCollider2D _boxCollider;
        
        protected Rigidbody2D GetRigidbody => _rigidbody;
        
        protected BoxCollider2D GetBoxCollider => _boxCollider;
        
        public virtual void Setup()
        {
            Debug.Log("Player is setup");
        }
        
        public virtual void Dispose()
        { }

        public virtual void Tick(float deltaTime)
        { } 
        
        public virtual void FixedTick(float fixedDeltaTime)
        { }
    }
}
