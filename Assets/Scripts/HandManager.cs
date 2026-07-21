using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLPCardGame;

public class HandManager : MonoBehaviour
{
    public Deck deck;

    private List<Card> mainDeckHolder;
    private List<Card> sceneDeckHolder;


    public GameObject card;
    public Transform handTransform; //The position of the player's hand
    public Transform sceneAreaTransform;

    public float fanSpread = 5f;
    public float startingHandAmount = 5f;
    public List<GameObject> cardsInHand = new List<GameObject>(); //List of card game objects in hand
    public List<GameObject> cardsInSceneArea = new List<GameObject>(); //List of scene card game objects in hand

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
        mainDeckHolder = new List<Card>(deck.mainDeckCards);
        sceneDeckHolder = new List<Card>(deck.sceneCards);
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
        int num = Random.Range(0, mainDeckHolder.Count - 1);
        newCard.GetComponent<CardDataHolder>().InitializeCard(mainDeckHolder[num]);
        mainDeckHolder.RemoveAt(num);

        cardsInHand.Add(newCard);

        UpdateHandVisuals();
    }

    public void DrawSceneCard()
    {
        //create card object
        GameObject newCard = Instantiate(card, sceneAreaTransform.position, Quaternion.identity, sceneAreaTransform);

        //generate random number from deck and grab card from main deck holder to give data to card object
        int num = Random.Range(0, sceneDeckHolder.Count - 1);
        newCard.GetComponent<CardDataHolder>().InitializeCard(sceneDeckHolder[num]);
        sceneDeckHolder.RemoveAt(num);

        cardsInSceneArea.Add(newCard);
    }

    public void UpdateHandVisuals()
    {
        int cardCount = cardsInHand.Count;
        for(int i = 0; i < cardCount; i++)
        {
            float rotationAngle = (-fanSpread * (i - (cardCount - 1)/ 2f));
            cardsInHand[i].transform.localRotation = Quaternion.Euler(0f, 0f, rotationAngle);

        }
    }
}
