using System;
using UnityEngine;
using UnityEngine.UI;

namespace HomeWork4.Exercise3
{
    [RequireComponent(typeof(Button))]
    public class LevelSelectionButton : MonoBehaviour
    {
        public event Action<RuleType> Click;

        [SerializeField] private RuleType _ruleType;
        private Button _button;

        public RuleType RuleType => _ruleType;

        private void Awake() => _button = GetComponent<Button>();

        private void OnEnable() => _button.onClick.AddListener(OnClick);

        private void OnDisable() => _button.onClick.RemoveListener(OnClick);

        private void OnClick() => Click?.Invoke(_ruleType);
    }
}