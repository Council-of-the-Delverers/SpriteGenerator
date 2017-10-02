using System;
using System.Windows.Forms;

namespace SpriteGenerator
{
    public partial class ChoiceForm : Form
    { 
        public static Choice choice;
        public static string inputPath;

        public ChoiceForm()
        {
            InitializeComponent();
        }

        private void characterBtn_Click(object sender, EventArgs e)
        {
            choice = Choice.CHARACTER;
            inputPath = "Input/Character";
            Close();
        }

        private void swordBtn_Click(object sender, EventArgs e)
        {
            choice = Choice.SWORD;
            inputPath = "Input/Sword";
            Close();
        }

        private void hammerBtn_Click(object sender, EventArgs e)
        {
            choice = Choice.HAMMER;
            inputPath = "Input/Hammer";
            Close();
        }

        private void monsterBtn_Click(object sender, EventArgs e)
        {
            choice = Choice.MONSTER;
            inputPath = "Input/Hammer";
            Close();
        }

        private void itemBtn_Click(object sender, EventArgs e)
        {
            choice = Choice.ITEM;
            inputPath = "Input/Item";
            Close();
        }

        private void wandBtn_Click(object sender, EventArgs e)
        {
            choice = Choice.WAND;
            inputPath = "Input/Wand";
            Close();
        }

        public enum Choice
        {
            CHARACTER,
            SWORD,
            HAMMER,
            MONSTER,
            ITEM,
            WAND
        }
    }
}
