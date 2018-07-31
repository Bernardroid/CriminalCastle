using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{
    public GameObject[] units;
    public GameObject[] enemies;
    bool isInCoroutine=false;
    void Start()
    {
        units = GameObject.FindGameObjectsWithTag("Unit");
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

    }
    void Update()
    {
        int done=0;
        for (int i = 0; i < units.Length; i++)
        {
            if(units[i].GetComponent<SCR_DragRoom>().b_piecePermaLocked)
            {
                done++;
            }
            
        }
        if(done>=units.Length)
        {
            ResetPermaLocks();
                
                
        }

    }
    void StartTurn()
    {
        ResetPermaLocks();
    }

    void EndTurn()
    {
        //Start enemy turn
    }

    public void ResetPermaLocks()
    {

        for (int i = 0; i < units.Length; i++)
        {
            units[i].GetComponent<SCR_DragRoom>().b_piecePermaLocked = false;
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
