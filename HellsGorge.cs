using Terraria.ModLoader;

namespace HellsGorge
{
	class HellsGorge : Mod
	{
		public HellsGorge()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
