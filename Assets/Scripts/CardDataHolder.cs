using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace MLPCardGame
{
    public class CardDataHolder : MonoBehaviour
    {
        public Card cardData;
        public Image cardImage;

        public void InitializeCard(Card _cardData)
        {
            cardData = _cardData;
            cardImage.sprite = cardData.cardArt;
        }
    }
}

