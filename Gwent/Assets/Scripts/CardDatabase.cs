using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> Cards = new List<Card>();

    private void Awake()
    {
        Cards.Add(new Card(1,"Reina Arquera","Lider",1));
        Cards.Add(new Card(18, "Rey", "Lider", 2));
        Cards.Add(new Hero(2, "Pekka", 5, 9, "M"));
        Cards.Add(new Hero(19, "Caballero Dorado", 4, 8, "M"));
        Cards.Add(new Silver(6, "Montapuercos", 6, 6, "M"));
        Cards.Add(new Card(11, "Montepuerco", "Clima", 8));

    }
}
