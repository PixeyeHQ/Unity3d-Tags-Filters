 

# Unity3d-Tags-Filters
Extending a Unity3d Inspector window to show int tags

[![Join the chat at https://discord.gg/ukhzx83](https://img.shields.io/badge/discord-join%20channel-brightgreen.svg?style=flat-square)](https://discord.gg/ukhzx83)
[![Twitter Follow](https://img.shields.io/badge/twitter-%40dimmPixeye-blue.svg?style=flat-square&label=Follow)](https://twitter.com/dimmPixeye)
[![license](https://img.shields.io/badge/license-MIT-brightgreen.svg?style=flat-square)](https://github.com/dimmpixeye/Unity3d-Tags-Filters/blob/master/LICENSE)

![Demo](https://i.redd.it/yeiab2r2bk111.gif)

## What is it?
Tag filter is a small snippet for Unity that allows logically group your int variables in the inspector. It doesn't compete with enums.


```csharp
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
```

## Other content
* [InspectorFoldoutGroup](https://github.com/dimmpixeye/InspectorFoldoutGroup) -  an extension to add foldable groups to the inspector.
* [ACTORS](https://github.com/dimmpixeye/Actors-Unity3d-Framework) - Unity3d data driven framework I'm currently working on.
 
