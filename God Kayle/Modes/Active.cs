﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Constants;
using EloBuddy.SDK.Enumerations;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu.Values;
using EloBuddy.SDK.Rendering;
using SharpDX;
using static Eclipse.SpellsManager;
using static Eclipse.Menus;
using System.Diagnostics;

namespace Eclipse.Modes
{
    internal class Active
    {
        public static Obj_AI_Minion Minion;

        public static void Execute()
        {

            if (Combo._player.IsDead || Combo._player.IsRecalling()) return;

            //////////////////////////////////////////////////////////////////////////////////////////////////// Safer
            Program.HealMe();

            Program.HealAllies();
            //////////////////////////////////////////////////////////////////////////////////////////////////// Safer

            if (Player.HasBuff("zedulttargetmark"))
            {
                if (W.IsReady())
                {
                    W.Cast(Player.Instance);
                }
            }


        }

    }
}
