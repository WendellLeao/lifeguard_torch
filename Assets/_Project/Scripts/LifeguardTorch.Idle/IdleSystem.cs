using UnityEngine;

namespace LifeguardTorch.Idle
{
    public sealed class IdleSystem : MonoBehaviour
    {
        [Header("Managers")]
        [SerializeField] private MenuManager _menuManager;
        
        private void Awake()
        {
            _menuManager.Setup();
        }

        private void OnDestroy()
        {
            _menuManager.Dispose();
        }

        private void Update()
        {
            _menuManager.Tick(Time.deltaTime);
        }

        private void FixedUpdate()
        {
            _menuManager.FixedTick(Time.fixedDeltaTime);
        }
    }
}
