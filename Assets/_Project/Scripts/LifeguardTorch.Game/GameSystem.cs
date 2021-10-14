using UnityEngine;

namespace LifeguardTorch.Game
{
    public sealed class GameSystem : MonoBehaviour
    {
        [Header("Managers")]
        [SerializeField] private GameManager _gameManager;
        [SerializeField] private Player.PlayerManager _playerManager;

        private void Awake()
        {
            _gameManager.Setup();
            _playerManager.Setup();
        }

        private void OnDestroy()
        {
            _gameManager.Dispose();
            _playerManager.Dispose();
        }

        private void Update()
        {
            _gameManager.Tick(Time.deltaTime);
            _playerManager.Tick(Time.deltaTime);
        }

        private void FixedUpdate()
        {
            _gameManager.FixedTick(Time.fixedDeltaTime);
            _playerManager.FixedTick(Time.fixedDeltaTime);
        }
    }
}
