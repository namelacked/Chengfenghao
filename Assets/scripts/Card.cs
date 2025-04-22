using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum CardType {RiskCouter,ProhibitedItem,Strategy,Cargo,Equipment,Encounter,Enemy,FirstMate,Ship}
[System.Serializable]
public class card{
    public String cardname;
    public CardType type;
    public String Description;
    public int value;
    public Sprite frontImage;
    public Sprite backImage;
    public List<String> tags;
    public bool isFaceUp = true;

}
