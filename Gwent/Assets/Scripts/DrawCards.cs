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
        List<GameObject> list = new List<GameObject>();
        list.Add(Card1);
        list.Add(Card2);
        list.Add(Card3);
        foreach(GameObject card in list)
        {
            GameObject card1 = Instantiate(card, new Vector3(0f, 0f, 0f), Quaternion.identity);
            card1.transform.SetParent(Hand1.transform, false);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
