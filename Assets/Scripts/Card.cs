using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MLPCardGame
{

    [CreateAssetMenu(fileName = "New Card", menuName = "ScriptableObject/Card")]
    public class Card : ScriptableObject
    {
        public string cardName;
        public CardType cardType;
        public int atk;
        public int cost;

        public Sprite cardArt;

        public enum CardType
        {
            Character,
            Event,
            Item,
            Story,
            Scene
        }

        
    }
}