using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public List<Card> Deck;
    public GameObject Hand1;
    // Start is called before the first frame update
    void Start()
    {   
       for (int i = 0; i < CardDatabase.Coc.Count; i++)
       {
           Deck[i]= CardDatabase.Coc[i];
       }
       
       
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
