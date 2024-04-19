using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cards = new List<Card>();// Una lista donde vamos a almacenar las cartas del juego

    void Awake()
    {
        //A�adiendo las difererntes cartas
        cards.Add(new Card(1,"Reina Arquera","L�der", "Mantener una carta aleatoria en el campo entre ronda y ronda"));
        cards.Add(new Card(19, "Rey", "L�der", "Roba una carta extra en la segunda ronda"));
        cards.Add(new Hero(2,"Pekka","Elimina la carta con m�s poder del campo(propio o del rival)",9,"(M)"));
    }
}
