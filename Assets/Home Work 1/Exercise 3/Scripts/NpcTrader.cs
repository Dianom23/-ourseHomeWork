using UnityEngine;
using System;
using UnityEngine.UI;

namespace HomeWork1.Exercise3
{
    public class NpcTrader : MonoBehaviour
    {
        [SerializeField] private Button _tradeButton;
        private ITradeBehavior _tradeBehavior;
        private bool _isActiveTradeTrigger;
        private bool _isInit;

        private void Awake()
        {
            if (_tradeButton == null)
                throw new NullReferenceException(nameof(_tradeButton));
            else
                _tradeButton.gameObject.SetActive(false);

            _tradeButton.onClick.AddListener(OnTrade);
        }

        private void OnDisable() => _tradeButton.onClick.RemoveListener(OnTrade);

        private void Start()
        {
            if (_isInit == false)
                throw new InvalidOperationException(nameof(_isInit));
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Player _))
            {
                _isActiveTradeTrigger = true;
                SetVisibleTradeButton(true);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent(out Player _))
            {
                _isActiveTradeTrigger = false;
                SetVisibleTradeButton(false);
            }
        }

        public void Initialize(ITradeBehavior tradeBehavior)
        {
            SetTradePattern(tradeBehavior);
            _isInit = true;
        }

        public void SetTradePattern(ITradeBehavior tradeBehavior)
        {
            _tradeBehavior = tradeBehavior;
        }

        public void OnTrade()
        {
            if(_isActiveTradeTrigger == true)
                _tradeBehavior.Trade();
        }

        private void SetVisibleTradeButton(bool state)
        {
            _tradeButton.gameObject.SetActive(state);
        }
    }
}