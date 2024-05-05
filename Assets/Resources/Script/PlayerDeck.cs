using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public static List<Card> staticDeck = new List<Card>();
    private Card tmp = new Card();

    public int x;
    public static int deckSize = 40;
    public float DrawingWaitingTime = 0.5f;

    public GameObject CardToHand;
    public GameObject[] Clones;
    public GameObject Hand;


    void Start()
    {
        x = 0;
        deckSize = 40;
        for (int i = 0; i < deckSize; i++)
        {
            x = Random.Range(0, 4);
            deck[i] = CardDatabase.cardList[x];
        }

        StartCoroutine(StartGame());
    }

    void Update()
    {
        staticDeck = deck;

        if(TurnSystem.startTurn)
        {
            StartCoroutine(Draw(1));
            TurnSystem.startTurn = false;
        }

    }

    IEnumerator StartGame()//Draw 5 Cards
    {
        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(DrawingWaitingTime);

            Instantiate(CardToHand, transform.position, transform.rotation);
        }
        //Debug.Log("deckSize" + deckSize);
    }

    public void Shuffle()//Draw Deck
    {
        for (int i = 0; i < deckSize; i++)
        {
            int randomIdx = Random.Range(i, deckSize);
            tmp = deck[i];
            deck[i] = deck[randomIdx];
            deck[randomIdx] = tmp;
        }
    }

    IEnumerator Draw(int x)//Draw Cards
    {
        for (int i = 0; i < x; i++)
        {
            yield return new WaitForSeconds(DrawingWaitingTime);

            Instantiate(CardToHand, transform.position, transform.rotation);
        }
        //Debug.Log("deckSize" + deckSize);
    }
}
