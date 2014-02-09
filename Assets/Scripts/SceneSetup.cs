﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SceneSetup : MonoBehaviour {

	public string sceneName;
	public int id;
	private List<NPC> npcList;

	// Use this for initialization
	void Start () {
		this.npcList = GameManager.getSceneNPCList(this.id);
		foreach (NPC n in npcList) 
		{
			string npcName = "NPCs/" + n;
			NPC t = (NPC) Instantiate(Resources.Load<NPC>(n.name));
			t.playerObj = GameObject.Find("player");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}