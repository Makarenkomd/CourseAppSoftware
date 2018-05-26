namespace Top10
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAllPlayers = new System.Windows.Forms.ListBox();
            this.buttonVoite = new System.Windows.Forms.Button();
            this.listBoxBestPlayers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewBest = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVoite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Все футболисты";
            // 
            // listBoxAllPlayers
            // 
            this.listBoxAllPlayers.FormattingEnabled = true;
            this.listBoxAllPlayers.Location = new System.Drawing.Point(17, 79);
            this.listBoxAllPlayers.Name = "listBoxAllPlayers";
            this.listBoxAllPlayers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxAllPlayers.Size = new System.Drawing.Size(151, 238);
            this.listBoxAllPlayers.TabIndex = 1;
            // 
            // buttonVoite
            // 
            this.buttonVoite.Location = new System.Drawing.Point(189, 146);
            this.buttonVoite.Name = "buttonVoite";
            this.buttonVoite.Size = new System.Drawing.Size(121, 37);
            this.buttonVoite.TabIndex = 2;
            this.buttonVoite.Text = "Голосовать";
            this.buttonVoite.UseVisualStyleBackColor = true;
            this.buttonVoite.Click += new System.EventHandler(this.buttonVoite_Click);
            // 
            // listBoxBestPlayers
            // 
            this.listBoxBestPlayers.FormattingEnabled = true;
            this.listBoxBestPlayers.Location = new System.Drawing.Point(341, 79);
            this.listBoxBestPlayers.Name = "listBoxBestPlayers";
            this.listBoxBestPlayers.Size = new System.Drawing.Size(159, 238);
            this.listBoxBestPlayers.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Лучшие футболисты";
            // 
            // listViewBest
            // 
            this.listViewBest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnVoite});
            this.listViewBest.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewBest.Location = new System.Drawing.Point(516, 79);
            this.listViewBest.Name = "listViewBest";
            this.listViewBest.Size = new System.Drawing.Size(169, 238);
            this.listViewBest.TabIndex = 5;
            this.listViewBest.UseCompatibleStateImageBehavior = false;
            this.listViewBest.View = System.Windows.Forms.View.Details;
            this.listViewBest.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewBest_ColumnClick);
            // 
            // columnName
            // 
            this.columnName.Text = "футболист";
            // 
            // columnVoite
            // 
            this.columnVoite.Text = "голоса";
            this.columnVoite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 442);
            this.Controls.Add(this.listViewBest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxBestPlayers);
            this.Controls.Add(this.buttonVoite);
            this.Controls.Add(this.listBoxAllPlayers);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Выбор лучшего футболиста";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAllPlayers;
        private System.Windows.Forms.Button buttonVoite;
        private System.Windows.Forms.ListBox listBoxBestPlayers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewBest;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnVoite;
    }
}

