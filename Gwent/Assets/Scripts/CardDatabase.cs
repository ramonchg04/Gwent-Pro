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
        Coc.Add(new Card(1, "Reina Arquera", "Lider", 1, 0, "", Resources.Load<Sprite>("1-Reina Arquera")));
        Coc.Add(new Card(2, "Pekka","Heroe", 5, 9, "M", Resources.Load<Sprite>("2-Pekka")));
        Coc.Add(new Card(3, "Gran Centinela", "Heroe", 3, 7, "R", Resources.Load<Sprite>("3-Gran Centinela")));
        Coc.Add(new Card(4, "Rey Barbaro", "Heroe", 7, 8, "M", Resources.Load<Sprite>("4-Rey Barbaro")));
        Coc.Add(new Card(5, "Lanzarrocas", "Plata", 7, 4, "R", Resources.Load<Sprite>("5-Lanzarrocas")));
        Coc.Add(new Card(5, "Lanzarrocas", "Plata", 7, 4, "R", Resources.Load<Sprite>("5-Lanzarrocas")));
        Coc.Add(new Card(5, "Lanzarrocas", "Plata", 7, 4, "R", Resources.Load<Sprite>("5-Lanzarrocas")));
        Coc.Add(new Card(6, "Montapuercos", "Plata", 6, 6,"M", Resources.Load<Sprite>("6-Montapuercos")));
        Coc.Add(new Card(6, "Montapuercos", "Plata", 6, 6, "M", Resources.Load<Sprite>("6-Montapuercos")));
        Coc.Add(new Card(6, "Montapuercos", "Plata", 6, 6, "M", Resources.Load<Sprite>("6-Montapuercos")));
        Coc.Add(new Card(7, "Bruja", "Plata", 5, 6, "R",Resources.Load<Sprite>("7-Bruja")));
        Coc.Add(new Card(7, "Bruja", "Plata", 5, 6, "R", Resources.Load<Sprite>("7-Bruja")));
        Coc.Add(new Card(7, "Bruja", "Plata", 5, 6, "R", Resources.Load<Sprite>("7-Bruja")));
        Coc.Add(new Card(8, "Lanzatroncos", "Plata", 4, 4, "S", Resources.Load<Sprite>("8-Lanzatroncos")));
        Coc.Add(new Card(8, "Lanzatroncos", "Plata", 4, 4, "S", Resources.Load<Sprite>("8-Lanzatroncos")));
        Coc.Add(new Card(8, "Lanzatroncos", "Plata", 4, 4, "S", Resources.Load<Sprite>("8-Lanzatroncos")));
        Coc.Add(new Card(9, "Arrojapiedras", "Plata", 6, 7, "S", Resources.Load<Sprite>("9-ArrojaPiedras")));
        Coc.Add(new Card(9, "Arrojapiedras", "Plata", 6, 7, "S", Resources.Load<Sprite>("9-ArrojaPiedras")));
        Coc.Add(new Card(9, "Arrojapiedras", "Plata", 6, 7, "S", Resources.Load<Sprite>("9-ArrojaPiedras")));
        Coc.Add(new Card(10, "Hechizo de Rayo", "Clima", 9, 0, "", Resources.Load<Sprite>("10-Hechizo de Rayo")));
        Coc.Add(new Card(11, "Montepuerco", "Clima", 8, 0, "", Resources.Load<Sprite>("11-Montepuerco")));
        Coc.Add(new Card(12, "Hechizo de Furia", "Aumento", 10, 0, "", Resources.Load<Sprite>("12-Hechizo de Furia")));
        Coc.Add(new Card(13, "Taller del Constructor", "Aumento", 10, 0, "", Resources.Load<Sprite>("13-Taller del Constructor")));
        Coc.Add(new Card(14, "Controlador aereo", "Despeje", 11, 0, "", Resources.Load<Sprite>("14-Controlador Aereo")));
        Coc.Add(new Card(15, "Tornado", "Despeje", 11, 0, "", Resources.Load<Sprite>("15-Tornado")));
        Coc.Add(new Card(16, "Duende", "Señuelo", 12, 0, "" , Resources.Load<Sprite>("16-Duende")));
        Coc.Add(new Card(17, "Esbirro", "Señuelo", 12, 0, "", Resources.Load<Sprite>("17-Esbirro")));

        //Creando el deck del Clash Royale
        Cr.Add(new Card(18, "Rey", "Lider", 2, 0, "", Resources.Load<Sprite>("18-Rey")));
        Cr.Add(new Card(19, "Caballero Dorado", "Heroe", 5, 8, "M", Resources.Load<Sprite>("19-Caballero Dorado")));
        Cr.Add(new Card(20, "Gigante electrico", "Heroe", 4, 10, "M", Resources.Load<Sprite>("20-Gigante Electrico")));
        Cr.Add(new Card(21, "Gigante Noble", "Heroe", 7, 7, "R", Resources.Load<Sprite>("21-Gigante Noble")));
        Cr.Add(new Card(22, "Lanzafuegos", "Plata", 7, 5, "R", Resources.Load<Sprite>("22-Lanzafuegos")));
        Cr.Add(new Card(22, "Lanzafuegos", "Plata", 7, 5, "R", Resources.Load<Sprite>("22-Lanzafuegos")));
        Cr.Add(new Card(22, "Lanzafuegos", "Plata", 7, 5, "R", Resources.Load<Sprite>("22-Lanzafuegos")));
        Coc.Add(new Card(6, "Montapuercos", "Plata", 6, 6, "M", Resources.Load<Sprite>("6-Montapuercos")));
        Coc.Add(new Card(6, "Montapuercos", "Plata", 6, 6, "M", Resources.Load<Sprite>("6-Montapuercos")));
        Coc.Add(new Card(6, "Montapuercos", "Plata", 6, 6, "M", Resources.Load<Sprite>("6-Montapuercos")));
        Cr.Add(new Card(23, "Globo Bombastico", "Plata", 5, 6, "S", Resources.Load<Sprite>("23-Globo Bombástico")));
        Cr.Add(new Card(23, "Globo Bombastico", "Plata", 5, 6, "S", Resources.Load<Sprite>("23-Globo Bombástico")));
        Cr.Add(new Card(23, "Globo Bombastico", "Plata", 5, 6, "S", Resources.Load<Sprite>("23-Globo Bombástico")));
        Cr.Add(new Card(24, "Mosquetera", "Plata", 3, 4, "R", Resources.Load<Sprite>("24-Mosquetera")));
        Cr.Add(new Card(24, "Mosquetera", "Plata", 3, 4, "R", Resources.Load<Sprite>("24-Mosquetera")));
        Cr.Add(new Card(24, "Mosquetera", "Plata", 3, 4, "R", Resources.Load<Sprite>("24-Mosquetera")));
        Cr.Add(new Card(25, "Cañon con Ruedas", "Plata", 6, 5, "S", Resources.Load<Sprite>("25-Cañon con Ruedas")));
        Cr.Add(new Card(25, "Cañon con Ruedas", "Plata", 6, 5, "S", Resources.Load<Sprite>("25-Cañon con Ruedas")));
        Cr.Add(new Card(25, "Cañon con Ruedas", "Plata", 6, 5, "S", Resources.Load<Sprite>("25-Cañon con Ruedas")));
        Coc.Add(new Card(10, "Hechizo de Rayo", "Clima", 9, 0, "", Resources.Load<Sprite>("10-Hechizo de Rayo")));
        Coc.Add(new Card(11, "Montepuerco", "Clima", 8, 0, "", Resources.Load<Sprite>("11-Montepuerco")));
        Cr.Add(new Card(26, "Arena Real", "Aumento", 10, 0, "", Resources.Load<Sprite>("26-Arena real")));
        Coc.Add(new Card(13, "Taller del Constructor", "Aumento", 10, 0, "", Resources.Load<Sprite>("13-Taller del Constructor")));
        Cr.Add(new Card(27, "Espiritu de Fuego", "Despeje", 11, 0, "", Resources.Load<Sprite>("27-Espiritu de Fuego")));
        Coc.Add(new Card(15, "Tornado", "Despeje", 11, 0, "", Resources.Load<Sprite>("15-Tornado")));
        Coc.Add(new Card(16, "Duende", "Señuelo", 12, 0, "", Resources.Load<Sprite>("16-Duende")));
        Coc.Add(new Card(17, "Esbirro", "Señuelo", 12, 0, "", Resources.Load<Sprite>("17-Esbirro")));
    }

}
