using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Demon", menuName = "Demon")]

public class Demons : ScriptableObject
{

    public string Name;
    public Sprite Art;
    public int Sp;
    public int atk;
    public int health;
    public int maxSp;
    public int maxHelth;
    public string element;
    public Power[] powers = new Power[4];

   public  void Awake()
    {
        health= maxHelth;
        Sp = maxSp;
    }
}

[System.Serializable]
public class Power
{
    public string name;
    public string type;
    public int cost;
    public int potency;
}