﻿using System.Windows.Forms;

namespace Void.Modules
{
    internal class Eject : Module
    {
        public Eject() : base("Eject", (char)0x07)
        {
        } // Not defined

        public override void OnEnable()
        {
            Program.quit = true;
            Application.Exit(); // ?
        }
    }
}