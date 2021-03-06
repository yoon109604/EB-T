﻿using System.Drawing;
using EloBuddy;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace Eclipse
{
    internal class Menus
    {
        public static Menu FirstMenu;
        public static Menu ComboMenu;
        public static Menu HarassMenu;
        public static Menu AutoHarassMenu;
        public static Menu LaneClearMenu;
        public static Menu LasthitMenu;
        public static Menu JungleClearMenu;
        public static Menu KillStealMenu;
        public static Menu DrawingsMenu;
        public static Menu MiscMenu;

        public const string ComboMenuID = "combomenuid";
        public const string HarassMenuID = "harassmenuid";
        public const string AutoHarassMenuID = "autoharassmenuid";
        public const string LaneClearMenuID = "laneclearmenuid";
        public const string LastHitMenuID = "lasthitmenuid";
        public const string JungleClearMenuID = "jungleclearmenuid";
        public const string KillStealMenuID = "killstealmenuid";
        public const string DrawingsMenuID = "drawingsmenuid";
        public const string MiscMenuID = "miscmenuid";

        public static void CreateMenu()
        {
            FirstMenu = MainMenu.AddMenu("The Joker "+Player.Instance.ChampionName, Player.Instance.ChampionName.ToLower() + "thejoker");
			FirstMenu.AddGroupLabel("Addon by Taazuma / Thanks for using it");
            FirstMenu.AddLabel("If you found any bugs report it on my Thread");
            FirstMenu.AddLabel("Have fun with Playing");
            ComboMenu = FirstMenu.AddSubMenu("● Combo", ComboMenuID);
            HarassMenu = FirstMenu.AddSubMenu("● Harass", HarassMenuID);
            //AutoHarassMenu = FirstMenu.AddSubMenu("AutoHarass", AutoHarassMenuID);
            LaneClearMenu = FirstMenu.AddSubMenu("● LaneClear", LaneClearMenuID);
            //LasthitMenu = FirstMenu.AddSubMenu("LastHit", LastHitMenuID);
            JungleClearMenu = FirstMenu.AddSubMenu("● JungleClear", JungleClearMenuID);
            KillStealMenu = FirstMenu.AddSubMenu("● KillSteal", KillStealMenuID);
            DrawingsMenu = FirstMenu.AddSubMenu("● Drawings", DrawingsMenuID);
            MiscMenu = FirstMenu.AddSubMenu("● Misc", MiscMenuID);

            ComboMenu.AddGroupLabel("Combo");
            ComboMenu.CreateCheckBox("Use Q", "qUse");
            ComboMenu.CreateCheckBox("Use E", "eUse");
			ComboMenu.CreateCheckBox("Use W", "wUse");
			ComboMenu.CreateCheckBox("Use R", "rUse");
            ComboMenu.AddLabel("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            ComboMenu.Add("useClone", new CheckBox("Clone Mover"));
            ComboMenu.Add("WaitForStealth", new CheckBox("Block spells in stealth"));
            ComboMenu.AddSeparator(10);
            ComboMenu.CreateCheckBox("Use R when Low", "rLow");
            ComboMenu.Add("hpR", new Slider("Use R at % HP", 30));
            ComboMenu.AddSeparator(6);
            ComboMenu.CreateCheckBox("Use Items", "itemss");

            HarassMenu.AddGroupLabel("Harass");
            HarassMenu.CreateCheckBox("Use W", "wUse");
            HarassMenu.CreateCheckBox("Use E", "eUse");
            HarassMenu.AddGroupLabel("Settings");
            HarassMenu.CreateSlider("Mana must be higher than [{0}%] to use spells", "manaSlider", 60);

            LaneClearMenu.AddGroupLabel("LaneClear");
            LaneClearMenu.CreateCheckBox("Use W", "wUse");
            LaneClearMenu.CreateCheckBox("Use E", "eUse");
            LaneClearMenu.AddGroupLabel("Settings");
            LaneClearMenu.CreateSlider("Mana must be higher than [{0}%] to use spells", "manaSlider", 60);

            JungleClearMenu.AddGroupLabel("JungleClear");
            JungleClearMenu.CreateCheckBox("Use W", "wUse");
            JungleClearMenu.CreateCheckBox("Use E", "eUse");
            JungleClearMenu.AddGroupLabel("Settings");
            JungleClearMenu.CreateSlider("Mana must be higher than [{0}%] to use spells", "manaSlider", 20);

            KillStealMenu.AddGroupLabel("KillSteal");
            KillStealMenu.CreateCheckBox("Use E", "eUse");

            DrawingsMenu.AddGroupLabel("Settings");
            DrawingsMenu.AddGroupLabel("Tracker Draws");
            DrawingsMenu.Add("me", new CheckBox("My Path", false));
            DrawingsMenu.Add("ally", new CheckBox("Ally Path", false));
            DrawingsMenu.Add("enemy", new CheckBox("Enemy Path", true));
            DrawingsMenu.AddLabel("Tracker Misc");
            DrawingsMenu.Add("toggle", new KeyBind("Toggle On/Off", true, KeyBind.BindTypes.PressToggle, 'G'));
            DrawingsMenu.Add("eta", new CheckBox("Estimated time of arrival (only me)", true));
            DrawingsMenu.Add("name", new CheckBox("Champion Name", true));
            DrawingsMenu.Add("thick", new Slider("Line Thickness", 2, 1, 5));
            DrawingsMenu.AddGroupLabel("Disable while use orbwalk");
            DrawingsMenu.Add("combo", new CheckBox("Combo", true));
            DrawingsMenu.Add("harass", new CheckBox("Harass", true));
            DrawingsMenu.Add("laneclear", new CheckBox("LaneClear", false));
            DrawingsMenu.Add("lasthit", new CheckBox("LastHit", true));
            DrawingsMenu.Add("flee", new CheckBox("Flee", false));

            MiscMenu.AddGroupLabel("Settings");
            MiscMenu.CreateCheckBox("Use Evade", "evade");
            MiscMenu.Add("usercc", new CheckBox("Dodge targeted cc"));
            MiscMenu.Add("autoMoveClone", new CheckBox("Always move clone"));
            StringList(MiscMenu, "ghostTarget", "Ghost target priority", new[] { "Targetselector", "Lowest health", "Closest to you" }, 0);
            MiscMenu.AddSeparator();
            MiscMenu.CreateCheckBox("Q - Escaper", "qescape");
            MiscMenu.AddSeparator(15);
            MiscMenu.CreateCheckBox("R Clone - Escaper", "rescape");
            MiscMenu.AddSeparator(15);
            MiscMenu.AddLabel("Level Up Function");
            MiscMenu.Add("lvlup", new CheckBox("Auto Level Up Spells", false));
            MiscMenu.AddSeparator(15);
            MiscMenu.CreateCheckBox("Activate Skin hack", "skinhax", false);
            MiscMenu.Add("skinID", new ComboBox("Skin Hack", 0, "Default", "Mad Hatter Shaco", "Royal Shaco", "Nutcracko", "Workshop Shaco", "Asylum Shaco", "Masked Shaco", "Wild Card Shaco"));

        }
        public static void StringList(Menu menu, string uniqueId, string displayName, string[] values, int defaultValue)
        {
            var mode = menu.Add(uniqueId, new Slider(displayName, defaultValue, 0, values.Length - 1));
            mode.DisplayName = displayName + ": " + values[mode.CurrentValue];
            mode.OnValueChange +=
                delegate (ValueBase<int> sender, ValueBase<int>.ValueChangeArgs args)
                {
                    sender.DisplayName = displayName + ": " + values[args.NewValue];
                };
        }
    }
}
