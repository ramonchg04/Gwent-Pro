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
    
    public Card()
    {

    }

    public Card(int Id, string CardName, string CardType, string CardEffect) //Metodo contructor de esta clase
    {
        this.id = Id;
        this.cardName = CardName;
        this.cardType = CardType;
        this.cardEffect = CardEffect;
    }   
}

public class Hero : Card//Creo la clase para las cartas de tipo heroe, que hereda de la clase carta
{
    public string attackType;
    public int power;

    public Hero(int Id, string CardName, string CardEffect,int Power, string AttackType) //Metodo contructor de esta clase
    {
        this.id = Id;
        this.cardName = CardName;
        this.cardType = "Héroe";
        this.cardEffect = CardEffect;
        this.power = Power;
        this.attackType = AttackType;
    }
}

public class Silver : Card//Creo la clase para las cartas de tipo plata, que hereda de la clase carta
{
    public string attackType;
    public int power;

    public Silver(int Id, string CardName, string CardType, string CardEffect, int Power, string AttackType) //Metodo contructor de esta clase
    {
        this.id = Id;
        this.cardName = CardName;
        this.cardType = "Plata";
        this.cardEffect = CardEffect;
        this.power = Power;
        this.attackType = AttackType;
    }
}

public class Decoy : Card//Creo la clase para las cartas de tipo señuelo, que hereda de la clase carta
{
    public int power;

    public Decoy(int Id, string CardName, string CardType, string CardEffect, int Power) //Metodo contructor de esta clase
    {
        this.id = Id;
        this.cardName = CardName;
        this.cardType = "Señuelo";
        this.cardEffect = CardEffect;
        this.power = 0;
    }
}