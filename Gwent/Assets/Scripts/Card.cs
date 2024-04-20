using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card //Creando mi clase carta que contendra todas las caracteristicas comunes de las cartas
{
    public int id;
    public string cardName;
    public string cardType;
    public int cardEffect;
    public int power;
    public string attackType;
    //Los numeros asociados a los efectos de las cartas estan en el readme
    public Card()
    {

    }

    public Card(int Id, string CardName, string CardType, int CardEffect,int power , string attackType) //Metodo contructor de esta clase
    {
        this.id = Id;
        this.cardName = CardName;
        this.cardType = CardType;
        this.cardEffect = CardEffect;
        this.power = power;
        this.attackType = attackType;
    }   
}
