namespace BASICS
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.txtData = new System.Windows.Forms.TextBox();
            this.cboData = new System.Windows.Forms.ComboBox();
            this.btnCombo = new System.Windows.Forms.Button();
            this.lblGrid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(12, 12);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(480, 20);
            this.txtInsert.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 38);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(480, 23);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Inserir";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 80);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(480, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "LoadGrid";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(12, 110);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(480, 270);
            this.grdData.TabIndex = 3;
            this.grdData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellDoubleClick);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(12, 402);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(480, 20);
            this.txtData.TabIndex = 4;
            // 
            // cboData
            // 
            this.cboData.FormattingEnabled = true;
            this.cboData.Location = new System.Drawing.Point(12, 470);
            this.cboData.Name = "cboData";
            this.cboData.Size = new System.Drawing.Size(480, 21);
            this.cboData.TabIndex = 5;
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(12, 441);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(480, 23);
            this.btnCombo.TabIndex = 6;
            this.btnCombo.Text = "Carregar Combo";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // lblGrid
            // 
            this.lblGrid.AutoSize = true;
            this.lblGrid.Location = new System.Drawing.Point(9, 386);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.Size = new System.Drawing.Size(307, 13);
            this.lblGrid.TabIndex = 7;
            this.lblGrid.Text = "Clique no código da célula para exibir o nome no textbox abaixo";
            
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Add(this.lblGrid);
            this.Controls.Add(this.btnCombo);
            this.Controls.Add(this.cboData);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtInsert);
            this.Name = "frmMain";
            this.Text = "BASICS";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.ComboBox cboData;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Label lblGrid;
    }
}

