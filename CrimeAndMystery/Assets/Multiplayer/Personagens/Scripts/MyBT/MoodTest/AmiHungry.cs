﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmiHungry : BTNode {

	Transform play;
	private StatsAi aiStatus;
	
	public AmiHungry(Transform play)
    {
			this.play = play;
			aiStatus = play.GetComponent<StatsAi>();
    }

    public override EstadoNode Tick()
    {
		if(aiStatus.hungry > 70)
		{
			return EstadoNode.SUCCESS;
		}
		else return EstadoNode.FAILURE;
    }
}
