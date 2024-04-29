using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> Coc = new List<Card>();
    public static List<Card> Cr = new List<Card>();

    private void Awake()
    {
        //Creando el deck del Clash of Clans
        Coc.Add(new Card(1, "Reina Arquera", "Lider", 1, 0, ""));
        Coc.Add(new Card(2, "Pekka","Heroe", 5, 9, "M"));
        Coc.Add(new Card(3, "Gran Centinela", "Heroe", 3, 7, "R"));
        Coc.Add(new Card(4, "Rey Barbaro", "Heroe", 7, 8, "M"));
        Coc.Add(new Card(5, "Lanzarrocas", "Plata", 7, 4, "R"));
        Coc.Add(new Card(5, "Lanzarrocas", "Plata", 7, 4, "R"));
        Coc.Add(new Card(5, "Lanzarrocas", "Plata", 7, 4, "R"));
        Coc.Add(new Card(6, "Montapuercos", "Plata", 6, 6,"M"));
        Coc.Add(new Card(6, "Montapuercos", "Plata", 6, 6, "M"));
        Coc.Add(new Card(6, "Montapuercos", "Plata", 6, 6, "M"));
        Coc.Add(new Card(7, "Bruja", "Plata", 5, 6, "R"));
        Coc.Add(new Card(7, "Bruja", "Plata", 5, 6, "R"));
        Coc.Add(new Card(7, "Bruja", "Plata", 5, 6, "R"));
        Coc.Add(new Card(8, "Lanzatroncos", "Plata", 4, 4, "S"));
        Coc.Add(new Card(8, "Lanzatroncos", "Plata", 4, 4, "S"));
        Coc.Add(new Card(8, "Lanzatroncos", "Plata", 4, 4, "S"));
        Coc.Add(new Card(9, "Arrojapiedras", "Plata", 6, 7, "S"));
        Coc.Add(new Card(9, "Arrojapiedras", "Plata", 6, 7, "S"));
        Coc.Add(new Card(9, "Arrojapiedras", "Plata", 6, 7, "S"));
        Coc.Add(new Card(10, "Hechizo de Rayo", "Clima", 9, 0, ""));
        Coc.Add(new Card(11, "Montepuerco", "Clima", 8, 0, ""));
        Coc.Add(new Card(12, "Hechizo de Furia", "Aumento", 10, 0, ""));
        Coc.Add(new Card(13, "Taller del Constructor", "Aumento", 10, 0, ""));
        Coc.Add(new Card(14, "Controlador aereo", "Despeje", 11, 0, ""));
        Coc.Add(new Card(15, "Tornado", "Despeje", 11, 0, ""));
        Coc.Add(new Card(16, "Duende", "Señuelo", 12, 0, ""));
        Coc.Add(new Card(17, "Esbirro", "Señuelo", 12, 0, ""));

        //Creando el deck del Clash Royale
        Coc.Add(new Card(18, "Rey", "Lider", 2, 0, ""));
        Coc.Add(new Card(19, "Caballero Dorado", "Heroe", 5, 8, "M"));
        Coc.Add(new Card(20, "Gigante electrico", "Heroe", 4, 10, "M"));
        Coc.Add(new Card(21, "Gigante Noble", "Heroe", 7, 7, "R"));
        Coc.Add(new Card(22, "Lanzafuegos", "Plata", 7, 5, "R"));
        Coc.Add(new Card(22, "Lanzafuegos", "Plata", 7, 5, "R"));
        Coc.Add(new Card(22, "Lanzafuegos", "Plata", 7, 5, "R"));
        Coc.Add(new Card(6, "Montapuercos", "Plata", 6, 6, "M"));
        Coc.Add(new Card(6, "Montapuercos", "Plata", 6, 6, "M"));
        Coc.Add(new Card(6, "Montapuercos", "Plata", 6, 6, "M"));
        Coc.Add(new Card(23, "Globo Bombastico", "Plata", 5, 6, "S"));
        Coc.Add(new Card(23, "Globo Bombastico", "Plata", 5, 6, "S"));
        Coc.Add(new Card(23, "Globo Bombastico", "Plata", 5, 6, "S"));
        Coc.Add(new Card(24, "Mosquetera", "Plata", 3, 4, "R"));
        Coc.Add(new Card(24, "Mosquetera", "Plata", 3, 4, "R"));
        Coc.Add(new Card(24, "Mosquetera", "Plata", 3, 4, "R"));
        Coc.Add(new Card(25, "Cañon con Ruedas", "Plata", 6, 5, "S"));
        Coc.Add(new Card(25, "Cañon con Ruedas", "Plata", 6, 5, "S"));
        Coc.Add(new Card(25, "Cañon con Ruedas", "Plata", 6, 5, "S"));
        Coc.Add(new Card(10, "Hechizo de Rayo", "Clima", 9, 0, ""));
        Coc.Add(new Card(11, "Montepuerco", "Clima", 8, 0, ""));
        Coc.Add(new Card(26, "Arena Real", "Aumento", 10, 0, ""));
        Coc.Add(new Card(13, "Taller del Constructor", "Aumento", 10, 0, ""));
        Coc.Add(new Card(27, "Espiritu de Fuego", "Despeje", 11, 0, ""));
        Coc.Add(new Card(15, "Tornado", "Despeje", 11, 0, ""));
        Coc.Add(new Card(16, "Duende", "Señuelo", 12, 0, ""));
        Coc.Add(new Card(17, "Esbirro", "Señuelo", 12, 0, ""));
    }

}
