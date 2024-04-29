using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrComponents : MonoBehaviour
{
    public int componentId;

    public int id;
    public string cardName;
    public string cardType;
    public int cardEffect;
    public int power;
    public string attackType;
    public Sprite cardImage;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        id = CardDatabase.Cr[componentId].id;
        cardName = CardDatabase.Cr[componentId].cardName;
        cardType = CardDatabase.Cr[componentId].cardType;
        cardEffect = CardDatabase.Cr[componentId].cardEffect;
        power = CardDatabase.Cr[componentId].power;
        attackType = CardDatabase.Cr[componentId].attackType;
        cardImage = CardDatabase.Cr[componentId].cardImage;
    }
}
