/*===============================================================
Product:    Tags
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       4/28/2018 5:42 PM
================================================================*/


using UnityEngine;

namespace Homebrew
{
	public class TagFilterAttribute : PropertyAttribute
	{
		public System.Type Type { get; private set; }

		public TagFilterAttribute(System.Type type)
		{
			Type = type;
		}
	}
}