using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

// Basic Item template from https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
namespace APCompSciPT.Content.Items
{ 
	// Everything in public class Fortune is student made.
	public class Fortune : ModItem
	{
		//variable for gambleFever function.
		int gambleFever = 0;

		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.APCompSciPT.hjson' file.
		public override void SetDefaults()
		{
			//Base damage of the weapon on a hostile entity and how far the entity is launched back.
			Item.damage = 40;
			Item.DamageType = DamageClass.Melee;
			Item.knockBack = 6;

			//The heigh and width of the weapon.
			Item.width = 80;
			Item.height = 80;

			//The time it takes to swing the weapon, its swinging animation, and the sound it plays after each swing.
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.UseSound = SoundID.Item1;

			//The weapon's price and rarity.
			Item.value = Item.buyPrice(gold: 8, silver: 32);
			Item.rare = ItemRarityID.LightRed;
			Item.autoReuse = true;
		}

		//Recipe needed to create the sword.
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldBar, 12);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
		
		
		//Checks if the items dealt damage to a enemy then goes through the function.
		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
		{
			//Increases each time the player hits an enemy with the sword.
			public override void gambleFeverCount() {
				gambleFever++;
				//Checks if gambleFever variable over the limit causing a random buff to the player.
				if (gambleFever >= 120) {
				//Add buffs and coins here.
				gambleFever = 0;
			}
		}
			//Picks a random debuff in the idex and applies it to the hostile entity.
			int gamble = rnd.Next(1, 100);
			if (2 > gamble > 20 ) {
				target.AddBuff(BuffID.Frostburn2, 360) //60 ticks is one second.
			} else if (number = 1){
				target.AddBuff(BuffID.Bleeding, 3600) //60 ticks is one second
			}
		}
	}
}
