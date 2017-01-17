using DataProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedXViewer
{
    public partial class Form1 : Form
    {

        private ProcessLayer Opcs;
        private DataSet dataS;
        private BindingSource oBs;
        ProcFactory factory;
        
        public Form1()
        {
            InitializeComponent();
            factory = new ProcFactory();
            this.Opcs = factory.createProcess("RedX");
            this.dataS = new DataSet();
            this.oBs = new BindingSource();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.DataSource = oBs;
            this.charger();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.CurrentRow.Index;
            textBox1.Text = dataS.Tables[0].Rows[index][1].ToString();
            
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

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
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
   
            }
        }

       
      
    }
}
