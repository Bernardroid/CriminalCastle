using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{
    void StartTurn()
    {
        ResetPermaLocks();
    }

    void EndTurn()
    {
        //Start enemy turn
    }

    public static void ResetPermaLocks()
    {
        GameObject[] rooms = GameObject.FindGameObjectsWithTag("Room");
        GameObject[] units = GameObject.FindGameObjectsWithTag("Unit");

        for (int i = 0; i < units.Length; i++)
        {
            units[i].GetComponent<SCR_DragRoom>().b_piecePermaLocked = false;
        }

        for (int i = 0; i < rooms.Length; i++)
        {
            rooms[i].GetComponent<SCR_DragRoom>().b_piecePermaLocked = false;
        }
    }

    //Function returns damage done in combat
    public int DamageDone(UnitStatus _attacker, UnitStatus _defender, bool _magicalAttack)
    {
        int damageDone = 0;

        if (_magicalAttack)
        {
            if (_attacker.mAttack > _defender.mArmor)
            {
                damageDone = _defender.mArmor - _attacker.mAttack;
                _defender.hitPoints -= damageDone;
            }
            else
            {
                damageDone = 0;
            }
        }
        else
        {
            if (_attacker.mAttack > _defender.mArmor)
            {
                damageDone = _defender.armor - _attacker.attack;
                _defender.hitPoints -= damageDone;
            }
            else
            {
                damageDone = 0;
            }
        }

        return damageDone;
    }

}
