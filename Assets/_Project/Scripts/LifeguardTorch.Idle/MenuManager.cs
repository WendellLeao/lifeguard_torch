using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

namespace LifeguardTorch.Idle
{
    public sealed class MenuManager : MonoBehaviour
    {
        [SerializeField] private Button _playButton;
        
        private void Awake()
        {
            _playButton.onClick.AddListener(PlayGame);
        }

        private void OnDisable()
        {
            _playButton.onClick.RemoveListener(PlayGame);
        }

        private void PlayGame()
        {
            SceneManager.LoadScene("Level01");
        }
    }
}
