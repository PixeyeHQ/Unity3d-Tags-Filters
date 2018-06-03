
using UnityEngine;


namespace Homebrew
{
	public class DemoTags : MonoBehaviour
	{
		// use TagFilter attribute with class type that hold your const ints.
		[TagFilter(typeof(Tags))] public int tag;
	}

	public static class Tags
	{
	    // use tagfiled attribute with param caterogy name.	
		[TagField(categoryName = "entities")] public const int Players = 0;
		[TagField(categoryName = "entities")] public const int Enemies = 1;

		[TagField(categoryName = "signals")] public const int SignalAttack = 2;
		[TagField(categoryName = "signals")] public const int SignalDamage = 3;
		[TagField(categoryName = "signals/effects")] public const int SignalStun = 3;
	}
}