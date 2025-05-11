using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Text.Json;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

/*----------------------------------------------------
 * Program Title: Terraria Boss Information Provider - Intro to Progamming in C# Final Project
 * Author: Alex Grimm
 * Date: 5/4/25
 * Description: With the addition of 1 or 2 boss you can
 *              either display all the information related
 *              to a boss or get a comparison of comparable
 *              statistics, depending on the number of bosses
 *              added.
 * Usage: click the Add boss button to open a Boss Adder
 *        form. In this newly added form you first select
 *        from 1 of 4 games: Vanilla(the original game),
 *        Calamity, Thorium, and Fargo's Souls. Once you
 *        have selected a game the Boss and Difficulty
 *        combo boxes will fill with their games respective
 *        bosses and difficulties. Click the Accept button
 *        to send the data to the library. The info will first
 *        go to Boss 1 if it empty, if Boss 1 is full the
 *        info will go to Boss 2 instead. Once you have
 *        either 1 or 2 bosses added you can then click the
 *        Load stats button to either display all the the
 *        stats of a boss if there is only 1 boss added, and
 *        compare stats that are not lists if there are 2
 *        bosses added. There are also buttons to remove
 *        either boss 1 or boss 2.
 *-----------------------------------------------------
 */
namespace Final_TerrariaBossInfo_AKG
{
    public partial class frmBossLibrary : Form
    {
        public frmBossLibrary()
        {
            InitializeComponent();
        }
        // variables
        public int game1;
        public int bossName1;
        public int bossDifficulty1;
        private string bossNamePreserve1;
        public int game2;
        public int bossName2;
        public int bossDifficulty2;
        private string bossNamePreserve2;
        private int intMath;
        private decimal decimalMath;
        private DateOnly date1;
        private DateOnly date2;

        private static string ArraySearcher(int game, int category, int boss, int difficulty)
        {
            string msg = "";
            if (game == 0) // search the Vanilla Json file
            {
                string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
                string jsonPath = Path.Combine(projectRoot, "Json data", "vanilla_array.json");
                string json = File.ReadAllText(jsonPath);
                string[][][] data = JsonSerializer.Deserialize<string[][][]>(json);
                msg = data[category][boss][difficulty];
            }
            if (game == 1) // search the Calamity Json file
            {
                string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
                string jsonPath = Path.Combine(projectRoot, "Json data", "calamity_array.json");
                string json = File.ReadAllText(jsonPath);
                string[][][] data = JsonSerializer.Deserialize<string[][][]>(json);
                msg = data[category][boss][difficulty];
            }
            if (game == 2) // search the Thorium Json file
            {
                string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
                string jsonPath = Path.Combine(projectRoot, "Json data", "thorium_array.json");
                string json = File.ReadAllText(jsonPath);
                string[][][] data = JsonSerializer.Deserialize<string[][][]>(json);
                msg = data[category][boss][difficulty];
            }
            if (game == 3) // search the Fargo's Souls Json file
            {
                string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
                string jsonPath = Path.Combine(projectRoot, "Json data", "fargos_souls_array.json");
                string json = File.ReadAllText(jsonPath);
                string[][][] data = JsonSerializer.Deserialize<string[][][]>(json);
                msg = data[category][boss][difficulty];
            }
            return msg;
        }

        private void btnAddBoss_Click(object sender, EventArgs e)
        {
            if (lblGame1.Text == "Game: " || lblGame2.Text == "Game: ") // if either Boss 1 or Boss 2 is empty
            {
                var adderForm = new frmBossAdder(this);
                adderForm.ShowDialog();
                terra.gameCheck1 = lblGame1.Text;
                terra.gameCheck2 = lblGame2.Text;
            }
            else // if both Boss 1 and Boss 2 is full
            {
                MessageBox.Show($"Boss Library is full", "Action Denied");
            }
        }

        private void btnRemoveBoss1_Click(object sender, EventArgs e) // clears Boss 1's storage variables and labels
        {
            game1 = 0;
            bossName1 = 0;
            bossDifficulty1 = 0;
            lblGame1.Text = "Game: ";
            lblBossName1.Text = "Boss: ";
            lblBossDifficulty1.Text = "Difficulty: ";
        }

        private void btnRemoveBoss2_Click(object sender, EventArgs e) // clears Boss 2's storage variables and labels
        {
            game2 = 0;
            bossName2 = 0;
            bossDifficulty2 = 0;
            lblGame2.Text = "Game: ";
            lblBossName2.Text = "Boss: ";
            lblBossDifficulty2.Text = "Difficulty: ";
        }

        private void btnLoadStats_Click(object sender, EventArgs e)
        {
            string results = "";
            string msg = "";
            string tempStat1 = "";
            string tempStat2 = "";
            if (lblGame1.Text != "Game: " && lblGame2.Text == "Game: ") // if Boss 1 is full and Boss 2 is empty
            {
                for (int i = 0; i <= 9; i++)
                {
                    tempStat1 = ArraySearcher(game1, i, bossName1, bossDifficulty1);
                    switch (i)
                    {
                        case 0:
                            msg += "--Name--" + "\n" + tempStat1 + "\n\n";
                            break;
                        case 1:
                            msg += "--Summon Item--" + "\n" + tempStat1 + "\n\n";
                            break;
                        case 2:
                            msg += "--Total Health--" + "\n" + tempStat1 + "\n\n";
                            break;
                        case 3:
                            msg += "--Max Damage--" + "\n" + tempStat1 + "\n\n";
                            break;
                        case 4:
                            msg += "--Average Defense--" + "\n" + tempStat1 + "\n\n";
                            break;
                        case 5:
                            msg += "--Knockback Resistance--" + "\n" + tempStat1 + "\n\n";
                            break;
                        case 6:
                            msg += "--Immunities--" + "\n" + tempStat1 + "\n\n";
                            break;
                        case 7:
                            msg += "--On-Hit Debuffs--" + "\n" + "\n" + tempStat1 + "\n\n";
                            break;
                        case 8:
                            msg += "--Date Added--" + "\n" + tempStat1 + "\n\n";
                            break;
                        case 9:
                            msg += "--Loot--" + "\n" + tempStat1 + "\n\n";
                            break;
                    }
                }
            }
            if (lblGame2.Text != "Game: " && lblGame1.Text == "Game: ") // if Boss 2 is full and Boss 1 is empty
            {
                for (int i = 0; i <= 9; i++)
                {
                    tempStat1 = ArraySearcher(game2, i, bossName2, bossDifficulty2);
                    switch (i)
                    {
                        case 0:
                            msg += "--Name--" + "\n" + tempStat1 + "\n\n";
                            break;
                        case 1:
                            msg += "--Summon Item--" + "\n" + tempStat1 + "\n\n";
                            break;
                        case 2:
                            msg += "--Total Health--" + "\n" + tempStat1 + "\n\n";
                            break;
                        case 3:
                            msg += "--Max Damage--" + "\n" + tempStat1 + "\n\n";
                            break;
                        case 4:
                            msg += "--Average Defense--" + "\n" + tempStat1 + "\n\n";
                            break;
                        case 5:
                            msg += "--Knockback Resistance--" + "\n" + tempStat1 + "\n\n";
                            break;
                        case 6:
                            msg += "--Immunities--" + "\n" + tempStat1 + "\n\n";
                            break;
                        case 7:
                            msg += "--On-Hit Debuffs--" + "\n" + tempStat1 + "\n\n";
                            break;
                        case 8:
                            msg += "--Date Added--" + "\n" + tempStat1 + "\n\n";
                            break;
                        case 9:
                            msg += "--Loot--" + "\n" + tempStat1 + "\n\n";
                            break;
                    }
                }
            }
            if (lblGame1.Text != "Game: " && lblGame2.Text != "Game: ") // if both Boss 1 and Boss 2 are full
            {
                for (int i = 0; i <= 9; i++)
                {
                    tempStat1 = ArraySearcher(game1, i, bossName1, bossDifficulty1);
                    tempStat2 = ArraySearcher(game2, i, bossName2, bossDifficulty2);
                    switch (i)
                    {
                        case 0:
                            bossNamePreserve1 = tempStat1;
                            bossNamePreserve2 = tempStat2;
                            msg += "--Names--" + "\n" + "Boss 1: " + tempStat1 + "\n" + "Boss 2: " + tempStat2 + "\n\n";
                            break;
                        case 1:
                            msg += "--Summon Items--" + "\n" + bossNamePreserve1 + ": " + tempStat1 + "\n" + bossNamePreserve2 + ": " + tempStat2 + "\n\n";
                            break;
                        case 2:
                            msg += "--Total Health--" + "\n" + bossNamePreserve1 + ": " + tempStat1 + "\n" + bossNamePreserve2 + ": " + tempStat2 + "\n";
                            if (Convert.ToInt32(tempStat1) > Convert.ToInt32(tempStat2))
                            {
                                intMath = Convert.ToInt32(tempStat1) - Convert.ToInt32(tempStat2);
                                msg += $"{bossNamePreserve1} has {intMath} more health" + "\n\n";
                            }
                            if (Convert.ToInt32(tempStat1) < Convert.ToInt32(tempStat2))
                            {
                                intMath = Convert.ToInt32(tempStat2) - Convert.ToInt32(tempStat1);
                                msg += $"{bossNamePreserve2} has {intMath} more health" + "\n\n";
                            }
                            if (Convert.ToInt32(tempStat1) == Convert.ToInt32(tempStat2))
                            {
                                msg += $"{bossNamePreserve1} and {bossNamePreserve2} have the same total health" + "\n\n";
                            }
                            break;
                        case 3:
                            msg += "--Max Damage--" + "\n" + bossNamePreserve1 + ": " + tempStat1 + "\n" + bossNamePreserve2 + ": " + tempStat2 + "\n";
                            if (Convert.ToInt32(tempStat1) > Convert.ToInt32(tempStat2))
                            {
                                intMath = Convert.ToInt32(tempStat1) - Convert.ToInt32(tempStat2);
                                msg += $"{bossNamePreserve1} does {intMath} more damage in one strike" + "\n\n";
                            }
                            if (Convert.ToInt32(tempStat1) < Convert.ToInt32(tempStat2))
                            {
                                intMath = Convert.ToInt32(tempStat2) - Convert.ToInt32(tempStat1);
                                msg += $"{bossNamePreserve2} does {intMath} more damage in one strike" + "\n\n";
                            }
                            if (Convert.ToInt32(tempStat1) == Convert.ToInt32(tempStat2))
                            {
                                msg += $"{bossNamePreserve1} and {bossNamePreserve2} do the same damage in one strike" + "\n\n";
                            }
                            break;
                        case 4:
                            msg += "--Average Defense--" + "\n" + bossNamePreserve1 + ": " + tempStat1 + "\n" + bossNamePreserve2 + ": " + tempStat2 + "\n";
                            if (Convert.ToDecimal(tempStat1) > Convert.ToDecimal(tempStat2))
                            {
                                decimalMath = Convert.ToDecimal(tempStat1) - Convert.ToDecimal(tempStat2);
                                msg += $"{bossNamePreserve1} has {decimalMath} more defense" + "\n\n";
                            }
                            if (Convert.ToDecimal(tempStat1) < Convert.ToDecimal(tempStat2))
                            {
                                decimalMath = Convert.ToDecimal(tempStat2) - Convert.ToDecimal(tempStat1);
                                msg += $"{bossNamePreserve2} has {decimalMath} more defense" + "\n\n";
                            }
                            if (Convert.ToDecimal(tempStat1) == Convert.ToDecimal(tempStat2))
                            {
                                msg += $"{bossNamePreserve1} and {bossNamePreserve2} have the same defense" + "\n\n";
                            }
                            break;
                        case 5:
                            msg += "--Knockback Resistance--" + "\n" + bossNamePreserve1 + ": " + tempStat1 + "\n" + bossNamePreserve2 + ": " + tempStat2 + "\n";
                            tempStat1 = tempStat1.Replace("%", "");
                            tempStat2 = tempStat2.Replace("%", "");
                            if (Convert.ToInt32(tempStat1) > Convert.ToInt32(tempStat2))
                            {
                                intMath = Convert.ToInt32(tempStat1) - Convert.ToInt32(tempStat2);
                                msg += $"{bossNamePreserve1} has {intMath} more knockback resistance" + "\n\n";
                            }
                            if (Convert.ToInt32(tempStat1) < Convert.ToInt32(tempStat2))
                            {
                                intMath = Convert.ToInt32(tempStat2) - Convert.ToInt32(tempStat1);
                                msg += $"{bossNamePreserve2}% has {intMath} more knockback resistance" + "\n\n";
                            }
                            if (Convert.ToInt32(tempStat1) == Convert.ToInt32(tempStat2))
                            {
                                msg += $"{bossNamePreserve1} and {bossNamePreserve2} have the same knockback resistance" + "\n\n";
                            }
                            break;
                        case 8:
                            tempStat1 = tempStat1.Replace(".", ","); // corrects the csv format
                            tempStat2 = tempStat2.Replace(".", ","); // corrects the csv format
                            string[] suffixes = new[] { "st", "nd", "rd", "th" }; // all date suffixes
                            tempStat1 = Regex.Replace(tempStat1, @"(\d{1,2})(st|nd|rd|th)", "$1");
                            tempStat2 = Regex.Replace(tempStat2, @"(\d{1,2})(st|nd|rd|th)", "$1");


                            msg += "--Date Added--" + "\n" + bossNamePreserve1 + ": " + tempStat1 + "\n" + bossNamePreserve2 + ": " + tempStat2 + "\n";

                            var culture = new CultureInfo("en-US");

                            if (DateTime.Parse(tempStat1, culture) != DateTime.Parse(tempStat2, culture))
                            {
                                date1 = DateOnly.ParseExact(tempStat1, "MMMM d, yyyy", culture);
                                date2 = DateOnly.ParseExact(tempStat2, "MMMM d, yyyy", culture);
                                intMath = date2.DayNumber - date1.DayNumber;
                                intMath = Math.Abs(intMath);
                                msg += $"There were {intMath} days between the addition of {bossNamePreserve1} and {bossNamePreserve2}" + "\n\n";
                            }
                            if (DateTime.Parse(tempStat1, culture) == DateTime.Parse(tempStat2, culture))
                            {
                                msg += $"{bossNamePreserve1} and {bossNamePreserve2} were added on the same day" + "\n\n";
                            }
                            break;
                    }
                }
            
            }
            if (lblGame1.Text == "Game: " && lblGame2.Text == "Game: ") // if both Boss 1 and Boss 2 are empty
            {
                msg += "Please add at least one boss";
            }
            MessageBox.Show($"{msg}", "Resulting Information");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBossLibrary_Load(object sender, EventArgs e)
        {
            lblGame1.Text = "Game: ";
            lblGame2.Text = "Game: ";
            lblBossName1.Text = "Boss: ";
            lblBossName2.Text = "Boss: ";
            lblBossDifficulty1.Text = "Difficulty: ";
            lblBossDifficulty2.Text = "Difficulty: ";
        }
        public void ReceiveInfo()
        {
            if (lblGame1.Text == "Game: ") // if Boss 1 is empty
            {
                lblGame1.Text = terra.gameText;
                lblBossName1.Text = terra.bossNameText;
                lblBossDifficulty1.Text = terra.bossDifficultyText;
                game1 = terra.gameValue;
                bossName1 = terra.bossNameValue;
                bossDifficulty1 = terra.bossDifficultyValue;
            }
            else // if Boss 1 is full
            {
                lblGame2.Text = terra.gameText;
                lblBossName2.Text = terra.bossNameText;
                lblBossDifficulty2.Text = terra.bossDifficultyText;
                game2 = terra.gameValue;
                bossName2 = terra.bossNameValue;
                bossDifficulty2 = terra.bossDifficultyValue;
            }
            
        }
    }
}
