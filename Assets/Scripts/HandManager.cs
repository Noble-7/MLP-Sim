using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLPCardGame;

public class HandManager : MonoBehaviour
{
    public Deck deck;

    public List<Card> mainDeckHolder;


    public GameObject card;
    public Transform handTransform; //The position of the player's hand

    public float fanSpread = 5f;
    public float startingHandAmount = 5f;
    public List<GameObject> cardsInHand = new List<GameObject>(); //List of card game objects in hand

    // Start is called before the first frame update
    void Start()
    {
        //AddCardToHand();
        //AddCardToHand();
        //AddCardToHand();
        //AddCardToHand();
        BeginMatch();
    }

    public void BeginMatch()
    {
        mainDeckHolder = deck.mainDeckCards;
        //draw starting hand
        for (int i = 1; i <= startingHandAmount; i++)
        {
            AddCardToHand();

        }
    }


    public void AddCardToHand()
    {
        //create card object
        GameObject newCard = Instantiate(card, handTransform.position, Quaternion.identity, handTransform);

        //generate random number from deck and grab card from main deck holder to give data to card object
        int num = Random.Range(0, mainDeckHolder.Count);
        newCard.GetComponent<CardDataHolder>().InitializeCard(mainDeckHolder[num]);
        mainDeckHolder.RemoveAt(num);

        cardsInHand.Add(newCard);

        UpdateHandVisuals();
    }

    public void UpdateHandVisuals()
    {
        int cardCount = cardsInHand.Count;
        for(int i = 0; i < cardCount; i++)
        {
            float rotationAngle = (fanSpread * (i - (cardCount - 1)/ 2f));
            cardsInHand[i].transform.localRotation = Quaternion.Euler(0f, 0f, rotationAngle);

        }
    }
}
