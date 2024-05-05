using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();

    public int x;
    public int deckSize = 40;

    private Card tmp = new Card();

    void Start()
    {
        x = 0;

        for (int i = 0; i < deckSize; i++)
        {
            x = Random.Range(0, 4);
            deck[i] = CardDatabase.cardList[x];
        }

    }

    void Update()
    {

    }

    public void Shuffle()
    {
        for (int i = 0; i < deckSize; i++)
        {
            int randomIdx = Random.Range(i, deckSize);
            tmp = deck[i];
            deck[i] = deck[randomIdx];
            deck[randomIdx] = tmp;
        }
    }

}
