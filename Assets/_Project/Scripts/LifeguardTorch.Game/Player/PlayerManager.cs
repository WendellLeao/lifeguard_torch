using UnityEngine;

namespace LifeguardTorch.Game.Player
{
    public sealed class PlayerManager : MonoBehaviour
    {
        [SerializeField] private PlayerMovement _playerMovement;
        [SerializeField] private PlayerJump _playerJump;
        
        public void Setup()
        {
            _playerMovement.Setup();
            _playerJump.Setup();
        }

        public void Dispose()
        {
            _playerMovement.Dispose();
            _playerJump.Dispose();
        }

        public void Tick(float deltaTime)
        {
            _playerMovement.Tick(deltaTime);
            _playerJump.Tick(deltaTime);
        }

        public void FixedTick(float fixedDeltaTime)
        {
            _playerMovement.FixedTick(fixedDeltaTime);
            _playerJump.FixedTick(fixedDeltaTime);
        }
    }
}
