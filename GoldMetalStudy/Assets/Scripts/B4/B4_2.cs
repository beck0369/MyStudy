using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B4_2 : MonoBehaviour
{
    public int id;
    public string name;
    public string title;
    public string weapon;
    public float strength;
    public int level;

    public string Talk()
    {
        return ("대화를 걸었다");
    }

    public string HasWeapon()
    {
        return weapon;
    }

    public void LevelUp()
    {
        level = level + 1;
    }
}
