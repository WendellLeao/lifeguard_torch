using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

namespace LifeguardTorch.Idle
{
    public sealed class MenuManager : MonoBehaviour
    {
        [SerializeField] private Button _playButton;
        
        public void Setup()
        {
            _playButton.onClick.AddListener(PlayGame);
        }

        public void Dispose()
        {
            _playButton.onClick.RemoveListener(PlayGame);
        }

        public void Tick(float deltaTime)
        { }
		
        public void FixedTick(float fixedDeltaTime)
        { }

        private void PlayGame()
        {
            SceneManager.LoadScene("Level01");
        }
    }
}
