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
        public static Menu AutoHarassMenu;
        public static Menu LaneClearMenu;
        public static Menu JungleClearMenu;
        public static Menu KillStealMenu;
        public static Menu DrawingsMenu;
        public static Menu MiscMenu;

        public static ColorSlide QColorSlide;
        public static ColorSlide WColorSlide;
        public static ColorSlide EColorSlide;
        public static ColorSlide RColorSlide;
        public static ColorSlide DamageIndicatorColorSlide;

        public const string ComboMenuID = "combomenuid";
        public const string AutoHarassMenuID = "autoharassmenuid";
        public const string LaneClearMenuID = "laneclearmenuid";
        public const string JungleClearMenuID = "jungleclearmenuid";
        public const string KillStealMenuID = "killstealmenuid";
        public const string DrawingsMenuID = "drawingsmenuid";
        public const string MiscMenuID = "miscmenuid";

        public static void CreateMenu()
        {
            FirstMenu = MainMenu.AddMenu("Ronin "+Player.Instance.ChampionName, Player.Instance.ChampionName.ToLower() + "taazuma");
			FirstMenu.AddGroupLabel("Addon by Taazuma / Thanks for using it");
            FirstMenu.AddLabel("If you found any bugs report it on my Thread");
            FirstMenu.AddLabel("Have fun with Playing");
            FirstMenu.AddLabel("Credits aliyrlmz");
            FirstMenu.AddLabel("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            FirstMenu.Add(SpellsManager.Q.Slot + "hit", new ComboBox("Q HitChance", 0, "High", "Medium", "Low"));
            FirstMenu.AddLabel("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            ComboMenu = FirstMenu.AddSubMenu("Combo", ComboMenuID);
            AutoHarassMenu = FirstMenu.AddSubMenu("AutoHarass", AutoHarassMenuID);
            LaneClearMenu = FirstMenu.AddSubMenu("LaneClear", LaneClearMenuID);
            JungleClearMenu = FirstMenu.AddSubMenu("JungleClear", JungleClearMenuID);
            KillStealMenu = FirstMenu.AddSubMenu("KillSteal", KillStealMenuID);
            DrawingsMenu = FirstMenu.AddSubMenu("Drawings", DrawingsMenuID);
            MiscMenu = FirstMenu.AddSubMenu("Misc", MiscMenuID);

            ComboMenu.AddGroupLabel("ComboMenu");
            ComboMenu.AddSeparator(10);
            // --------------------------------------------------------------COMBO LOGICS-------------------------------------------------------------- //
            ComboMenu.AddLabel("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            ComboMenu.AddLabel("Combo");
            ComboMenu.AddSeparator(7);
            ComboMenu.CreateCheckBox(" - Use Q", "qUse");
            ComboMenu.CreateCheckBox(" - Use W", "wUse");
            ComboMenu.CreateCheckBox(" - Use E", "eUse");
            ComboMenu.CreateCheckBox(" - Use R", "rUse");
            ComboMenu.Add("combouseE", new Slider("Use E combo when hp < ({0}%)", 60));
            ComboMenu.Add("comboEnemies", new Slider("E Min Enemies >=", 2, 1, 5));
            ComboMenu.AddLabel("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");

            AutoHarassMenu.AddGroupLabel("AutoHarass");
            AutoHarassMenu.AddLabel("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            AutoHarassMenu.CreateCheckBox(" - Use Q", "qUse");
            AutoHarassMenu.CreateCheckBox(" - Use RQ", "rqUse", false);
            AutoHarassMenu.AddGroupLabel("Settings");
            AutoHarassMenu.CreateKeyBind("Enable/Disable AutoHrass", "autoHarassKey", 'Z', 'U');
            AutoHarassMenu.CreateSlider("Mana must be higher than [{0}%] to use AutoHarass spells", "manaSlider", 65);
            AutoHarassMenu.AddLabel("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");

            LaneClearMenu.AddGroupLabel("LaneClear/Lasthit");
            LaneClearMenu.AddLabel("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            LaneClearMenu.CreateCheckBox(" - Use Q", "qUse");
            LaneClearMenu.AddGroupLabel("Settings");
            LaneClearMenu.CreateSlider("Mana must be higher than [{0}%] to use LaneClear spells", "manaSlider", 70);
            LaneClearMenu.AddLabel("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");

            JungleClearMenu.AddGroupLabel("JungleClear");
            JungleClearMenu.AddLabel("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            JungleClearMenu.CreateCheckBox(" - Use Q", "qUse");
            JungleClearMenu.CreateCheckBox(" - Use W", "wUse", false);
            JungleClearMenu.CreateCheckBox(" - Use E", "eUse", false);
            JungleClearMenu.CreateCheckBox(" - Use R", "rUse");
            JungleClearMenu.AddGroupLabel("Settings");
            JungleClearMenu.CreateSlider("Mana must be higher than [{0}%] to use JungleClear spells", "manaSlider", 10);
            JungleClearMenu.AddLabel("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");

            KillStealMenu.AddGroupLabel("KillSteal");
            KillStealMenu.CreateCheckBox("Use Q BETA", "qUse");
            KillStealMenu.AddGroupLabel("Settings");
            KillStealMenu.CreateSlider("Mana must be higher than [{0}%] to use KS spells", "manaSlider", 30);

            DrawingsMenu.AddGroupLabel("Settings");
            DrawingsMenu.CreateCheckBox("Draw spell`s range only if they are ready.", "readyDraw");
            DrawingsMenu.CreateCheckBox("Draw damage indicator.", "damageDraw", false);
            DrawingsMenu.CreateCheckBox("Draw damage indicator percent.", "perDraw", false);
            DrawingsMenu.CreateCheckBox("Draw damage indicator statistics.", "statDraw", false);
            DrawingsMenu.AddGroupLabel("Spells");
            DrawingsMenu.CreateCheckBox("Draw Q.", "qDraw", false);
            DrawingsMenu.CreateCheckBox("Draw W.", "wDraw", false);
            DrawingsMenu.CreateCheckBox("Draw E.", "eDraw", false); //No one like Drawings kappa
            DrawingsMenu.CreateCheckBox("Draw R.", "rDraw", false );
            DrawingsMenu.CreateCheckBox("Show Killable", "showkilla", false);
            DrawingsMenu.AddSeparator(10);
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
            DrawingsMenu.AddSeparator(15);
            DrawingsMenu.AddGroupLabel("Drawings Color");
            QColorSlide = new ColorSlide(DrawingsMenu, "qColor", Color.Red, "Q Color:");
            WColorSlide = new ColorSlide(DrawingsMenu, "wColor", Color.Purple, "W Color:");
            EColorSlide = new ColorSlide(DrawingsMenu, "eColor", Color.Orange, "E Color:");
            RColorSlide = new ColorSlide(DrawingsMenu, "rColor", Color.DeepPink, "R Color:");
            DamageIndicatorColorSlide = new ColorSlide(DrawingsMenu, "healthColor", Color.YellowGreen, "DamageIndicator Color:");

            MiscMenu.AddGroupLabel("Settings");
            MiscMenu.AddLabel("Level Up Function");
            MiscMenu.Add("lvlup", new CheckBox("Auto Level Up Spells", false));
            MiscMenu.Add("Lvldelay", new Slider("Lvlup Delay (ms)", 0, 0, 500));
            MiscMenu.AddSeparator(15);
            MiscMenu.CreateCheckBox("Activate Skin hack", "skinhax", false);
            MiscMenu.Add("skinID", new ComboBox("Skin Hack", 1, "Default", "Sakura Karma", "Sun Goddess Karma", "Traditional Karma", "Order of the Lotus Karma", "Warden Karma"));
            MiscMenu.AddSeparator(10);
            MiscMenu.AddLabel("Some Settings:");
            MiscMenu.Add("predictionHit", new Slider("Prediction for Q", 70));
            MiscMenu.Add("autoShieldTurret", new CheckBox("Auto shield turret", true));
            MiscMenu.Add("autoShieldSpell", new CheckBox("Auto shield spell", false));
            MiscMenu.Add("antiGapCloser", new CheckBox("Anti GapCloser", true));
        }

        public static int comboUseRW
        {
            get { return ComboMenu["comboUseRW"].Cast<Slider>().CurrentValue; }
        }
        public static bool autoShieldTurret
        {
            get { return MiscMenu["autoShieldTurret"].Cast<CheckBox>().CurrentValue; }
        }
        public static bool autoShieldSpell
        {
            get { return MiscMenu["autoShieldSpell"].Cast<CheckBox>().CurrentValue; }
        }
        public static bool antiGapCloser
        {
            get { return MiscMenu["antiGapCloser"].Cast<CheckBox>().CurrentValue; }
        }
        public static double predictionHit
        {
            get { return ComboMenu["predictionHit"].Cast<Slider>().CurrentValue; }
        }
        public static bool BlockSpells
        {
            get { return MiscMenu["blockSpellsE"].Cast<CheckBox>().CurrentValue; }
        }
        public static int Lvldelay { get { return MiscMenu["Lvldelay"].Cast<Slider>().CurrentValue; } }
    }
}
