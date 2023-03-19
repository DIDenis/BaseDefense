using BaseDefense.BroadcastMessages.Messages.UpdateCurrencyMessages;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BaseDefense.UI.BuyButtons {

    [RequireComponent(typeof(Button))]
    public abstract class BuyButton : MonoBehaviour {

        [SerializeField]
        protected int price;

        [SerializeField]
        protected TextMeshProUGUI priceView;

        private Button m_thisButton;


        protected virtual void Awake () {
            m_thisButton = GetComponent<Button>();
        }


        protected void Check (UpdateCurrencyMessage message) {
            m_thisButton.interactable = message.Value > price;
        }

    }

}