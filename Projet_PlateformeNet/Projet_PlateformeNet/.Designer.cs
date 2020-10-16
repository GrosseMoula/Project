namespace Projet_PlateformeNet
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Title = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView_alarme = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBox_event = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_create = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_filter = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Records_Page = new System.Windows.Forms.TabPage();
            this.ExportCsv_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Seconds_RadioButton = new System.Windows.Forms.RadioButton();
            this.Minutes_RadioButton = new System.Windows.Forms.RadioButton();
            this.Hours_RadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ID_ComboBox = new System.Windows.Forms.ComboBox();
            this.Records_Datagrid = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurerLeCOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurerLesAlarmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUnProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alarme)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Records_Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Records_Datagrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(541, 40);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(95, 17);
            this.Title.TabIndex = 0;
            this.Title.Text = "Station météo";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Controls.Add(this.tabPage4);
            this.TabControl.Controls.Add(this.Records_Page);
            this.TabControl.Location = new System.Drawing.Point(12, 89);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1008, 401);
            this.TabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Données ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(951, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1000, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graphique";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(58, 23);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(851, 326);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView_alarme);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1000, 372);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Définition d\'alarmes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView_alarme
            // 
            this.dataGridView_alarme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_alarme.Location = new System.Drawing.Point(84, 43);
            this.dataGridView_alarme.Name = "dataGridView_alarme";
            this.dataGridView_alarme.RowHeadersWidth = 51;
            this.dataGridView_alarme.RowTemplate.Height = 24;
            this.dataGridView_alarme.Size = new System.Drawing.Size(807, 295);
            this.dataGridView_alarme.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.comboBox_event);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.button_create);
            this.tabPage4.Controls.Add(this.button_update);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.comboBox_filter);
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1000, 372);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Log";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBox_event
            // 
            this.comboBox_event.FormattingEnabled = true;
            this.comboBox_event.Location = new System.Drawing.Point(454, 333);
            this.comboBox_event.Name = "comboBox_event";
            this.comboBox_event.Size = new System.Drawing.Size(121, 24);
            this.comboBox_event.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of event";
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(855, 333);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(102, 30);
            this.button_create.TabIndex = 4;
            this.button_create.Text = "Create .CSV";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(732, 333);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(102, 30);
            this.button_update.TabIndex = 3;
            this.button_update.Text = "Update grid";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type filter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_filter
            // 
            this.comboBox_filter.FormattingEnabled = true;
            this.comboBox_filter.Location = new System.Drawing.Point(94, 333);
            this.comboBox_filter.Name = "comboBox_filter";
            this.comboBox_filter.Size = new System.Drawing.Size(121, 24);
            this.comboBox_filter.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(51, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(906, 291);
            this.dataGridView2.TabIndex = 0;
            // 
            // Records_Page
            // 
            this.Records_Page.Controls.Add(this.ExportCsv_btn);
            this.Records_Page.Controls.Add(this.Delete_btn);
            this.Records_Page.Controls.Add(this.Add_btn);
            this.Records_Page.Controls.Add(this.Seconds_RadioButton);
            this.Records_Page.Controls.Add(this.Minutes_RadioButton);
            this.Records_Page.Controls.Add(this.Hours_RadioButton);
            this.Records_Page.Controls.Add(this.label3);
            this.Records_Page.Controls.Add(this.ID_ComboBox);
            this.Records_Page.Controls.Add(this.Records_Datagrid);
            this.Records_Page.Location = new System.Drawing.Point(4, 25);
            this.Records_Page.Name = "Records_Page";
            this.Records_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Records_Page.Size = new System.Drawing.Size(1000, 372);
            this.Records_Page.TabIndex = 4;
            this.Records_Page.Text = "Records";
            this.Records_Page.UseVisualStyleBackColor = true;
            // 
            // ExportCsv_btn
            // 
            this.ExportCsv_btn.Location = new System.Drawing.Point(818, 293);
            this.ExportCsv_btn.Name = "ExportCsv_btn";
            this.ExportCsv_btn.Size = new System.Drawing.Size(155, 34);
            this.ExportCsv_btn.TabIndex = 8;
            this.ExportCsv_btn.Text = "Export to .CSV";
            this.ExportCsv_btn.UseVisualStyleBackColor = true;
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(594, 317);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(111, 34);
            this.Delete_btn.TabIndex = 7;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(594, 254);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(111, 34);
            this.Add_btn.TabIndex = 6;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Seconds_RadioButton
            // 
            this.Seconds_RadioButton.AutoSize = true;
            this.Seconds_RadioButton.Location = new System.Drawing.Point(299, 330);
            this.Seconds_RadioButton.Name = "Seconds_RadioButton";
            this.Seconds_RadioButton.Size = new System.Drawing.Size(141, 21);
            this.Seconds_RadioButton.TabIndex = 5;
            this.Seconds_RadioButton.TabStop = true;
            this.Seconds_RadioButton.Text = "Records Seconds";
            this.Seconds_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Minutes_RadioButton
            // 
            this.Minutes_RadioButton.AutoSize = true;
            this.Minutes_RadioButton.Location = new System.Drawing.Point(299, 293);
            this.Minutes_RadioButton.Name = "Minutes_RadioButton";
            this.Minutes_RadioButton.Size = new System.Drawing.Size(135, 21);
            this.Minutes_RadioButton.TabIndex = 4;
            this.Minutes_RadioButton.TabStop = true;
            this.Minutes_RadioButton.Text = "Records Minutes";
            this.Minutes_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Hours_RadioButton
            // 
            this.Hours_RadioButton.AutoSize = true;
            this.Hours_RadioButton.Location = new System.Drawing.Point(299, 255);
            this.Hours_RadioButton.Name = "Hours_RadioButton";
            this.Hours_RadioButton.Size = new System.Drawing.Size(124, 21);
            this.Hours_RadioButton.TabIndex = 3;
            this.Hours_RadioButton.TabStop = true;
            this.Hours_RadioButton.Text = "Records Hours";
            this.Hours_RadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selected ID : ";
            // 
            // ID_ComboBox
            // 
            this.ID_ComboBox.FormattingEnabled = true;
            this.ID_ComboBox.Location = new System.Drawing.Point(70, 303);
            this.ID_ComboBox.Name = "ID_ComboBox";
            this.ID_ComboBox.Size = new System.Drawing.Size(121, 24);
            this.ID_ComboBox.TabIndex = 1;
            // 
            // Records_Datagrid
            // 
            this.Records_Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Records_Datagrid.Location = new System.Drawing.Point(18, 23);
            this.Records_Datagrid.Name = "Records_Datagrid";
            this.Records_Datagrid.RowHeadersWidth = 51;
            this.Records_Datagrid.RowTemplate.Height = 24;
            this.Records_Datagrid.Size = new System.Drawing.Size(955, 207);
            this.Records_Datagrid.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1031, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Activer/Desactiver le timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1222, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.configurerLeCOMToolStripMenuItem,
            this.configurerLesAlarmesToolStripMenuItem,
            this.créerUnProfilToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.ajouterToolStripMenuItem.Text = "Configurer des données";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // configurerLeCOMToolStripMenuItem
            // 
            this.configurerLeCOMToolStripMenuItem.Name = "configurerLeCOMToolStripMenuItem";
            this.configurerLeCOMToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.configurerLeCOMToolStripMenuItem.Text = "Configurer le COM";
            // 
            // configurerLesAlarmesToolStripMenuItem
            // 
            this.configurerLesAlarmesToolStripMenuItem.Name = "configurerLesAlarmesToolStripMenuItem";
            this.configurerLesAlarmesToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.configurerLesAlarmesToolStripMenuItem.Text = "Configurer les alarmes";
            this.configurerLesAlarmesToolStripMenuItem.Click += new System.EventHandler(this.configurerLesAlarmesToolStripMenuItem_Click);
            // 
            // créerUnProfilToolStripMenuItem
            // 
            this.créerUnProfilToolStripMenuItem.Name = "créerUnProfilToolStripMenuItem";
            this.créerUnProfilToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.créerUnProfilToolStripMenuItem.Text = "Créer un profil";
            this.créerUnProfilToolStripMenuItem.Click += new System.EventHandler(this.créerUnProfilToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(658, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Activer le timer pour créer des données";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 570);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alarme)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Records_Page.ResumeLayout(false);
            this.Records_Page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Records_Datagrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurerLeCOMToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView_alarme;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem configurerLesAlarmesToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_filter;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.ComboBox comboBox_event;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem créerUnProfilToolStripMenuItem;
        private System.Windows.Forms.TabPage Records_Page;
        private System.Windows.Forms.Button ExportCsv_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.RadioButton Seconds_RadioButton;
        private System.Windows.Forms.RadioButton Minutes_RadioButton;
        private System.Windows.Forms.RadioButton Hours_RadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ID_ComboBox;
        private System.Windows.Forms.DataGridView Records_Datagrid;
        private System.Windows.Forms.Label label4;
    }
}

