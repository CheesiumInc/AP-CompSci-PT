//References variables and methods outside of the weapon.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System:

namespace APCompSciPT.Content.Items
{ 
	// Everything in public class Fortune is student made.
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
			//Arrays for buffs and debuffs that can be used.
			int[] buffArray = new int[] {};
			int[] debuffArray = new int[] {30, 20, 24, 70, 22, 80, 35};

			//Picks a random number for hostile NPC buff/Debuff or Player Buff/Debuff
			int chance = rnd.Next(0, 100);

			//Variable for gambleFever function
			int gambleFever;
			//Checks for if gambleFever has reached a certain number then adds a point to the gambleFever if not.
			gambleFever();

			//40% Chance for a common debuff to a hostile NPC.
			if (0 <= chance && chance <= 40 ) {
				//Gives the hostile NPC a debuff/s.
				for (int i = 0; i < rnd.Next(1,5); i++) {
				int gamble = rnd.Next()
				target.AddBuff(BuffID.debuffArray[gamble], 360) //60 = one second
				}
			} else if (40 <= gamble && gamble <= 80 ){
				//Gives the hostile NPC a buff/s.
				for (int i = 0; i < rnd.Next(1,5); i++) {
				int gamble = rnd.Next()
				target.AddBuff(BuffID.debuffArray[gamble], 360) //60 = one second
				}
			}

			//Increases each time the player hits an enemy with the sword. 
			public void gambleFeverCount() {
				//Checks if gambleFever variable is greater than or equal causing a random buff to the player.
				if (gambleFever >= 5) {
					//Gives the player a buff/s.
					for (int i = 0; i < rnd.Next(1,5); i++) {
						player.ADDBuff(BuffID.Bleeding, rnd.Next(360, 720)) //A second is the number divided by 60.
					}
					gambleFever = 0;
				} 
				gambleFever++;
			}
		}
	}
}
