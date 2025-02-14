using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace APCompSciPT.Content.Items
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class Fortune : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.APCompSciPT.hjson' file.
		public override void SetDefaults()
		{
			Item.damage = 25;
			Item.DamageType = DamageClass.Melee;
			Item.width = 80;
			Item.height = 80;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(gold: 8, silver: 32);
			Item.rare = ItemRarityID.LightRed;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		//Recipe needed to create the sword.
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
		
		//Checks if the items dealt damage to a enemy then goes through the function.
		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone){
			int number = rnd.Next(1, 100);
			if (number > 100) {
				Console.WriteLine("20 is greater than 18");
			}
		}
	}
}
