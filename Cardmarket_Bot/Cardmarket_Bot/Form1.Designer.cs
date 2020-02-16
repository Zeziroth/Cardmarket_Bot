namespace Cardmarket_Bot
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.listView_Game = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.listView_Expansion = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Single = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bulkBuyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView_Article = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox_Foil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_FirstEdition = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Condition = new System.Windows.Forms.ComboBox();
            this.listView_Bulk = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_Game = new System.Windows.Forms.Label();
            this.label_Expansion = new System.Windows.Forms.Label();
            this.label_Single = new System.Windows.Forms.Label();
            this.label_Article = new System.Windows.Forms.Label();
            this.label_Bulk = new System.Windows.Forms.Label();
            this.label_Bulk_Price = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Bulk = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Debug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView_Game
            // 
            this.listView_Game.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView_Game.FullRowSelect = true;
            this.listView_Game.HideSelection = false;
            this.listView_Game.Location = new System.Drawing.Point(12, 106);
            this.listView_Game.MultiSelect = false;
            this.listView_Game.Name = "listView_Game";
            this.listView_Game.Size = new System.Drawing.Size(151, 377);
            this.listView_Game.TabIndex = 1;
            this.listView_Game.UseCompatibleStateImageBehavior = false;
            this.listView_Game.View = System.Windows.Forms.View.Details;
            this.listView_Game.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Game";
            this.columnHeader1.Width = 120;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Load Games";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView_Expansion
            // 
            this.listView_Expansion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView_Expansion.ContextMenuStrip = this.contextMenuStrip1;
            this.listView_Expansion.FullRowSelect = true;
            this.listView_Expansion.HideSelection = false;
            this.listView_Expansion.Location = new System.Drawing.Point(169, 106);
            this.listView_Expansion.MultiSelect = false;
            this.listView_Expansion.Name = "listView_Expansion";
            this.listView_Expansion.Size = new System.Drawing.Size(193, 377);
            this.listView_Expansion.TabIndex = 3;
            this.listView_Expansion.UseCompatibleStateImageBehavior = false;
            this.listView_Expansion.View = System.Windows.Forms.View.Details;
            this.listView_Expansion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseDoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Expansion";
            this.columnHeader2.Width = 180;
            // 
            // listView_Single
            // 
            this.listView_Single.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listView_Single.FullRowSelect = true;
            this.listView_Single.HideSelection = false;
            this.listView_Single.Location = new System.Drawing.Point(368, 106);
            this.listView_Single.MultiSelect = false;
            this.listView_Single.Name = "listView_Single";
            this.listView_Single.Size = new System.Drawing.Size(194, 377);
            this.listView_Single.TabIndex = 4;
            this.listView_Single.UseCompatibleStateImageBehavior = false;
            this.listView_Single.View = System.Windows.Forms.View.Details;
            this.listView_Single.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView3_MouseDoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Single";
            this.columnHeader3.Width = 180;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bulkBuyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 26);
            // 
            // bulkBuyToolStripMenuItem
            // 
            this.bulkBuyToolStripMenuItem.Name = "bulkBuyToolStripMenuItem";
            this.bulkBuyToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.bulkBuyToolStripMenuItem.Text = "Bulk Buy";
            this.bulkBuyToolStripMenuItem.Click += new System.EventHandler(this.bulkBuyToolStripMenuItem_Click);
            // 
            // listView_Article
            // 
            this.listView_Article.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.listView_Article.FullRowSelect = true;
            this.listView_Article.HideSelection = false;
            this.listView_Article.Location = new System.Drawing.Point(568, 106);
            this.listView_Article.MultiSelect = false;
            this.listView_Article.Name = "listView_Article";
            this.listView_Article.Size = new System.Drawing.Size(241, 377);
            this.listView_Article.TabIndex = 5;
            this.listView_Article.UseCompatibleStateImageBehavior = false;
            this.listView_Article.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Article";
            this.columnHeader4.Width = 230;
            // 
            // comboBox_Foil
            // 
            this.comboBox_Foil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Foil.FormattingEnabled = true;
            this.comboBox_Foil.Items.AddRange(new object[] {
            "-",
            "Yes",
            "No"});
            this.comboBox_Foil.Location = new System.Drawing.Point(12, 28);
            this.comboBox_Foil.Name = "comboBox_Foil";
            this.comboBox_Foil.Size = new System.Drawing.Size(151, 21);
            this.comboBox_Foil.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Foil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Edition";
            // 
            // comboBox_FirstEdition
            // 
            this.comboBox_FirstEdition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_FirstEdition.FormattingEnabled = true;
            this.comboBox_FirstEdition.Items.AddRange(new object[] {
            "-",
            "Yes",
            "No"});
            this.comboBox_FirstEdition.Location = new System.Drawing.Point(169, 28);
            this.comboBox_FirstEdition.Name = "comboBox_FirstEdition";
            this.comboBox_FirstEdition.Size = new System.Drawing.Size(193, 21);
            this.comboBox_FirstEdition.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Condition";
            // 
            // comboBox_Condition
            // 
            this.comboBox_Condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Condition.FormattingEnabled = true;
            this.comboBox_Condition.Items.AddRange(new object[] {
            "-",
            "MT",
            "NM",
            "EX",
            "GD",
            "LP",
            "PL",
            "PO"});
            this.comboBox_Condition.Location = new System.Drawing.Point(368, 28);
            this.comboBox_Condition.Name = "comboBox_Condition";
            this.comboBox_Condition.Size = new System.Drawing.Size(194, 21);
            this.comboBox_Condition.TabIndex = 11;
            // 
            // listView_Bulk
            // 
            this.listView_Bulk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.listView_Bulk.FullRowSelect = true;
            this.listView_Bulk.HideSelection = false;
            this.listView_Bulk.Location = new System.Drawing.Point(815, 106);
            this.listView_Bulk.Name = "listView_Bulk";
            this.listView_Bulk.Size = new System.Drawing.Size(241, 377);
            this.listView_Bulk.TabIndex = 12;
            this.listView_Bulk.UseCompatibleStateImageBehavior = false;
            this.listView_Bulk.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Article";
            this.columnHeader5.Width = 230;
            // 
            // label_Game
            // 
            this.label_Game.AutoSize = true;
            this.label_Game.Location = new System.Drawing.Point(9, 90);
            this.label_Game.Name = "label_Game";
            this.label_Game.Size = new System.Drawing.Size(47, 13);
            this.label_Game.TabIndex = 13;
            this.label_Game.Text = "Count: 0";
            // 
            // label_Expansion
            // 
            this.label_Expansion.AutoSize = true;
            this.label_Expansion.Location = new System.Drawing.Point(166, 90);
            this.label_Expansion.Name = "label_Expansion";
            this.label_Expansion.Size = new System.Drawing.Size(47, 13);
            this.label_Expansion.TabIndex = 13;
            this.label_Expansion.Text = "Count: 0";
            // 
            // label_Single
            // 
            this.label_Single.AutoSize = true;
            this.label_Single.Location = new System.Drawing.Point(365, 90);
            this.label_Single.Name = "label_Single";
            this.label_Single.Size = new System.Drawing.Size(47, 13);
            this.label_Single.TabIndex = 13;
            this.label_Single.Text = "Count: 0";
            // 
            // label_Article
            // 
            this.label_Article.AutoSize = true;
            this.label_Article.Location = new System.Drawing.Point(565, 90);
            this.label_Article.Name = "label_Article";
            this.label_Article.Size = new System.Drawing.Size(47, 13);
            this.label_Article.TabIndex = 13;
            this.label_Article.Text = "Count: 0";
            // 
            // label_Bulk
            // 
            this.label_Bulk.AutoSize = true;
            this.label_Bulk.Location = new System.Drawing.Point(812, 90);
            this.label_Bulk.Name = "label_Bulk";
            this.label_Bulk.Size = new System.Drawing.Size(47, 13);
            this.label_Bulk.TabIndex = 13;
            this.label_Bulk.Text = "Count: 0";
            // 
            // label_Bulk_Price
            // 
            this.label_Bulk_Price.AutoSize = true;
            this.label_Bulk_Price.Location = new System.Drawing.Point(812, 489);
            this.label_Bulk_Price.Name = "label_Bulk_Price";
            this.label_Bulk_Price.Size = new System.Drawing.Size(58, 13);
            this.label_Bulk_Price.TabIndex = 13;
            this.label_Bulk_Price.Text = "Price: 0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(852, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "With Trackingnumber (Bulk option)";
            // 
            // comboBox_Bulk
            // 
            this.comboBox_Bulk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Bulk.FormattingEnabled = true;
            this.comboBox_Bulk.Items.AddRange(new object[] {
            "NO",
            "YES"});
            this.comboBox_Bulk.Location = new System.Drawing.Point(855, 28);
            this.comboBox_Bulk.Name = "comboBox_Bulk";
            this.comboBox_Bulk.Size = new System.Drawing.Size(201, 21);
            this.comboBox_Bulk.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Games";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(166, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Expansions of Game";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(365, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Singles of Expansion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(565, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Offers of Single";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(812, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Offers (Bulk Version)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 556);
            this.Controls.Add(this.comboBox_Bulk);
            this.Controls.Add(this.label_Bulk_Price);
            this.Controls.Add(this.label_Bulk);
            this.Controls.Add(this.label_Article);
            this.Controls.Add(this.label_Single);
            this.Controls.Add(this.label_Expansion);
            this.Controls.Add(this.label_Game);
            this.Controls.Add(this.listView_Bulk);
            this.Controls.Add(this.comboBox_Condition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_FirstEdition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Foil);
            this.Controls.Add(this.listView_Article);
            this.Controls.Add(this.listView_Single);
            this.Controls.Add(this.listView_Expansion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView_Game);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cardmarket_Bot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView_Game;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView_Expansion;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listView_Single;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listView_Article;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox comboBox_Foil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_FirstEdition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Condition;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bulkBuyToolStripMenuItem;
        private System.Windows.Forms.ListView listView_Bulk;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label_Game;
        private System.Windows.Forms.Label label_Expansion;
        private System.Windows.Forms.Label label_Single;
        private System.Windows.Forms.Label label_Article;
        private System.Windows.Forms.Label label_Bulk;
        private System.Windows.Forms.Label label_Bulk_Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Bulk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

