﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {

    //Static instance of GameManager which allows it to be accessed by any other script.
    public static GameManagerScript instance = null;

    public GameObject currentPlayerPrefab;  //the player model/version we want to use/spawn
    public int targetSceneLinkId;   //used to store which scene link is used for spawning when entering scene
    private GameObject playerInstance;  //the player gameobject which is in use currently


    //Awake is always called before any Start functions
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
    public GameObject GetCurrentPlayerPrefab()
    {
        return currentPlayerPrefab;
    }

    public void SetCurrentPlayerPrefab(GameObject playerPrefab)
    {
        currentPlayerPrefab = playerPrefab;
    }

    public int GetTargetSceneLinkId()
    {
        return targetSceneLinkId;
    }

    public void SetTargetSceneLinkId(int id)
    {
        targetSceneLinkId = id;
    }

    public GameObject GetPlayerInstance()
    {
        return playerInstance;
    }

    public void SetPlayerInstance(GameObject player)
    {
        playerInstance = player;
    }
}