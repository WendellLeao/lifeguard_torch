using UnityEngine;

namespace LifeguardTorch.Game
{
    public sealed class GameManager : MonoBehaviour
    {
        private GameState _gameState;

        public void Setup()
        {
            _gameState = GameState.Playing;

            Debug.Log($"Game State {_gameState}");
        }

        public void Dispose()
        { }

        public void Tick(float deltaTime)
        { }
		
        public void FixedTick(float fixedDeltaTime)
        { }
    }
}
