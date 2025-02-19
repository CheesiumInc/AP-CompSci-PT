//References variables and methods outside of the weapon.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System:

namespace APCompSciPT.Content.Items
{ 
	// Everything in public class Fortune is student made. Refrences code from Terraria.
	public class Fortune : ModItem
	{
		//variable for gambleFever function.
		int gambleFever = 0;

		//The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.APCompSciPT.hjson' file.
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

			//Animation and Sound provided by Terraria.
			Item.useStyle = ItemUseStyleID.Swing;
			Item.UseSound = SoundID.Item1;

			//The weapon's price and rarity.
			Item.value = Item.buyPrice(gold: 1, silver: 32);
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
		
		
		//Checks if the weapon dealt damage to a enemy.
		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
		{
			//Arrays for buffs and debuffs that can be used. Buffs can be found in https://terraria.fandom.com/wiki/Buff_IDs
			int[] buffArray = new int[] {1, 2, 3, 5, 6, 7, 14, 16, 26, 58, 71, 73, 74, 75, 76, 77, 78, 79, 87, 89, 93, 97, 100, 105, 112, 113, 114, 116, 115, 117, 146, 151, 150, 158, 205, 215};
			int[] debuffArray = new int[] {30, 20, 24, 70, 22, 80, 35, 23, 31, 32, 33, 36, 39, 69, 44, 144, 21, 94, 67, 120, 353, 153};

			//Variable for gambleFever function
			int gambleFever;
			//Checks for if gambleFever has reached a certain number then adds a point to the gambleFever if not.
			gambleFever(gambleFever);

			//Picks a random number for hostile NPC chance of a buff/Debuff.
			int chance = rnd.Next(0, 100);
			//40% Chance for a debuff to a hostile NPC.
			if (0 <= chance && chance <= 40 ) {
				//Gives the hostile NPC a debuff/s.
				for (int i = 0; i < rnd.Next(1,5); i++) {
				int gamble = rnd.Next()
				target.AddBuff(BuffID.debuffArray[gamble], rnd.Next(360,720)) //A second is the number divided by 60.
				}
			//40% Chance for a buff to a hostle NPC
			} else if (40 <= gamble && gamble <= 80 ){
				//Gives the hostile NPC a buff/s.
				for (int i = 0; i < rnd.Next(1,5); i++) {
				int gamble = rnd.Next(0, )
				target.AddBuff(BuffID.buffArray[gamble], rnd.Next(360,720)) //A second is the number divided by 60.
				}
			}

			//Increases each time the player hits an enemy with the sword. 
			public void gambleFeverCount(gambleFever) {
				//Checks if gambleFever variable is greater than or equal causing a random buff to the player.
				if (gambleFever >= 5) {
					//Gives the player a buff/s.
					for (int i = 0; i < rnd.Next(1,5); i++) {
						int gamble = rnd.Next(0, buffArray.Length)
						player.AddBuff(BuffID.buffArray[gamble], rnd.Next(360, 720)) //A second is the number divided by 60.
					}
					gambleFever = 0;
				} 
				gambleFever++;
			}
		}
	}
}
