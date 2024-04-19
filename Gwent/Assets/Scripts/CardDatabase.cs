using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cards = new List<Card>();// Una lista donde vamos a almacenar las cartas del juego

    void Awake()
    {
        //Añadiendo las difererntes cartas
        cards.Add(new Card(1,"Reina Arquera","Líder", "Mantener una carta aleatoria en el campo entre ronda y ronda"));
        cards.Add(new Card(19, "Rey", "Líder", "Roba una carta extra en la segunda ronda"));
        cards.Add(new Hero(2,"Pekka","Elimina la carta con más poder del campo(propio o del rival)",9,"(M)"));
    }
}
