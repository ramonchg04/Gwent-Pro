using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> Cards = new List<Card>();// Una lista donde vamos a almacenar las cartas del juego

    void Awake()
    {

        Cards.Add(new Card(1,"Reina Arquera","Líder", "Mantener una carta aleatoria en el campo entre ronda y ronda"));   
    
    }
}
