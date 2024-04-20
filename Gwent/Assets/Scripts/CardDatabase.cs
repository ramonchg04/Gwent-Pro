using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> Cards = new List<Card>();

    private void Awake()
    {
        Cards.Add(new Card(1,"Reina Arquera","Lider",1,0,""));
        Cards.Add(new Card(2, "Rey", "Lider", 2, 0, ""));
        Cards.Add(new Card(3, "Pekka","Heroe", 5, 9, "M"));
        Cards.Add(new Card(4, "Rey Barbaro","Heroe", 7, 8, "M"));
        Cards.Add(new Card(5, "Gigante Eléctrico","Heroe", 4, 10, "M"));
        Cards.Add(new Card(6, "Caballero Dorado", "Heroe" ,5, 8, "M"));
        Cards.Add(new Card(7, "Bruja","Silver", 5, 6, "R"));
        Cards.Add(new Card(8, "Lanzafuegos","Silver", 7, 5, "R"));
        Cards.Add(new Card(9, "Montepuerco","Clima", 8,0,""));

    }

}
