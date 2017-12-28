﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(EnemyController))]
[RequireComponent(typeof(GameStateController))]
public class GameFacade : MonoBehaviour {
    private static GameFacade instance;

    public static GameFacade GetInstance() {
        if (instance == null) {
            instance = GameObject.FindObjectOfType<GameFacade>();
            if (instance == null)
                throw new System.Exception("GameFacade不存在於場景中，請在場景中添加");
            instance.Initalize();

        }
        return instance;

    }
    #region Controller
    public EnemyController EnemyController { private set; get; }
    public GameStateController GameStateController { private set; get; }
    #endregion
    #region Model
    public StageData[] stageDatas;
    public PlayerData playerData;
    public GameStateData gameStateData;
    #endregion

    private void Initalize() {
        Debug.Log("[GameFacade] Initalize");
        EnemyController = GetComponent<EnemyController>();
        GameStateController= GetComponent<GameStateController>();
        playerData = new PlayerData();
        gameStateData = new GameStateData();

    }
    public void Awake() {
        GetInstance();
    }
}