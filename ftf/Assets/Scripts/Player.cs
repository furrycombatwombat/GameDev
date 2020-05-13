using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string role;
    public Player Target;
    public bool alive;
    public bool revived;
    public bool MafAttacked;
    public bool WWAttacked;
    public bool SKAttacked;
    public bool WorldlyProtected;
    public bool SupernaturalProtected;
    public bool ForcedDeath;
    public bool HealerAutoprotectActive;
    public bool BodyguardAutoprotectActive;
    public bool FoolEatenbyWW;
    private bool receivedRolebools;
    
    public List<Player> teammates; //for WW,maf,or DF/Igor
    // Start is called before the first frame update
    void Start()
    {
        alive = true;
        revived = false;
        receivedRolebools = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (receivedRolebools == false)
        {
            MafAttacked = false;
            WWAttacked = false;
            WorldlyProtected = false;
            SupernaturalProtected = false;
            ForcedDeath = false;
            HealerAutoprotectActive = (role == "Healer");
            BodyguardAutoprotectActive = (role == "Bodyguard");
            FoolEatenbyWW = false;
            receivedRolebools = true;
        }
    }
}
