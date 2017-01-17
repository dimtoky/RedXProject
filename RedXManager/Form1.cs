using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataProviders;
using System.Diagnostics;
using System.Data.SqlClient;

namespace RedXManager
{
    public partial class Form1 : Form
    {
        //Declaration d'un objet de type ProcessLayer et ProcFactory
        private ProcessLayer Opcs;
        private DataSet dataS;
        private BindingSource oBs;
        ProcFactory factory;
       
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            factory = new ProcFactory();
            this.Opcs = factory.createProcess("RedX");
            this.dataS = new DataSet();
            this.oBs = new BindingSource();
            ModifyButton.Enabled = false;
            DeleteButton.Enabled = false;
            
        }


        //méthode au chargement du la fenétre
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.DataSource = oBs;
            this.charger();
          
            
        }

//Methode du bouton d'ajout
        private void AddButton_Click(object sender, EventArgs e)
        {
            Opcs.setText(textBox1.Text);
            this.charger();
        }

//Methode du bouton de modification
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.CurrentRow.Index;
            Opcs.updateText((int)dataS.Tables[0].Rows[index][0],textBox1.Text,"Tabletext");
            this.charger();
            ModifyButton.Enabled = false;
            DeleteButton.Enabled = false;
        }

//Methode du bouton de suppression
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.CurrentRow.Index;
            Opcs.deleteText((int)dataS.Tables[0].Rows[index][0]);
            this.charger();
            ModifyButton.Enabled = false;
            DeleteButton.Enabled = false;
            textBox1.Text = "";
        }

       
//méthode pour récuperer la table de la base de données et 
        private void charger()
        {
            this.dataS.Tables.Clear();
            try
            {
                this.dataS = this.Opcs.getText("TableText");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erreur Base de données Introuvable");

            }
            oBs.DataSource = this.dataS.Tables["TableText"];
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = this.dataGridView1.CurrentRow.Index;
            textBox1.Text = dataS.Tables[0].Rows[index][1].ToString();
            ModifyButton.Enabled = true;
            DeleteButton.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
