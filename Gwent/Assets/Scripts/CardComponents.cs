using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardComponents : MonoBehaviour
{
    public int componentId;

    public int id;
    public string cardName;
    public string cardType;
    public int cardEffect;
    public int power;
    public string attackType;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        id = CardDatabase.Cards[componentId].id;
        cardName = CardDatabase.Cards[componentId].cardName;
        cardType = CardDatabase.Cards[componentId].cardType;
        cardEffect = CardDatabase.Cards[componentId].cardEffect;
        power = CardDatabase.Cards[componentId].power; 
        attackType = CardDatabase.Cards[componentId].attackType;
    }
}
