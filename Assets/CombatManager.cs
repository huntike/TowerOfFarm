using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TOF.Entities;
using TOF.Spell;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CombatManager : MonoBehaviour {


    /**
     * COMBAT DATA
     */

    public Protagonist[] teamData = new Protagonist[] { new Hero("Michel", new Job("guerrier"), new GlobalStats(), 1, 0), new Compagnon("Johnatan", new Job("pute"), new GlobalStats(), 1, 0) };

    public Antagonist[] enemyData = new Antagonist[] { new Mob(new GlobalStats(), 1, "chovsouri"), new Mob(new GlobalStats(), 1, "skelet") } ;


    //list of protagonists
    public GameObject[] team;
    //list of enemies on the level
    public GameObject[] enemies;

    //CurrentPlayer
    private Entity CurrentPlayer;

    // loot data
    int[] loot;

    //UI
    public GameObject ActionPanel;
    public GameObject TargetPanel;
    public GameObject InitPanel;

    public GameObject LoosePanel;
    public GameObject WinPanel;

    // turnpanels
    bool AttaccClicked = false;
    bool ProteccClicked = false;

    // turnOrder
    static List<Entity> TurnOrder = new List<Entity>();
    static int turn = -1;
    

    // Use this for initialization
    void Start ()
    {

        LoosePanel.SetActive(false);
        WinPanel.SetActive(false);

        TargetPanel.SetActive(false);
        SortInit();
        NextTurn();


    }

    // Update is called once per frame
    void Update ()
    {
        if (CurrentPlayer.GetType().IsSubclassOf(typeof(Antagonist)))
        {
            IAplay();
        }
        if (teamData[0].etat == Entity.State.DEAD && teamData[1].etat == Entity.State.DEAD)
        {
            InitPanel.SetActive(false);
            ActionPanel.SetActive(false);
            TargetPanel.SetActive(false);
            Protagonist[] teamData = new Protagonist[] { new Hero("Michel", new Job("guerrier"), new GlobalStats(), 1, 0), new Compagnon("Johnatan", new Job("pute"), new GlobalStats(), 1, 0) };

         Antagonist[] enemyData = new Antagonist[] { new Mob(new GlobalStats(), 1, "chovsouri"), new Mob(new GlobalStats(), 1, "skelet") };
            team[1].SetActive(true);
            team[0].SetActive(true);
            enemies[0].SetActive(true);
            enemies[1].SetActive(true);


            LoosePanel.SetActive(true);
        }
        //les alliés sont morts et on retourne sur le selecteur de dj
        if (enemyData[0].etat == Entity.State.DEAD && enemyData[1].etat == Entity.State.DEAD)
        {
            Getloot();
            InitPanel.SetActive(false);
            ActionPanel.SetActive(false);
            TargetPanel.SetActive(false);
                Protagonist[] teamData = new Protagonist[] { new Hero("Michel", new Job("guerrier"), new GlobalStats(), 1, 0), new Compagnon("Johnatan", new Job("pute"), new GlobalStats(), 1, 0) };

     Antagonist[] enemyData = new Antagonist[] { new Mob(new GlobalStats(), 1, "chovsouri"), new Mob(new GlobalStats(), 1, "skelet") };
            team[1].SetActive(true);
            team[0].SetActive(true);
            enemies[0].SetActive(true);
            enemies[1].SetActive(true);
            WinPanel.SetActive(true);
        }
        // on récup les loot et on retourne au selecteur de dj

    }


    private void NextTurn()
    {

        foreach (Entity e in TurnOrder)
        {

            Debug.Log(e.etat);


            if (e.etat == Entity.State.DEAD)
                DeleteModel(GetModel(e));
            else
                e.etat = Entity.State.PROCESSING;
        }


        turn++;

        if (turn >= TurnOrder.Count)
            turn = 0;
        // State machine

        if (turn == TurnOrder.Count)
            turn = 0;
        while (TurnOrder[turn].etat == Entity.State.DEAD)
            turn++;

        if (turn >= TurnOrder.Count)
            turn = 0;

        TurnOrder[turn].etat = Entity.State.ACTION;

        CurrentPlayer = TurnOrder[turn];

            Debug.Log(CurrentPlayer.GetType().ToString());


    }



    private void SortInit()
    {
        foreach (var p in teamData)
            TurnOrder.Add(p);

        foreach (var a in enemyData)
            TurnOrder.Add(a);

        TurnOrder.OrderByDescending(x => x.Primary.Initiative);
        CurrentPlayer = TurnOrder[0];


        Debug.Log(CurrentPlayer);
    }


    // ACTION METHODS


    private void IAplay()
    {
        var tmp = 99999;
        var target = 0;
        for( int i = 0; i < teamData.Length; i++)
        {
            if (teamData[i].actualHP < tmp)
            {
                tmp = teamData[i].actualHP;
                target = i;
            }
        }

        WSpell1 spell = new WSpell1();
        teamData[target].actualHP -= spell.Degat * 3;
        NextTurn();
    }

    private void setAction()
    {
        
    }



    // UI METHODS
    

    public void ClickAttacc()
    {
        Debug.Log(enemyData[0].actualHP);
        if (CurrentPlayer.GetType().IsSubclassOf(typeof(Protagonist)))
        {
            ActionPanel.SetActive(false);
            TargetPanel.SetActive(true);
            AttaccClicked = true;
            Debug.Log("Attacc");
        }


    }

    public void ClickProtecc()
    {
        if (CurrentPlayer.GetType().IsSubclassOf(typeof(Protagonist)))
        {
            ActionPanel.SetActive(false);
            TargetPanel.SetActive(true);
            ProteccClicked = true;
        }
    }

    public void ClickTargetE1()
    {
        if (AttaccClicked)
        {
            Protagonist protagonist = (Protagonist)CurrentPlayer;
            WSpell1 spell = new WSpell1();
            enemyData[0].actualHP -= spell.Degat * 3;
            AttaccClicked = false;
            if (enemyData[0].actualHP <= 0)
                enemyData[0].etat = Entity.State.DEAD;
        }
        else if (ProteccClicked)
        {
            Protagonist protagonist = (Protagonist)CurrentPlayer;
            WSpell2 spell = new WSpell2();
            CurrentPlayer.actualHP += 5;
            enemyData[0].actualHP -= spell.Degat;
            ProteccClicked = false;
            if (enemyData[0].actualHP <= 0)
                enemyData[0].etat = Entity.State.DEAD;
        }
        ActionPanel.SetActive(true);
        TargetPanel.SetActive(false);
        NextTurn();
    }

    public void ClickTargetE2()
    {
        if (AttaccClicked)
        {
            Protagonist protagonist = (Protagonist)CurrentPlayer;
            WSpell1 spell = new WSpell1();
            enemyData[1].actualHP -= spell.Degat * 3;
            AttaccClicked = false;
            if (enemyData[1].actualHP <= 0)
                enemyData[1].etat = Entity.State.DEAD;
        }
        else if (ProteccClicked)
        {
            Protagonist protagonist = (Protagonist)CurrentPlayer;
            WSpell2 spell = new WSpell2();
            CurrentPlayer.actualHP += 5;
            enemyData[1].actualHP -= spell.Degat;
            ProteccClicked = false;
            if (enemyData[1].actualHP <= 0)
                enemyData[1].etat = Entity.State.DEAD;

        }
        ActionPanel.SetActive(true);
        TargetPanel.SetActive(false);
        NextTurn();
    }
    private GameObject GetModel(Entity e)
    {
        for (int i = 0; i < teamData.Length; i++)
        {
            if (teamData[i].Equals(e))
            {
                return team[i];
            }
        }

        for (int i = 0; i < enemyData.Length; i++)
        {
            if (enemyData[i].Equals(e))
            {
                return enemies[i];
            }
        }

        return null;

    }

    public void DeleteModel(GameObject obj)
    {
        obj.SetActive(false);
    }


    public void ClickReplay()
    {

    }

    public void ClickQuit()
    {

    }

    public void Getloot()
    {

    }
}
