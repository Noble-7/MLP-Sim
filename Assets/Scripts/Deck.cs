using MLPCardGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Deck", menuName = "Deck")]
public class Deck : MonoBehaviour
{
    public string deckName;

    public List<Card> characterCards;
    public List<Card> mainDeckCards;
    public List<Card> storyCards;
    public List<Card> sceneCards;
}
