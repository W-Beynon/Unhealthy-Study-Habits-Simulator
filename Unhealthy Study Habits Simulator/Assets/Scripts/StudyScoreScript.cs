﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyScoreScript : MonoBehaviour {
    public PlayerStats player;

    // Start is called before the first frame update
    void Start()
    {
        StudyBarScript.SetStudyBarValue(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.getPaused()){
            player.incPrep(1);
            StudyBarScript.SetStudyBarValue(player.getPrep()/10000f);
        }
    }
}