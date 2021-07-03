using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="Card", menuName ="MyCardGame/Card", order = 1)]

public class Card : ScriptableObject
{
    public new string name;
    public string desc;
    public int cost;
    public int atk;
    public int hp;
}
