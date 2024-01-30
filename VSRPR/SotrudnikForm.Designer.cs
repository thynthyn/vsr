namespace VSRPR
{
    partial class SotrudnikForm
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
            dataGridView1 = new DataGridView();
            View = new Button();
            TipComboBox = new ComboBox();
            PodrazdelComboBox = new ComboBox();
            StatusComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1394, 741);
            dataGridView1.TabIndex = 0;
            // 
            // View
            // 
            View.Location = new Point(1264, 2);
            View.Name = "View";
            View.Size = new Size(142, 28);
            View.TabIndex = 2;
            View.Text = "Просмотр";
            View.UseVisualStyleBackColor = true;
            View.Click += View_Click;
            // 
            // TipComboBox
            // 
            TipComboBox.FormattingEnabled = true;
            TipComboBox.Items.AddRange(new object[] { "Все", "Личная", "Групповая" });
            TipComboBox.Location = new Point(61, 2);
            TipComboBox.Name = "TipComboBox";
            TipComboBox.Size = new Size(121, 27);
            TipComboBox.TabIndex = 3;
            // 
            // PodrazdelComboBox
            // 
            PodrazdelComboBox.FormattingEnabled = true;
            PodrazdelComboBox.Location = new Point(317, 2);
            PodrazdelComboBox.Name = "PodrazdelComboBox";
            PodrazdelComboBox.Size = new Size(121, 27);
            PodrazdelComboBox.TabIndex = 4;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Items.AddRange(new object[] { "Все", "На рассмотрении", "Одобрена", "Отклонена" });
            StatusComboBox.Location = new Point(514, 2);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(121, 27);
            StatusComboBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 8);
            label1.Name = "label1";
            label1.Size = new Size(42, 19);
            label1.TabIndex = 6;
            label1.Text = "Тип:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 8);
            label2.Name = "label2";
            label2.Size = new Size(123, 19);
            label2.TabIndex = 7;
            label2.Text = "Подразделение:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 8);
            label3.Name = "label3";
            label3.Size = new Size(64, 19);
            label3.TabIndex = 8;
            label3.Text = "Статус:";
            // 
            // button2
            // 
            button2.Location = new Point(1076, 7);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SotrudnikForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1418, 789);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(StatusComboBox);
            Controls.Add(PodrazdelComboBox);
            Controls.Add(TipComboBox);
            Controls.Add(View);
            Controls.Add(dataGridView1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Name = "SotrudnikForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SotrudnikForm";
            FormClosed += SotrudnikForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button View;
        private ComboBox TipComboBox;
        private ComboBox PodrazdelComboBox;
        private ComboBox StatusComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}