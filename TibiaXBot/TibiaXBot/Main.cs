﻿/*
 *     TibiaXBot is a bot made for tibia, it has many new unique features
    that none has used before (Or not very much).
    Copyright (C) 2008  Jesper_Kladden & Aluwama.

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with TibiaXBot.  If not, see <http://www.gnu.org/licenses/>.
 * 
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tibia;
using Tibia.Objects;

namespace TibiaXBot
{
    public partial class Main : Form
    {
        public Client client;
        public Player player;
        public Tibia.Objects.Console console;
        public Form frmWASD;
        public Form frmOutFit;
        public Form frmSpammer;
        public Form frmAbout;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            client = Tibia.Util.ClientChooser.ShowBox();
            frmWASD = new WASD(client);
            frmSpammer = new Spammer.Spammer(client);
            frmOutFit = new Outfit(client);
            frmAbout = new About();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmWASD.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSpammer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmOutFit.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout.Show();
        }

        private void wASDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWASD.Show();
        }

        private void spammerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSpammer.Show();
        }

        private void outfitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOutFit.Show();
        }
    }
}