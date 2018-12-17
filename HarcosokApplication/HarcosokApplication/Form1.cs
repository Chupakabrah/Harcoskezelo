using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarcosokApplication
{
    public partial class KarakterLetrehozFrm : Form
    {
        private const string DBLetrehoz = @"create database if not exists cs_harcosok";

        private const string Harcosok = @"create table if not exists cs_harcosok.harcosok (
                                                                                id int primary key auto_increment,
                                                                                nev varchar(20) not null unique,
                                                                                letrehozas date not null)";

        private const string Kepessegek = @"create table if not exists cs_harcosok.kepessegek (
                                                                                id int primary key auto_increment,
                                                                                nev varchar(30) not null,
                                                                                leiras varchar(100) not null,
                                                                                harcos_id int,
                                                                                FOREIGN KEY (harcos_id) REFERENCES harcosok(id))";


        private string connString = "Server=localhost;Database=cs_harcosok;Uid=root;Password=";
        private MySqlConnection conn;

        public KarakterLetrehozFrm()
        {
            InitializeComponent();

            conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                var cmd_dbLetrehozas = conn.CreateCommand();
                cmd_dbLetrehozas.CommandText = DBLetrehoz;
                cmd_dbLetrehozas.ExecuteNonQuery();
                var cmd_HarcosokLetrehozas = conn.CreateCommand();
                cmd_HarcosokLetrehozas.CommandText = Harcosok;
                cmd_HarcosokLetrehozas.ExecuteNonQuery();
                var cmd_KepessegekLetrehozas = conn.CreateCommand();
                cmd_KepessegekLetrehozas.CommandText = Kepessegek;
                cmd_KepessegekLetrehozas.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show("Nincs kapcsolat a szerverrel!", "Kapcsolat hiba", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                this.Enabled = false;
            }
            HarcosListazas();
            HasznaloComboBoxLoad();
            modifyDescriptionBtn.Enabled = false;
            deleteWarriorBtn.Enabled = false;
            deleteAbilityBtn.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            warriorsListBox.Items.Clear();
            var cmd_Ellenorzes = conn.CreateCommand();
            cmd_Ellenorzes.CommandText = "select count(*) from cs_harcosok.harcosok where nev = @nev";
            cmd_Ellenorzes.Parameters.AddWithValue("@nev", warriorNameTxtBox.Text);
            var db_sor = (long)cmd_Ellenorzes.ExecuteScalar();

            if (warriorNameTxtBox.Text == "" || warriorNameTxtBox == null)
            {
                MessageBox.Show("Kérem adja meg a harcos nevét!");
            }
            else
            {
                if (db_sor >= 1)
                {
                    MessageBox.Show("A karakternév már foglalt!");
                }
                else
                {
                    var cmd_WarriorName = conn.CreateCommand();
                    cmd_WarriorName.CommandText = "insert into cs_harcosok.harcosok (nev, letrehozas) values (@nev, @datum)";
                    cmd_WarriorName.Parameters.AddWithValue("@nev", warriorNameTxtBox.Text);
                    cmd_WarriorName.Parameters.AddWithValue("@datum", DateTime.Now);
                    cmd_WarriorName.ExecuteNonQuery();
                    MessageBox.Show("A karakter fel lett véve!");
                    warriorNameTxtBox.Clear();
                }
            }
            HarcosListazas();
            HasznaloComboBoxLoad();
            abilitiesListBox.Items.Clear();
            abilityDescriptionRTxtBox.Clear();
            modifyDescriptionBtn.Enabled = false;
            deleteWarriorBtn.Enabled = false;
            deleteAbilityBtn.Enabled = false;
        }

        private void HasznaloComboBoxLoad()
        {

            var cmd_isEmptyEllenorzes = conn.CreateCommand();
            cmd_isEmptyEllenorzes.CommandText = "select count(nev) from cs_harcosok.harcosok";
            var sorokSzama = (long)cmd_isEmptyEllenorzes.ExecuteScalar();
            if (sorokSzama == 0)
            {
                kepessegLetrehozGrpBox.Enabled = false;
                abilityDescriptionRTxtBox.Enabled = false;
            }
            else
            {
                kepessegLetrehozGrpBox.Enabled = true;
                var cmd_Karakterek = conn.CreateCommand();
                cmd_Karakterek.CommandText = "select nev from cs_harcosok.harcosok";
                MySqlDataReader reader;
                using (reader = cmd_Karakterek.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!hasznaloComboBox.Items.Contains(reader["nev"]))
                        {
                            hasznaloComboBox.Items.Add(reader["nev"]);
                        }
                    }
                }
            }
        }

        private void addAbilityBtn_Click(object sender, EventArgs e)
        {
            warriorsListBox.Items.Clear();
            if (abilityNameTxtBox.Text == "" || abilityNameTxtBox == null || hasznaloComboBox.SelectedItem == null || createAbilityDescriptionRTxtBox.Text == "" || createAbilityDescriptionRTxtBox.Text == null)
            {
                MessageBox.Show("Kérem töltsön ki mindent!");
            }
            else
            {
                string description = "";
                string warriorName = hasznaloComboBox.SelectedItem.ToString();
                int warriorID = 0;
                var cmd_warriorID = conn.CreateCommand();
                cmd_warriorID.CommandText = "select id from cs_harcosok.harcosok where nev = @nev";
                cmd_warriorID.Parameters.AddWithValue("@nev", warriorName);
                MySqlDataReader reader;
                using (reader = cmd_warriorID.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        warriorID = (int)reader["id"];
                    }
                }

                for (int i = 0; i < createAbilityDescriptionRTxtBox.Lines.Count(); i++)
                {
                    description += createAbilityDescriptionRTxtBox.Lines[i];
                }

                var cmd_AbilityName = conn.CreateCommand();
                cmd_AbilityName.CommandText = "insert into cs_harcosok.kepessegek (nev, leiras, harcos_id) values (@nev, @leiras, @id)";
                cmd_AbilityName.Parameters.AddWithValue("@nev", abilityNameTxtBox.Text);
                cmd_AbilityName.Parameters.AddWithValue("@leiras", description);
                cmd_AbilityName.Parameters.AddWithValue("@id", warriorID);
                cmd_AbilityName.ExecuteNonQuery();

                hasznaloComboBox.ResetText();
                abilityNameTxtBox.Clear();
                createAbilityDescriptionRTxtBox.Clear();

                MessageBox.Show("A képesség fel lett véve!");

            }
            HarcosListazas();
            HasznaloComboBoxLoad();
            abilitiesListBox.Items.Clear();
            abilityDescriptionRTxtBox.Clear();
            modifyDescriptionBtn.Enabled = false;
            deleteWarriorBtn.Enabled = false;
            deleteAbilityBtn.Enabled = false;
        }

        private void HarcosListazas()
        {
            var cmd_WarriorList = conn.CreateCommand();
            cmd_WarriorList.CommandText = "select nev, letrehozas from cs_harcosok.harcosok";
            MySqlDataReader reader;
            using (reader = cmd_WarriorList.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!warriorsListBox.Items.Contains(reader["nev"]))
                    {
                        var nev = reader["nev"];
                        var date = string.Format("{0:d}", reader["letrehozas"]);

                        warriorsListBox.Items.Add(nev + "\t" + date);
                    }
                }
            }
        }

        private void warriorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            abilityDescriptionRTxtBox.Clear();
            abilitiesListBox.Items.Clear();
            if (warriorsListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                string warriorName = warriorsListBox.Items[warriorsListBox.SelectedIndex].ToString();
                int warriorName_Length = warriorName.Length - 14;
                var cmd_WarriorSelected = conn.CreateCommand();
                cmd_WarriorSelected.CommandText = "select kepessegek.nev nev from kepessegek inner join harcosok on kepessegek.harcos_id = harcosok.id where harcosok.nev like @hnev";
                //Debug ---> Output (Console)
                //Debug.WriteLine(String.Format("'{0}'", warriorName.Substring(0, warriorName_Length)));
                cmd_WarriorSelected.Parameters.AddWithValue("@hnev", warriorName.Substring(0, warriorName_Length));
                MySqlDataReader reader;

                using (reader = cmd_WarriorSelected.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        abilitiesListBox.Items.Add(reader["nev"]);
                    }
                }

                if (abilitiesListBox.Items.Count > 0)
                {
                    abilitiesListBox.SelectedIndex = 0;
                    modifyDescriptionBtn.Enabled = true;
                    deleteAbilityBtn.Enabled = true;
                }
                else
                {
                    hasznaloComboBox.Items.Clear();
                    modifyDescriptionBtn.Enabled = false;
                    deleteAbilityBtn.Enabled = false;
                    HasznaloComboBoxLoad();
                }

                deleteWarriorBtn.Enabled = true;
            }

        }

        private void abilitiesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            abilityDescriptionRTxtBox.Clear();
            string abilityName = abilitiesListBox.Items[abilitiesListBox.SelectedIndex].ToString();
            var cmd_AbilitySelected = conn.CreateCommand();
            cmd_AbilitySelected.CommandText = "select leiras from kepessegek where nev like @Anev";
            cmd_AbilitySelected.Parameters.AddWithValue("@Anev", abilityName);
            MySqlDataReader reader;

            using (reader = cmd_AbilitySelected.ExecuteReader())
            {
                while (reader.Read())
                {
                    abilityDescriptionRTxtBox.Text += reader["leiras"];
                }
            }
            modifyDescriptionBtn.Enabled = true;
            abilityDescriptionRTxtBox.Enabled = true;
        }

        /// <summary>
        /// A kepessegek tábla ondelete = cascade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteWarriorBtn_Click(object sender, EventArgs e)
        {
            hasznaloComboBox.Items.Clear();
            DialogResult deleteForSure = MessageBox.Show("Biztos hogy törli?", "Törlés", MessageBoxButtons.YesNo);
            if (deleteForSure == DialogResult.Yes)
            {
                string warriorName = warriorsListBox.Items[warriorsListBox.SelectedIndex].ToString();
                int warriorName_Length = warriorName.Length - 14;
                var cmd_DeleteWarrior = conn.CreateCommand();
                cmd_DeleteWarrior.CommandText = "delete from harcosok where harcosok.nev = @Wnev";
                cmd_DeleteWarrior.Parameters.AddWithValue("@Wnev", warriorName.Substring(0, warriorName_Length));
                cmd_DeleteWarrior.ExecuteNonQuery();
                warriorsListBox.Items.Clear();
                abilitiesListBox.Items.Clear();
                HarcosListazas();
                abilityDescriptionRTxtBox.Clear();
            }

            if (warriorsListBox.Items.Count == 0)
            {
                deleteWarriorBtn.Enabled = false;
                deleteAbilityBtn.Enabled = false;
                modifyDescriptionBtn.Enabled = false;
                abilityDescriptionRTxtBox.Enabled = false;
                kepessegLetrehozGrpBox.Enabled = false;
            }
            HasznaloComboBoxLoad();
        }

        /// <summary>
        /// A kepessegek tábla onupdate = cascade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifyDescriptionBtn_Click(object sender, EventArgs e)
        {

            string abilityName = abilitiesListBox.Items[abilitiesListBox.SelectedIndex].ToString();
            string newAbilityDescription = abilityDescriptionRTxtBox.Text;
            if (abilityDescriptionRTxtBox.Text == "" || abilityDescriptionRTxtBox == null)
            {
                MessageBox.Show("A leírás üresen nem maradhat!");
            }
            else
            {
                DialogResult newDescription = MessageBox.Show("Biztos módosítja?", "Módosítás", MessageBoxButtons.YesNo);
                if (newDescription == DialogResult.Yes)
                {
                    var cmd_UpdateAbilityDescription = conn.CreateCommand();
                    cmd_UpdateAbilityDescription.CommandText = "update kepessegek set leiras = @Ujleiras where nev = @Anev";
                    cmd_UpdateAbilityDescription.Parameters.AddWithValue("@Ujleiras", newAbilityDescription);
                    cmd_UpdateAbilityDescription.Parameters.AddWithValue("@Anev", abilityName);
                    cmd_UpdateAbilityDescription.ExecuteNonQuery();
                    MessageBox.Show("Sikeres módosítás!");
                }
            }

        }

        private void deleteAbilityBtn_Click(object sender, EventArgs e)
        {
            DialogResult deleteForSure = MessageBox.Show("Biztos hogy törli?", "Törlés", MessageBoxButtons.YesNo);
            if (deleteForSure == DialogResult.Yes)
            {
                string abilityName = abilitiesListBox.Items[abilitiesListBox.SelectedIndex].ToString();
                var cmd_DeleteAbility = conn.CreateCommand();
                cmd_DeleteAbility.CommandText = "delete from kepessegek where kepessegek.nev = @Anev";
                cmd_DeleteAbility.Parameters.AddWithValue("@Anev", abilityName);
                cmd_DeleteAbility.ExecuteNonQuery();
                warriorsListBox.Items.Clear();
                abilitiesListBox.Items.Clear();
                abilityDescriptionRTxtBox.Clear();
                HarcosListazas();

                if (abilitiesListBox.Items.Count > 0)
                {
                    abilitiesListBox.SelectedIndex = 0;
                    modifyDescriptionBtn.Enabled = true;
                    deleteAbilityBtn.Enabled = true;
                }
                else
                {
                    modifyDescriptionBtn.Enabled = false;
                    deleteAbilityBtn.Enabled = false;
                }
            }
        }
    }
}
