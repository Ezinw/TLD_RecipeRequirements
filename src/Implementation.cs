using MelonLoader;

namespace RecipeRequirements
{
	internal sealed class Implementation : MelonMod
	{
		public override void OnInitializeMelon()
		{
            Settings.OnLoad();
        }
	}
}
