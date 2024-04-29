using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocComponents : MonoBehaviour
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

        id = CardDatabase.Coc[componentId].id;
        cardName = CardDatabase.Coc[componentId].cardName;
        cardType = CardDatabase.Coc[componentId].cardType;
        cardEffect = CardDatabase.Coc[componentId].cardEffect;
        power = CardDatabase.Coc[componentId].power;
        attackType = CardDatabase.Coc[componentId].attackType;
        cardImage = CardDatabase.Coc[componentId].cardImage;
    }
}
