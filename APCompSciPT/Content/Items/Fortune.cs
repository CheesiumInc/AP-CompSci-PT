//Refers to variables and methods outside of the program.
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace APCompSciPT.Content.Items
{ 
    public class Fortune : ModItem
    {
        //Sets the way random numbers are generated from Using System.
        Random rnd = new Random();

        //The Display Name and Tooltip of this is located in 'Localization/en-US_Mods.APCompSciPT.hjson' file.
        public override void SetDefaults()
        {
            //Base damage of the weapon on a hostile entity and how far the entity is launched back.
            Item.damage = 74;
            Item.DamageType = DamageClass.Melee;
            Item.knockBack = 8;

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
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
        
               //Checks if the weapon dealt damage to a enemy.
        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            //Arrays for buffs and debuffs that can be used. Buffs can be found in https://terraria.fandom.com/wiki/Buff_IDs
            int[] buffArray = new int[] { 1, 2, 3, 5, 6, 7, 14, 16, 26, 58, 71, 73, 74, 75, 76, 77, 78, 79, 87, 89, 93, 97, 100, 105, 112, 113, 114, 116, 115, 117, 146, 151, 150, 158, 205, 215 };
            int[] debuffArray = new int[] { 30, 20, 24, 70, 22, 80, 35, 23, 31, 32, 33, 36, 39, 69, 44, 144, 21, 94, 67, 120, 353, 153 };

            gambleFever(rnd.Next(0, 100));

            //Picks a random number for hostile NPC chance of a buff/Debuff.
            int chance = rnd.Next(0, 100);
            //80% Chance for a debuff to a hostile NPC.
            if (0 <= chance && chance <= 80)
            {
                //Gives the hostile NPC a debuff/s.
                for (int i = 0; i < rnd.Next(1, 5); i++)
                {
                    int gamble = rnd.Next(0, debuffArray.Length - 1);
                    target.AddBuff(debuffArray[gamble], rnd.Next(360, 720)); //A second is the random number divided by 60.
                }
            }
        }
             //Method that checks for gambleChance is over required count then applies a buff/s to the player
        public void gambleFever(int gambleChance) 
        {
            //checks if the gamble count 
             if (gambleChance >= 40)
            {
                //Gives the player a buff/s.
                for (int i = 0; i < rnd.Next(1, 5); i++)
                {
                    //Picks a random index from buffArray to give a buff.
                    int gamble = rnd.Next(0, buffArray.Length - 1);
                    player.AddBuff(buffArray[gamble], rnd.Next(360, 720)); //A second is the random number divided by 60.
                }
            }

         }
    }
}