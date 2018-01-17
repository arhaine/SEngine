using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TempAssembler : MonoBehaviour
{

	public CharacterLocationContainer MyChar;

	// Use this for initialization
	void Start () {

		MyChar = new HumanoidTorsoLocation(null);

		var ls = MyChar.TryGetSublocations().TakeWhile(o => o.TryGetSublocations().Count > 0).ToList();

		string desc = "This Torso has: ";


		IEnumerable<CharacterLocationContainer> allNodes = Traverse(MyChar, node => node.TryGetSublocations());
		var lsls = allNodes.ToList();
		foreach (var lsl in lsls)
		{
			desc += lsl.GetType() + " ";
		}
		Debug.Log(desc);
	}

	public static IEnumerable<T> Traverse<T>(T item, Func<T, IEnumerable<T>> childSelector) //THIS THIS ALLOWS TO GET A FLATTENED LIST OF ALL SUBLOCATIONS BY USING A PREDICATE FUNC
	{
		var stack = new Stack<T>();
		stack.Push(item);
		while (stack.Any())
		{
			var next = stack.Pop();
			yield return next;
			foreach (var child in childSelector(next))
				stack.Push(child);
		}
	}
}
