namespace Anker2_DesktopApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grBoxAnket = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelBirth = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSaveListBox = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grBoxAnket.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBoxAnket
            // 
            this.grBoxAnket.Controls.Add(this.buttonSave);
            this.grBoxAnket.Controls.Add(this.buttonChange);
            this.grBoxAnket.Controls.Add(this.dateTimePicker1);
            this.grBoxAnket.Controls.Add(this.labelBirth);
            this.grBoxAnket.Controls.Add(this.textBoxTel);
            this.grBoxAnket.Controls.Add(this.labelTel);
            this.grBoxAnket.Controls.Add(this.textBoxEmail);
            this.grBoxAnket.Controls.Add(this.labelEmail);
            this.grBoxAnket.Controls.Add(this.textBoxSurname);
            this.grBoxAnket.Controls.Add(this.labelSurname);
            this.grBoxAnket.Controls.Add(this.textBoxName);
            this.grBoxAnket.Controls.Add(this.labelName);
            this.grBoxAnket.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grBoxAnket.Location = new System.Drawing.Point(12, 40);
            this.grBoxAnket.Name = "grBoxAnket";
            this.grBoxAnket.Size = new System.Drawing.Size(353, 313);
            this.grBoxAnket.TabIndex = 0;
            this.grBoxAnket.TabStop = false;
            this.grBoxAnket.Text = "Anket";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(272, 284);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonChange.Location = new System.Drawing.Point(6, 281);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(78, 26);
            this.buttonChange.TabIndex = 12;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 164);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 25);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBirth.Location = new System.Drawing.Point(6, 170);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(68, 17);
            this.labelBirth.TabIndex = 10;
            this.labelBirth.Text = "Birth date";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTel.Location = new System.Drawing.Point(77, 133);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.PlaceholderText = "+994xxxxxxxxx";
            this.textBoxTel.Size = new System.Drawing.Size(223, 23);
            this.textBoxTel.TabIndex = 9;
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTel.Location = new System.Drawing.Point(6, 136);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(47, 17);
            this.labelTel.TabIndex = 8;
            this.labelTel.Text = "Phone";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.Location = new System.Drawing.Point(77, 100);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PlaceholderText = "nihademinov@gmail.com";
            this.textBoxEmail.Size = new System.Drawing.Size(223, 23);
            this.textBoxEmail.TabIndex = 6;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(6, 103);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(40, 17);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSurname.Location = new System.Drawing.Point(77, 65);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.PlaceholderText = "Eminov";
            this.textBoxSurname.Size = new System.Drawing.Size(223, 23);
            this.textBoxSurname.TabIndex = 4;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSurname.Location = new System.Drawing.Point(6, 68);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(62, 17);
            this.labelSurname.TabIndex = 3;
            this.labelSurname.Text = "Surname";
            this.labelSurname.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(77, 31);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Nihad";
            this.textBoxName.Size = new System.Drawing.Size(223, 23);
            this.textBoxName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(6, 34);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(371, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(233, 259);
            this.listBox1.TabIndex = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLoad.Location = new System.Drawing.Point(371, 325);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSaveListBox
            // 
            this.buttonSaveListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveListBox.Location = new System.Drawing.Point(529, 325);
            this.buttonSaveListBox.Name = "buttonSaveListBox";
            this.buttonSaveListBox.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveListBox.TabIndex = 3;
            this.buttonSaveListBox.Text = "Save";
            this.buttonSaveListBox.UseVisualStyleBackColor = true;
            this.buttonSaveListBox.Click += new System.EventHandler(this.buttonSaveListBox_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 427);
            this.Controls.Add(this.buttonSaveListBox);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.grBoxAnket);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grBoxAnket.ResumeLayout(false);
            this.grBoxAnket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grBoxAnket;
        private TextBox textBoxSurname;
        private Label labelSurname;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelTel;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private DateTimePicker dateTimePicker1;
        private Label labelBirth;
        private TextBox textBoxTel;
        private Button buttonSave;
        private Button buttonChange;
        private ListBox listBox1;
        private Button buttonLoad;
        private Button buttonSaveListBox;
        private OpenFileDialog openFileDialog1;
    }
}