using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public List<Player> players;
    public Player playerTemplate;
    public List<string> roles;
    public bool isDay;
    public int DayNumber;
    //playercount = 18
    // Start is called before the first frame update
    void Start()
    {
        DayNumber = 0;
        isDay = false;
        for (int i = 0; i < 18; ++i)
        {
            players.Add(Instantiate(playerTemplate));
            players[i].role = roles[i];
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void DoNightPhase()
    {
        for (int i = 0; i < 18; ++i)
        {
            if (players[i].role == "Serial Killer")
            {
                while (players[i].Target.alive == false)
                {
                    int r = Random.Range(0, 17);
                    players[i].Target = players[r];
                }
                if (players[i].Target.alive)
                {
                    players[i].Target.SKAttacked = true;
                    if (players[i].Target.role == "Town Fool")
                    {
                        players[i].ForcedDeath = true;
                    }
                    if (players[i].Target.role == "Werewolf" || players[i].Target.role == "Mafia")
                    {
                        players[i].Target.SKAttacked = false;
                    }
                }

            }
            if (players[i].role == "Dr. Frankenstein")
            {

            }
        }
    }
}

