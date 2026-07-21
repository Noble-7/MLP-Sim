using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
namespace MLPCardGame
{
    public class CardDataHolder : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public Card cardData;
        public Image cardImage;

        public void InitializeCard(Card _cardData)
        {
            cardData = _cardData;
            cardImage.sprite = cardData.cardArt;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            GameManager.Instance.ShowCardPreview(cardData);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            GameManager.Instance.HideCardPreview();
        }
    }
}

