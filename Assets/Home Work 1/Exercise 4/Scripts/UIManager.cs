using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace HomeWork1.Exercise4
{
    public class UIManager : MonoBehaviour
    {
        public Action<BallColors> StartOneColorBurstGameEvent;
        public Action StartAllBurstGameButtonEvent;

        [SerializeField] private GameObject _uiPanel;
        [SerializeField] private Button _startOneColorBurstGameButton;
        [SerializeField] private Button _startAllBurstGameButton;
        [SerializeField] private ToggleGroup _toggleGroupColors;

        public void Initialize()
        {
            _startOneColorBurstGameButton.onClick.AddListener(() => StartOneColorBurstGameEvent?.Invoke(GetSelectedToggleColor()));
            _startAllBurstGameButton.onClick.AddListener(() => StartAllBurstGameButtonEvent?.Invoke());
        }

        public void SetVisiblePanel(bool isVisible) => _uiPanel.SetActive(isVisible);

        private BallColors GetSelectedToggleColor()
        {
            if (_toggleGroupColors.ActiveToggles().FirstOrDefault().TryGetComponent(out ToggleColors toggleColor))
            {
                return toggleColor.ToggleBallColor;
            }
            else throw new NullReferenceException(nameof(toggleColor));
        }
    }
}

