# 28 Alphas Later v1.2

The idea behind this mod is to slow progression, make traders less powerful, and generally extend the time for a playthrough, while keeping the vanilla look and feel.

## INSTALLATION INSTRUCTIONS

>[!NOTE]
># Changelog/updates for v1.3.0
># REQUIRES A FRESH SAVE!!
>
>Reduced Dukes by 1/3 from quest rewards.
>
>Reworked the Despair Journal tip so it actually unlocks properly.
>
>Added Journal Tip and Tooltip for smell from food. [currently NON-FUNCTIONAL]
>
>Added various shape helpers for internal and external doors.
>
>More blocks can be picked up. Added the skull and piano.
>
>Action Skills!! Weapon and tool efficacy is now increased with action skills. IE, the more you use a tool/weapon, the more effective with it you become.
>
>Perk points NOT governed by action skills remain, but their cost is doubled from 1 to 2.
>
>Perks that govern melee weapon attack speed now additionally reduce stamina use for that weapon.
>
>Loot probability for crafting magazines and books for weapons/tools is now increased by reading more of that tools/weapons magazine. IE, the more you read shotgun magazines, the more likely you are to find shotgun magazines and Shotgun Messiah books in loot.
>
>Portable light sources (NVG, headlmap, flashlight etc) require batteries to operate, and the batteries will need replacing periodically.
>
>Helmet water filter is now a "housing unit". Requires a player-crafted filter to operate. Limited use filters will need replacing periodically.
>
>New material: Feldspar. Required for concrete mixing, and only found in the wasteland from surface terrain and surface boulders.
>
>Removed all shape crafting except basic wood frames. Blocks can be upgraded as usual though.
>
>Removed all "Clear +" quests as they don't share properly in multiplayer.
>

>[!NOTE]
># Changelog/Updates for v1.2.3
>various balancing tweaks
>
>Increased mod slots for T2 and T3 armour. Now 2,2,2,3,4,5 for Quality 1,2,3,4,5,6 Leather and Iron, and 3,3,3,4,5,6 for Quality 1,2,3,4,5,6 Military and Steel.
>
>Added "corpse run" buff. After death, you have increased run speed, stamina regen, and damage resistance for 30 seconds.
>
>Increased storage sizes for a few containers. NOTE: You 'may' get a console error when accessing the storage in a CURRENT save. If so, press 'F1', and type xui reload, or you can relog. That should fix it. New saves should be fine.
>
>Added stats display for Red's Legendary Paintbrush.
>
>Reworded its description.
>
>A few more minor localization tweaks.
>
>Added pick-up ability and crafting to several deco blocks/posters/signs/flags.
>
>Added ability to pick up, place and power "cold beer" and "shop open" signs.
>
>Expanded sinks variable helper to include bath tubs.
>
>Expanded appliances variant helper to include wood burning stove.
>
>Added craftable barbed wire variable shape helper block.
>
>Non-specific (generic) repair kits are now more expensive to make.
>
>Specific repair kits can now be made with a generic repair kit and a weapon/tool/armour part as required.
>
>The "smell" mechanic is back! Carrying differing quantities of certain food will increase the heat map, and subsequently alert screamers.
>Currently NON-FUNCTIONAL in multiplayer. Please read the warning note at the top of this document.
>
># Changelog for v1.2.2
>lowered probability for Blessed Metal in loot.
>
>removed "spider" walk type for all bipedal zombies
>
>tweaked upgrade material counts to match crafting quantities
>
>reworked crafting speed bonus for anvil and bellows
>
>changed screen effect for NVG (credit: Khaine)
>
>reworked dew collectors (doubled collection speed).
>
>reworked advanced filter - halves collection speed, and is cheaper to buy.
>
>added rain catcher - uses an empty bucket to collect rainwater.
>
>added visible UI element to show when the player is warm, sheltered and well-lit.
>
>torches and candles now give the campfire buff (slightly smaller radius than the campfire).
>
>Frozen zombie variant movement speed re-adjusted.
>
>Added new respawn protection buff. 2 minutes of radiation immunity.
>
>Lowered zombie animal counts in wasteland.
>
>POI Farmplots can now be "upgraded" to plantable, with a hoe and fertilizer.
>
>Red's Legendary Paintbrush added.
>
>Brass Catcher mod added for 9mm, 7.62mm, and .44 calibre firearms. Returns 50% of ammo casings.
>
>Mutated "grunts" HP lowered considerably.
>
>Rotten flesh removed from hobo stew recipe.
>
>Farm plot fertilizer requirements lowered.
>
>Trader quest addendum added - credit CautiousPancake.
>
>Posion debuff reworked. Now lasts 7 days, all attributes lowered by one for its duration, 5 second screen effect and sound reminder at random intervals.
>
>Despair mitigation added to Charismatic Nature (for multiplayer games). Each point in Charismatic Nature reduces how despair affects allies and party members.


>[!NOTE]
># Changelog for v1.2
>
>Now updated for multiplayer!!
>
> Despair system has a complete rework (feedback is encouraged)
>
>Hoe now added to trader stock & loot.
>
>Rebalanced recipes for farm plots, and for fertilizer required to till the ground.
>
>Reworked the zombie "boomers".
>
>Slightly increased ammo in loot.
>
>Removed the workbench/tool requirement for chicken coops and beehives. They can now be crafted in your inventory, but you need a repair tool in your inventory.
>
>Rebalanced the amount hunger and thirst affect your despair.
>
>The liquid nitrogen mod now has a DoT effect, as well as its slow effect.
>
>Being in close proximity to zombies now affects your despair. The stronger the zombie, the worse the effect.
>
>Two additional food recipes added - Tramp and vagabond stew. Basic recipes, no unlock required. A use for early game cat/dog food, but still needs a cooking pot.
>
>Custom mesh files for some food/drink/candy (thanks Schrader :) )

>[!WARNING]
>The mod was NOT tested for compatibility with any other mods/modlets, other than the ones that come bundled with it. It's recommended to remove any and all other mods/modlets when playing, as troubleshooting any issues that arise from using other untested mods/modlets won't be possible.

>[!TIP]
>The download .zip file contains a folder called `\Mods`. You can either:
>1. Copy this folder into your game directory, usually `C:\Program Files (x86)\Steam\steamapps\common\7 Days To Die`
>2. Copy the folder into `%AppData%\Roaming\7DaysToDie`
>3. Alternatively, you can use the mod launcher, available from here: [https://7d2dmodlauncher.org/](url)

## FEATURES 

### STARTER ITEMS

"Starter" items are now in a backpack, found in slot 2 of your toolbelt. Open it with your primary action (LMB by default on PC)

When you open the backpack, read the note from The Duke to obtain your starter weapon of choice.

The starter quest is now just "place bedroll", which you'll receive on opening the starter backpack.

### GENERAL GAMEPLAY

Player starts with a new debuff - Despair. Despair is dynamically affected by various different factors, including:

1. Darkness. Too dark, and your Despair will increase dramatically. Torches, helmet lights and flashlights will mitigate this. Use these in conjunction with a campfire for the best effect.
2. Temperature. If you’re freezing or sweltering, your Despair will also increase dramatically. Find shelter!
3. Environment: Varying degrees of “wetness” will change how Despair affects you, as will your shelter. If you’re warm, dry, sheltered, well lit, AND near an operating campfire,forge or chem station you can effectively “treat” Despair.
4. Hunger and thirst affect how quickly your despair increases. Starvation/dehydration will drastically increase the rate at which you become affected by despair.
5. Injuries will affect how quickly your despair increases.
6. There is medication in trader stock and rare medical loot to treat your despair.
7. There is also lavender growing wild, which can be collected to make your own lavender seeds, and is also used to make Lavender Oil in a cooking pot at a campfire. Treats 3% Despair.
8. All food has a positive effect. The better the food, the more effective the treatment.
9. Killing zombies and animals will reduce your overall despair. Conversely, getting hit by enemies will increase it.
10. Being in close proximity to zombies increases your Despair. The tougher the zombie, the worse the effect. The effect is compounded, so the more zombies there are, the worse it'll be.
11. Player “wellness”. Your maximum health will also slow down the effects of despair. Every 10 additional health slows down the rate at which Despair affects you.
12. The morale booster from the drone will decrease the rate at which despair affects you.
13. The trader has an effect. Being close to a trader will slow down and/or reduce your Despair.
14. The perk "From the Shadows" also has an effect on the way Despair affects you at NIGHT. The more points in the perk, the less Despair affects you at night.

Headshots ONLY. Zombies can only be damaged/killed with headshots, or with fire, or with explosives. (currently only works in single player games)

Zombies DON'T bleed. Nothing undead takes bleed damage.

Hazmat zombies are a guaranteed source of hazmat gear. Kill one, and if it drops loot, it'll have some hazmat gear in there.

There are more zombies in the world. Biomes are gamestaged, which means zombies get tougher and their number increases as you level up.

Zombies are tougher.

Nights are dangerous, downtown is much more dangerous.

Traders are still protected, but they open from dawn 'til dusk. No more waiting for 6 am anymore.

Traders and vending machines are MUCH more expensive to buy from, and will buy from you at a much lower price.

Crafting is 25% more expensive, and loot, harvesting and scrapping quantities are much lower.

XP required to level increased by 25%.

Dismember chance lowered to 1% per attribute level, max at 10%.

Knife base damage rebalanced.

60-slot backpack.

### AMMO, WEAPONS, MODS AND ARMOUR

New basic wood arrow/bolt. Made from a single branch, its range is poor, its damage isn't great, and it always breaks on impact.

All arrows and bolts have a 25% chance of causing bleeding on a living target. Shame it doesn't work on the undead …

Ammo can be “dismantled” into its component parts.

The serrated blade only fits on spears and knuckles now.

Hazmat armour mods can be crafted from hazmat gear. You’ll still need all five mods (head, gloves, chest, legs, and boots) for full radiation protection.

New mods - blessed metal for stopping mutated regen. NiCd is back, as is Flaming Oil and Liquid Nitrogen. Liquid Nitrogen now includes DoT damage.

New clothing mod - cycling shorts. Install them in your leg armour/clothing and save 25% stamina when cycling.

### BLOCKS/WORKSTATIONS

The beehive. Can be crafted with any repair tool in your inventory. Find bees (and honey) in specific tree stumps (beehives) in the world, and use them to produce honey. Normal wild tree stumps have a higher chance of giving honey too.

The dew collector now uses a filter as a tool, with durability. It has to be replaced when it breaks, or the collector will stop.

The chicken snare. Place this block down, and load it with corn seed to attract and trap chickens, which can be used in coops to produce eggs.
These chickens can also be butchered for meat, feathers and eggs, with a hunting knife in your inventory.

The chicken coop. Can be crafted with any repair tool in your inventory. Place this block, add a chicken from a trap, and it will produce eggs over time. The chicken will "dry out" over time, and will need replacing to keep producing eggs.

The tablesaw cannot be crafted, it can only be collected from POIs. Press "E" to pick one up.

The workbench now has slots for a wrench, hammer, ratchet, impact driver, and nail gun. These tools are needed to craft a lot of items, and some items have been moved from inventory crafting to workbench crafting.

The cement mixer now requires gasoline to work.

The forge no longer requires you to smelt items. You can use the items directly from your inventory.

### BUFFS/DEBUFFS

Snakes and Spider zombies will envenom you when they attack. Kill snakes to extract their venom, which can be used to make antivenom. Antivenom crafting is unlocked after reading 10 medical magazines, and it can appear in loot and trader stock.

The Wasteland biome is irradiated, and very, VERY dangerous. You'll need a hazmat suit before you venture in there.

Radiated zombies now irradiate the player when they attack. A full hazmat suit or a full set of hazmat mods negates this.

Some Burnt zombies now set the player on fire when they attack. A full hazmat suit or a full set of hazmat mods negates this.

Honey infection treatment reduced to 3% from 5%.

Despair medication (Lavender, St. John’s Wort and Lithium) can be found in medical loot, and in trader stock. Lavender oil can be crafted from lavender flowers and used to treat despair.

### ZOMBIES/ENEMIES

Bears and wolves are back in the forest.

Zombie health increases with game difficulty. Scavenger starts with zombies dealing 100% damage and no health bonus. Zombie health increases per level, up to 65% more health on insane difficulty. Damage received by zombies increases by 25% per level up to Survivalist, and then a further 50% jump to Insane (150% more damage dealt at maximum difficulty). The player ALWAYS does a flat 100% damage, REGARDLESS of difficulty.

Hazmat zombies are now immune to burning.

New Bunker Buster zombie. Only appears during bloodmoon(s), and can appear from the very first Bloodmoon. You’ll want to take it out quickly … think of it as a “light” demolition zombie.

Demolition zombies appear at a much earlier gamestage.

New Mutated zombie variant. Bigger, tankier, stronger, yellower, and with more radiated regen. You'll need a blessed metal mod to take them down - the wasteland is full of these guys.

New Frozen zombie variant. Slightly tougher, slightly slower, slightly more XP, and take slightly more damage than their “Normal” counterparts. Immune to the effects of liquid nitrogen, and if they touch you, your movement is reduced by 20%. You can negate this by maxing out the Well Insulated perk.  Found in the snow biome.

New Rotting zombie variant. They have lower HP, lower XP reward, and they take more damage. Found in the forest and desert biomes.

During bloodmoons, ‘some’ zombies have a 10% chance to respawn after death, unless they’re killed with fire or explosives. There is also a 5% chance that a “boss” zombie will spawn, which boosts all zombies within range; their damage by 20%, and gives them regenerative properties. The boss is marked with a specific symbol, so target them with extreme prejudice.

“Normal”, “frozen” and “rotting” ‘Fat’ zombies (Big Mama, tourist) don’t puke, but they do explode …

Rotten and Normal “Fat” zombies (Cop,Big Mama and Tourist) are filled with a substance that’s irresistible to all zombies. If you are within range when they explode, they’ll cover you in this stuff - and attract other zombies …

### FOOD/FARMING

All canned food found in loot, vending machines, and trader stock is "uncooked". Cook it to make it safe to eat, or eat it and run the risk of food poisoning ...

Uncooked cans don't replenish health, just food and water.

Five new recipes - Chicken stew and chicken miso, top of the tier 3 food chain, along with Scrambled Eggs, a better use for eggs and Tramp/Vagabond stew(s), which use cat/dog food. Basic recipes, unlocked by default. Needs a cooking pot.

MegaCrush is craftable, in a campfire, with a beaker, and cheaper in a chemistry station.

Pies and cheesecake need honey for that sweet, sweet taste now.

Crops' growing time is double that of vanilla.

Farming is reworked entirely. You need a hoe to till the ground to plant seeds. Use the hoe with fertiliser to upgrade the tilled ground (can be upgraded twice). Level one tilled ground yields 1 crop, level two (first fertilised level) yields 2 crops and level three (second fertilised level)  yields 3.

Farm Plots require fertiliser and nails to craft, are crafted in the workbench with a hammer,  and are the same fertile level as level 3 fertilised ground.

Farmplots found in POI’s are no longer plantable.

There is no harvest bonus for Living off the Land, instead, seeds cost less crops to make per level, and the amount of fertiliser required to make farmplots is reduced per level. Fertiliser is craftable in the cement mixer and chem station, and is in *some* trader stock.

Wild plants can be picked up - press ‘E’ by default to pick them up. Wild plants always give one crop, whether they’re picked up or “punched”.

New plant - lavender. Purple flower found growing in the wild and in some POIs. Seeds crafted from lavender flowers, no unlock required. Lavender flowers can be found in loot and trader stock, and Lavender seeds in trader stock.

### PROGRESSION

There is no more Daring Adventurer or Better Barter. Traders will give a drink after every quest tier, which will increase bartering by 5% and trader level by one for each tier of quests completed. MAKE SURE YOU HAVE SPACE IN YOUR INVENTORY FOR IT!!

There is a new perk, Survival Instinct. It's a "single-player" version of Charismatic Nature. 5 levels, each level gains you an additional 5 health/stamina, 10% block damage, 5% entity damage, 3% XP, and carry capacity increases by 1.

Living off the Land now offers a discount to crops needed to make seeds, level 2 costs 4 crops per seed, level 3 costs 3 crops per seed.

Clothing that gives perk updates has been removed. Instead, the looting and night vision goggles, and the bandanna, have a mod slot. There are 5 mods available, specifically for these items, and each mod increases the 5 different perks by one. The bartering bonus (from cigars originally), and the crafting speed and XP gain (from the nerdy glasses) have been removed. The cigar itself remains as a recipe unlock (craft only).

### RESOURCES 

Trees no longer give wood, they give wood logs, scraps, and branches. Logs can be placed and then chopped with an axe for wood, or use the table saw to do it quicker and better.

Primitive weapons and ammo are now made from wood scraps, branches, plant fibres, and/or stone.

Cobblestone is now more expensive to make in your inventory. Use a cement mixer to make it cheaper.

Concrete now requires a bucket of water and is crafted in batches of 250. Returns an empty bucket when crafting is complete.

Most ammo can be dismantled into its component parts. Check ammo for recipes, and look at the 3rd tab to see what they dismantle into. Most need a workbench to do this, but basic arrows/bolts can be dismantled in your inventory.

Repair kits are more expensive, and weapons/armour/tools that require specific crafting parts now require a specific repair kit.

### VEHICLES

All vehicles EXCEPT the bicycle are too heavy for you to carry.

Vehicles CANNOT be used underwater.



# Contributors:

Particle systems/Unity edits 			- Author: redbeardt

28AL Item Offsets/Core					- Author: redbeardt

Custom mesh files						- Author: Schrader97

Farming template (xml code)			- Author: Gouki

Original Chicken Coop model 			- Author: DocRabbit

HJPlayerItemCount				- Author: w00kien00kie

IDCAdvancedDewCollector 			- Author: I Don't Care

IDCAnimalSnare					- Author: I Don't Care

IDCBeehive					- Author: I Don't Care

IDCCore						- Author: I Don't Care

HPBars template (xml code)			- Author: Khaine

60-slot backpack (xml code)			- Author: Khaine

NVG changes (xml code)				- Author: Khaine

Khelldon Custom Menu 				- Author: Khelldon

Custom Menu Music				- Author: Khaine

Material Modifier 				- Author: Zilox

ColoredContainerStates				- Author: Scomar

WMMStaminaDehydrationFix			- Author: w00kien00kie

WMMTraderQuestMap				- Author: w00kien00kie

CustomDifficulty				- Author: Mythix

Trader Quest addendum				- Author: CautiousPancake
						
### Also a huge thank you to Frantic_Dan & redbeardt for the custom HUD base code, main menu localization changes, and to YubiNashi and Frantic_Dan for ideas/balancing and playtesting.



 
