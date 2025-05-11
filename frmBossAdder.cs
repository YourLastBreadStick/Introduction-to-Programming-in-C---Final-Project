using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_TerrariaBossInfo_AKG
{
    public partial class frmBossAdder : Form
    {
        public frmBossAdder(frmBossLibrary bossLibrary)
        {
            InitializeComponent();
            _bossLibrary = bossLibrary;
        }
        private frmBossLibrary _bossLibrary;
        public delegate void Bossadder();
        public Bossadder accept;
        private void frmBossAdder_Load(object sender, EventArgs e)
        {
            cboGameList.Items.Add("Choose a game");
            cboGameList.Items.Add("Vanilla Terraria");
            cboGameList.Items.Add("Calamity");
            cboGameList.Items.Add("Thorium");
            cboGameList.Items.Add("Fargo's Souls");
            cboBossList.Items.Add("Select a game first");
            cboDifficultyList.Items.Add("Select a game first");
            cboGameList.SelectedIndex = 0;
            cboBossList.SelectedIndex = 0;
            cboDifficultyList.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cboGameList_IndexChange(object sender, EventArgs e)
        {
            if (cboGameList.SelectedIndex == 0) // no game is selected
            {
                cboBossList.Items.Clear();
                cboDifficultyList.Items.Clear();
                cboBossList.Items.Add("Select a game first");
                cboDifficultyList.Items.Add("Select a game first");
                cboBossList.SelectedIndex = 0;
                cboDifficultyList.SelectedIndex = 0;
            }
            else if (cboGameList.SelectedIndex == 1) // the base game
            {
                cboBossList.Items.Clear();
                cboBossList.Items.Add("Select a boss");
                cboBossList.Items.Add("King Slime");
                cboBossList.Items.Add("Eye of Cthulhu");
                cboBossList.Items.Add("Eater of Worlds");
                cboBossList.Items.Add("Brain of Cthulhu");
                cboBossList.Items.Add("Queen Bee");
                cboBossList.Items.Add("Deerclops");
                cboBossList.Items.Add("Skeletron");
                cboBossList.Items.Add("Wall of Flesh");
                cboBossList.Items.Add("Queen Slime");
                cboBossList.Items.Add("Destroyer");
                cboBossList.Items.Add("Skeletron Prime");
                cboBossList.Items.Add("The Twins");
                cboBossList.Items.Add("Plantera");
                cboBossList.Items.Add("Empress of Light");
                cboBossList.Items.Add("Golem");
                cboBossList.Items.Add("Duke Fishron");
                cboBossList.Items.Add("Lunatic Cultist");
                cboBossList.Items.Add("Moon Lord");
                cboBossList.Items.Add("Dark Mage");
                cboBossList.Items.Add("Ogre");
                cboBossList.Items.Add("Betsy");
                cboBossList.Items.Add("Flying Dutchman");
                cboBossList.Items.Add("Mourning Wood");
                cboBossList.Items.Add("Pumpking");
                cboBossList.Items.Add("Everscream");
                cboBossList.Items.Add("Santa-NK1");
                cboBossList.Items.Add("Ice Queen");
                cboBossList.Items.Add("Martian Saucer");
                cboBossList.Items.Add("Solar Pillar");
                cboBossList.Items.Add("Nebula Pillar");
                cboBossList.Items.Add("Vortex Pillar");
                cboBossList.Items.Add("Stardust Pillar");
                cboBossList.SelectedIndex = 0;
                cboDifficultyList.Items.Clear();
                cboDifficultyList.Items.Add("Select a difficulty");
                cboDifficultyList.Items.Add("Classic");
                cboDifficultyList.Items.Add("Expert");
                cboDifficultyList.Items.Add("Master");
                cboDifficultyList.SelectedIndex = 0;
            }
            else if (cboGameList.SelectedIndex == 2) // the mod Calamity
            {
                cboBossList.Items.Clear();
                cboBossList.Items.Add("Select a boss");
                cboBossList.Items.Add("Desert Scourge");
                cboBossList.Items.Add("Crabulon");
                cboBossList.Items.Add("The Hive Mind");
                cboBossList.Items.Add("The Perforators");
                cboBossList.Items.Add("The Slime God");
                cboBossList.Items.Add("Cryogen");
                cboBossList.Items.Add("Aquatic Scourge");
                cboBossList.Items.Add("Brimstone Elemental");
                cboBossList.Items.Add("Calamitas Clone");
                cboBossList.Items.Add("Leviathan and Anahita");
                cboBossList.Items.Add("Astrum Aureus");
                cboBossList.Items.Add("The Plaguebringer Goliath");
                cboBossList.Items.Add("Ravager");
                cboBossList.Items.Add("Astrum Deus");
                cboBossList.Items.Add("Profaned Guardians");
                cboBossList.Items.Add("Dragonfolly");
                cboBossList.Items.Add("Providence, The Profaned Goddess");
                cboBossList.Items.Add("Storm Weaver");
                cboBossList.Items.Add("Ceaseless Void");
                cboBossList.Items.Add("Signus, Envoy of the Devourer");
                cboBossList.Items.Add("Polterghast");
                cboBossList.Items.Add("The Old Duke");
                cboBossList.Items.Add("The Devourer of Gods");
                cboBossList.Items.Add("Yharon, Dragon of Rebirth");
                cboBossList.Items.Add("Exo Mechs");
                cboBossList.Items.Add("Supreme Witch, Calamitas");
                cboBossList.Items.Add("Giant Clam");
                cboBossList.Items.Add("Cragmaw Mire");
                cboBossList.Items.Add("Great Sand Shark");
                cboBossList.Items.Add("Mauler");
                cboBossList.Items.Add("Nuclear Terror");
                cboBossList.SelectedIndex = 0;
                cboDifficultyList.Items.Clear();
                cboDifficultyList.Items.Add("Select a difficulty");
                cboDifficultyList.Items.Add("Classic");
                cboDifficultyList.Items.Add("Expert");
                cboDifficultyList.Items.Add("Revengeance");
                cboDifficultyList.Items.Add("Death");
                cboDifficultyList.Items.Add("Master");
                cboDifficultyList.Items.Add("Master + Revengeance");
                cboDifficultyList.Items.Add("Master + Death");
                cboDifficultyList.SelectedIndex = 0;
            }
            else if (cboGameList.SelectedIndex == 3) //the mod Thorium
            {
                cboBossList.Items.Clear();
                cboBossList.Items.Add("Select a boss");
                cboBossList.Items.Add("The Grand Thunder Bird");
                cboBossList.Items.Add("Queen Jellyfish");
                cboBossList.Items.Add("Viscount");
                cboBossList.Items.Add("Granite Energy Storm");
                cboBossList.Items.Add("Buried Champion");
                cboBossList.Items.Add("Star Scouter");
                cboBossList.Items.Add("Borean Strider");
                cboBossList.Items.Add("Fallen Beholder");
                cboBossList.Items.Add("Lich");
                cboBossList.Items.Add("Forgotten One");
                cboBossList.Items.Add("The Primoridals");
                cboBossList.Items.Add("Patch Werk");
                cboBossList.Items.Add("Corpse Bloom");
                cboBossList.Items.Add("Illusionist");
                cboBossList.SelectedIndex = 0;
                cboDifficultyList.Items.Clear();
                cboDifficultyList.Items.Add("Select a difficulty");
                cboDifficultyList.Items.Add("Classic");
                cboDifficultyList.Items.Add("Expert");
                cboDifficultyList.Items.Add("Master");
                cboDifficultyList.SelectedIndex = 0;
            }
            else if (cboGameList.SelectedIndex == 4) //the mod Fargo's Souls
            {
                cboBossList.Items.Clear();
                cboBossList.Items.Add("Select a boss");
                cboBossList.Items.Add("Trojan Squirrel");
                cboBossList.Items.Add("Cursed Coffin");
                cboBossList.Items.Add("Deviantt");
                cboBossList.Items.Add("Banished Baron");
                cboBossList.Items.Add("Lifelight");
                cboBossList.Items.Add("Eridanus");
                cboBossList.Items.Add("Abominationn");
                cboBossList.Items.Add("Mutant");
                cboBossList.SelectedIndex = 0;
                cboDifficultyList.Items.Clear();
                cboDifficultyList.Items.Add("Select a difficulty");
                cboDifficultyList.Items.Add("Classic");
                cboDifficultyList.Items.Add("Expert");
                cboDifficultyList.Items.Add("Master");
                cboDifficultyList.SelectedIndex = 0;
            }
        }

        private void btnAccept_clicked(object sender, EventArgs e)
        {
            if (ValidateInputs.IsValidSelection(cboGameList.SelectedIndex, cboBossList.SelectedIndex, cboDifficultyList.SelectedIndex))
            {
                terra.gameValue = cboGameList.SelectedIndex - 1;
                terra.bossNameValue = cboBossList.SelectedIndex - 1;
                terra.bossDifficultyValue = cboDifficultyList.SelectedIndex - 1;
                terra.gameText = "Game: " + cboGameList.SelectedItem;
                terra.bossNameText = "Boss: " + cboBossList.SelectedItem;
                terra.bossDifficultyText = "Difficulty: " + cboDifficultyList.SelectedItem;
                _bossLibrary.ReceiveInfo();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please make a selection for all three boxes");
            }
        }
    }
}
