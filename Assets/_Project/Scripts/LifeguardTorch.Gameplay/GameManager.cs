using UnityEngine;

namespace LifeguardTorch.Gameplay
{
    public sealed class GameManager : MonoBehaviour
    {
        private GameState _gameState;

        private void Awake()
        {
            _gameState = GameState.Playing;

            Debug.Log($"Game State {_gameState}");
        }
    }
}
