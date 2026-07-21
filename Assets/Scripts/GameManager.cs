using MLPCardGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance is null)
            {
                Debug.LogError("GameManager is NULL");
            }

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public GameObject cardPreview;

    public void ShowCardPreview(Card card)
    {
        cardPreview.SetActive(true);
        cardPreview.GetComponent<Image>().sprite = card.cardArt;
    }

    public void HideCardPreview()
    {
        cardPreview.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
