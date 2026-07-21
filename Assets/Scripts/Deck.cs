using MLPCardGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MLPCardGame
{
    [CreateAssetMenu(fileName = "New Deck", menuName = "ScriptableObject/Deck")]
    public class Deck : ScriptableObject
    {
        public string deckName;

        public List<Card> characterCards;
        public List<Card> mainDeckCards;
        public List<Card> storyCards;
        public List<Card> sceneCards;
    }
}

