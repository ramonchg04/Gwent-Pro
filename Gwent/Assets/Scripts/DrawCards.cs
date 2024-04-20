using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject Card3;
    public GameObject Card4;
    public GameObject Hand1;
    // Start is called before the first frame update
    void Start()
    {   
        List<GameObject> list = new List<GameObject>();//Creo una lista de las cartas a repartir
        list.Add(Card1);
        list.Add(Card2);
        list.Add(Card3);
        list.Add(Card4);
        int number = list.Count;
        for (int i=0;i<number-1;i++)//las reccorro y las reparto 
        {
            GameObject random = list[Random.Range(0, list.Count)];//Creo una variable gameobject para almacenar una carta randar que va a ser la que repartire
            GameObject card = Instantiate(random, new Vector3(0f, 0f, 0f), Quaternion.identity);//instancio cada carta que reparto
            card.transform.SetParent(Hand1.transform, false);//aqui establezco que se repartan en la mano donde cree un grid layout para agruparlas
            list.Remove(random);//elimino esa carta de la lista para mo repartirla de nuevo
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
