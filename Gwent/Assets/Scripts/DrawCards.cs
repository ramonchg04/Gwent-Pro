using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject Card3;
    public GameObject Hand1;
    // Start is called before the first frame update
    void Start()
    {   
        List<GameObject> list = new List<GameObject>();//Creo una lista de las cartas a repartir
        list.Add(Card1);
        list.Add(Card2);
        list.Add(Card3);
        foreach(GameObject card in list)//las reccorro y las reparto 
        {
            GameObject card1 = Instantiate(card, new Vector3(0f, 0f, 0f), Quaternion.identity);//instancio cada carta que reparto
            card1.transform.SetParent(Hand1.transform, false);//aqui establezco que se repartan la mano donde cree un grid layout para agruparlas
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
