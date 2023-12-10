using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace HomeWork4.Exercise3
{
    public class RuleSelectionPanel : MonoBehaviour
    {
        [SerializeField] private LevelSelectionButton[] _selectionButtons;
        [SerializeField] private ToggleGroup _toggleSelectedColor;

        private ISceneLoadMediator _sceneLoader;

        [Inject]
        private void Construct(ISceneLoadMediator sceneLoadered)
            => _sceneLoader = sceneLoadered;

        private void Awake()
        {
            foreach (LevelSelectionButton button in _selectionButtons)
                button.Click += OnLevelSelected;
        }

        private void OnLevelSelected(RuleType ruleType)
            => _sceneLoader.GoToGameplayLevel(new LevelLoadingData(ruleType, GetSelectedToggleColor()));

        private BallColors GetSelectedToggleColor()
        {
            if (_toggleSelectedColor.ActiveToggles().FirstOrDefault().TryGetComponent(out ToggleColors toggleColor))
            {
                return toggleColor.ToggleBallColor;
            }
            else throw new NullReferenceException(nameof(toggleColor));
        }
    }
}