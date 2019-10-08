using System;
using UnityEngine;

public class LogTreesAction : GoapAction
{
	private bool felled = false;
	private TreeComponent targetTree; // trees to target
	
	private float startTime = 0;
	public float workDuration = 30; // seconds
	
	public LogTreesAction () {
		addPrecondition ("hasTool", true); // we need a tool to do this
		addPrecondition ("hasLogs", false); // if we have logs we don't want more
		addEffect ("hasLogs", true);
	}
	
	
	public override void reset ()
	{
		felled = false;
		targetTree = null;
		startTime = 0;
	}
	
	public override bool isDone ()
	{
		return felled;
	}
	
	public override bool requiresInRange ()
	{
		return true; // yes we need to be near a tree
	}
	
	public override bool checkProceduralPrecondition (GameObject agent)
	{
		// find the nearest tree that we can chop
		LogSource[] trees = (LogSource[]) UnityEngine.GameObject.FindObjectsOfType ( typeof(LogSource) );
		LogSource closest = null;
		float closestDist = 0;
		
		foreach (LogSource tree in trees) {
			if (closest == null) {
				// first one, so choose it for now
				closest = tree;
				closestDist = (tree.gameObject.transform.position - agent.transform.position).magnitude;
			} else {
				// is this one closer than the last?
				float dist = (tree.gameObject.transform.position - agent.transform.position).magnitude;
				if (dist < closestDist) {
					// we found a closer one, use it
					closest = tree;
					closestDist = dist;
				}
			}
		}
		if (closest == null)
			return false;

		targetTree = closest;
		target = targetTree.gameObject;
		
		return closest != null;
	}
	
	public override bool perform (GameObject agent)
	{
		if (startTime == 0)
			startTime = Time.time;
		
		if (Time.time - startTime > workDuration) {
			// finished chopping
			BackpackComponent backpack = (BackpackComponent)agent.GetComponent(typeof(BackpackComponent));
			backpack.numLogs += 1;
			felled = true;
			ToolComponent tool = backpack.tool.GetComponent(typeof(ToolComponent)) as ToolComponent;
			tool.use(0.34f);
			if (tool.destroyed()) {
				Destroy(backpack.tool);
				backpack.tool = null;
			}
		}
		return true;
	}
	
}
