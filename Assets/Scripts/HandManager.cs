using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLPCardGame;
using System;

public class HandManager : MonoBehaviour
{

    public GameObject card;
    public Transform handTransform; //The position of the player's hand

    public float fanSpread = 5f;
    public List<GameObject> cardsInHand = new List<GameObject>(); //List of card game objects in hand

    // Start is called before the first frame update
    void Start()
    {
        AddCardToHand();
        AddCardToHand();
        AddCardToHand();
        AddCardToHand();
        AddCardToHand();
    }

    public void AddCardToHand()
    {
        GameObject newCard = Instantiate(card, handTransform.position, Quaternion.identity, handTransform);
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
