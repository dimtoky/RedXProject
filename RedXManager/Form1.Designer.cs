namespace RedXManager
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.redXprojectDataSet = new RedXManager.RedXprojectDataSet();
            this.redXprojectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textTableTableAdapter = new RedXManager.RedXprojectDataSetTableAdapters.textTableTableAdapter();
            this.logTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logTableTableAdapter = new RedXManager.RedXprojectDataSetTableAdapters.LogTableTableAdapter();
            this.textTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redXprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redXprojectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(336, 497);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.LightGreen;
            this.AddButton.Location = new System.Drawing.Point(435, 171);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(319, 56);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Ajouter";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.BackColor = System.Drawing.Color.Yellow;
            this.ModifyButton.Location = new System.Drawing.Point(435, 237);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(319, 56);
            this.ModifyButton.TabIndex = 2;
            this.ModifyButton.Text = "Modifier";
            this.ModifyButton.UseVisualStyleBackColor = false;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Salmon;
            this.DeleteButton.Location = new System.Drawing.Point(435, 303);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(319, 56);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Supprimer";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(398, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // redXprojectDataSet
            // 
            this.redXprojectDataSet.DataSetName = "RedXprojectDataSet";
            this.redXprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // redXprojectDataSetBindingSource
            // 
            this.redXprojectDataSetBindingSource.DataSource = this.redXprojectDataSet;
            this.redXprojectDataSetBindingSource.Position = 0;
            // 
            // textTableBindingSource
            // 
            this.textTableBindingSource.DataMember = "textTable";
            this.textTableBindingSource.DataSource = this.redXprojectDataSetBindingSource;
            // 
            // textTableTableAdapter
            // 
            this.textTableTableAdapter.ClearBeforeFill = true;
            // 
            // logTableBindingSource
            // 
            this.logTableBindingSource.DataMember = "LogTable";
            this.logTableBindingSource.DataSource = this.redXprojectDataSetBindingSource;
            // 
            // logTableTableAdapter
            // 
            this.logTableTableAdapter.ClearBeforeFill = true;
            // 
            // textTableBindingSource1
            // 
            this.textTableBindingSource1.DataMember = "textTable";
            this.textTableBindingSource1.DataSource = this.redXprojectDataSetBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(403, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zone de saisie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(807, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RedXManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redXprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redXprojectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource redXprojectDataSetBindingSource;
        private RedXprojectDataSet redXprojectDataSet;
        private System.Windows.Forms.BindingSource textTableBindingSource;
        private RedXprojectDataSetTableAdapters.textTableTableAdapter textTableTableAdapter;
        private System.Windows.Forms.BindingSource logTableBindingSource;
        private RedXprojectDataSetTableAdapters.LogTableTableAdapter logTableTableAdapter;
        private System.Windows.Forms.BindingSource textTableBindingSource1;
        private System.Windows.Forms.Label label1;
    }
}

