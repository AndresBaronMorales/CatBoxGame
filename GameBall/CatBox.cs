using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBall
{
    public partial class CatBox : Form
    {
        private int indexPlayer;
        private string namePlayer;
        private int openBoxes;
        private int numRadandom;
        

        public CatBox()
        {
            InitializeComponent();
            InsertDataDGV();
            LoadCbxData();
        }

        //Functions
        private void Clear()
        {
            txtRegisterPlayer.Text = "";
            cbxPlayers.Items.Clear();
        }

        private void EnableBtnBoxes(bool state) {
            btnBox1.Enabled = state;
            btnBox2.Enabled = state;
            btnBox3.Enabled = state;
        }

        private void EnabledPlayitems(bool state)
        {
            txtRegisterPlayer.Enabled = state;
            btnRegister.Enabled = state;
            cbxPlayers.Enabled = state;
            btnPlay.Enabled = state;
        }

        private void VisibleBtnBoxes(bool state) {
            btnBox1.Visible = state;
            btnBox2.Visible = state;
            btnBox3.Visible = state;
        }

        private void VisibleBoxOpen(bool state) {
            boxOpen1.Visible = state;
            boxOpen2.Visible = state;
            boxOpen3.Visible = state;
        }

        private void VisibleBoxCat(bool state) {
            boxCatOpen1.Visible = state;
            boxCatOpen2.Visible = state;
            boxCatOpen3.Visible = state;
        }

        private void VisibleGameResult(bool state) {
            BoxResultGameOverL.Visible = state;
            BoxResultGameOverR.Visible = state;
            BoxResult10L.Visible = state;
            BoxResult10R.Visible = state;
            BoxResult5L.Visible = state;
            BoxResult5R.Visible = state;
        }

        private int GetIndexPlayerDgv(string player) {
            int index = -1;
            for (int i = 0; i < dgvClassification.Rows.Count - 1; i++)
            {
                if (dgvClassification.Rows[i].Cells[0].Value.ToString() == player) {
                    index = i;
                    return index;
                }
            }
            return index;
        }

        private void GetResultInfo()
        {
            if (this.openBoxes == 1)
            {
                BoxResult10L.Visible = true;
                BoxResult10R.Visible = true;
            }
            else if (this.openBoxes == 2)
            {
                BoxResult5L.Visible = true;
                BoxResult5R.Visible = true;
            }
            else
            {
                BoxResultGameOverL.Visible = true;
                BoxResultGameOverR.Visible = true;
            }
        }

        private void LoadCbxData() {
            for (int i = 0; i < dgvClassification.Rows.Count - 1; i++)
            {
                cbxPlayers.Items.Add(dgvClassification.Rows[i].Cells[0].Value.ToString());
            }
        }

        private void AddIntent(int cell) => dgvClassification.Rows[this.indexPlayer].Cells[cell].Value = Convert.ToInt32(dgvClassification.Rows[this.indexPlayer].Cells[cell].Value) + 1;

        private void AddPoints(int points) => dgvClassification.Rows[this.indexPlayer].Cells[1].Value = Convert.ToInt32(dgvClassification.Rows[this.indexPlayer].Cells[1].Value) + points;

        private int NumRandom() => new Random().Next(1, 4);

        private void PlayBoxes(Button btnBox, Panel boxCat, Panel boxOpen, int num)
        {
            this.openBoxes++;
            AddIntent(3);
            btnBox.Enabled = false;
            btnBox.Visible = false;

            if (this.numRadandom == num)
            {
                boxCat.Visible = true;
                GetResultInfo();
                EnableBtnBoxes(false);

                EnabledPlayitems(true);

                if (this.openBoxes == 1)
                {
                    AddPoints(10);
                }
                else {
                    AddPoints(5);
                }
            }
            else if (this.openBoxes == 2 && this.numRadandom != num)
            {
                this.openBoxes = 5;
                boxOpen.Visible = true;
                GetResultInfo();
                EnableBtnBoxes(false);

                EnabledPlayitems(true);
                AddPoints(-10);
            }
            else
            {
                boxOpen.Visible = true;
            }
        }


        //Events
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtRegisterPlayer.Text != "")
            {
                dgvClassification.Rows.Add(txtRegisterPlayer.Text);
                Clear();

                LoadCbxData();
            }
            else {
                MessageBox.Show("Write the name of the player");
            }
        }

        private void cbxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPlay.Enabled = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.namePlayer = cbxPlayers.SelectedItem.ToString();
            this.indexPlayer = GetIndexPlayerDgv(this.namePlayer);
            this.numRadandom = NumRandom();
            this.openBoxes = 0;

            AddIntent(2);

            EnabledPlayitems(false);
            VisibleGameResult(false);
            VisibleBoxOpen(false);
            VisibleBoxCat(false);
            VisibleBtnBoxes(true);
            EnableBtnBoxes(true);
        }

        private void btnBox1_Click(object sender, EventArgs e)
        {
            PlayBoxes(btnBox1,boxCatOpen1,boxOpen1,1);
        }

        private void btnBox2_Click(object sender, EventArgs e)
        {
            PlayBoxes(btnBox2,boxCatOpen2,boxOpen2, 2);
        }

        private void btnBox3_Click(object sender, EventArgs e)
        {
            PlayBoxes(btnBox3,boxCatOpen3,boxOpen3, 3);
        }


        //Load data DGV
        private void InsertDataDGV() {
            string[] namesInsert = { "Pedro", "Ramón", "Mario", "Mauricio", "Ana", "Claudia", "Nélida", "Susana" };
            int[] points = { 10, 15, 30, 10, -30, 30, 30, -10};
            int[] attemps = { 10, 8, 9, 8, 8, 4, 4, 7};
            int[] openBoxes = { 16, 15, 15, 13, 15, 6, 6, 11};

            for (int i = 0; i < namesInsert.Length; i++) {
                dgvClassification.Rows.Add(namesInsert[i]);
                dgvClassification.Rows[i].Cells[1].Value = points[i];
                dgvClassification.Rows[i].Cells[2].Value = attemps[i];
                dgvClassification.Rows[i].Cells[3].Value = openBoxes[i];
            }
        }        
    }
}
