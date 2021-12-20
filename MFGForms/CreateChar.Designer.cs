namespace MFGForms
{
    partial class CreateChar
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.radioButtonWarrior = new System.Windows.Forms.RadioButton();
            this.radioButtonMage = new System.Windows.Forms.RadioButton();
            this.radioButtonArcher = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(119, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            this.errorProviderName.DataSource = this.button1.Controls;
            // 
            // radioButtonWarrior
            // 
            this.radioButtonWarrior.AutoSize = true;
            this.radioButtonWarrior.Location = new System.Drawing.Point(148, 155);
            this.radioButtonWarrior.Name = "radioButtonWarrior";
            this.radioButtonWarrior.Size = new System.Drawing.Size(64, 19);
            this.radioButtonWarrior.TabIndex = 8;
            this.radioButtonWarrior.TabStop = true;
            this.radioButtonWarrior.Text = "Warrior";
            this.radioButtonWarrior.UseVisualStyleBackColor = true;
            this.radioButtonWarrior.CheckedChanged += new System.EventHandler(this.radioButtonWarrior_CheckedChanged);
            // 
            // radioButtonMage
            // 
            this.radioButtonMage.AutoSize = true;
            this.radioButtonMage.Location = new System.Drawing.Point(148, 180);
            this.radioButtonMage.Name = "radioButtonMage";
            this.radioButtonMage.Size = new System.Drawing.Size(55, 19);
            this.radioButtonMage.TabIndex = 9;
            this.radioButtonMage.TabStop = true;
            this.radioButtonMage.Text = "Mage";
            this.radioButtonMage.UseVisualStyleBackColor = true;
            this.radioButtonMage.CheckedChanged += new System.EventHandler(this.radioButtonMage_CheckedChanged);
            // 
            // radioButtonArcher
            // 
            this.radioButtonArcher.AutoSize = true;
            this.radioButtonArcher.Location = new System.Drawing.Point(148, 205);
            this.radioButtonArcher.Name = "radioButtonArcher";
            this.radioButtonArcher.Size = new System.Drawing.Size(60, 19);
            this.radioButtonArcher.TabIndex = 10;
            this.radioButtonArcher.TabStop = true;
            this.radioButtonArcher.Text = "Archer";
            this.radioButtonArcher.UseVisualStyleBackColor = true;
            this.radioButtonArcher.CheckedChanged += new System.EventHandler(this.radioButtonArcher_CheckedChanged);
            // 
            // CreateChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 409);
            this.Controls.Add(this.radioButtonArcher);
            this.Controls.Add(this.radioButtonMage);
            this.Controls.Add(this.radioButtonWarrior);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "CreateChar";
            this.Text = "Create Character";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private ErrorProvider errorProviderName;
        private RadioButton radioButtonArcher;
        private RadioButton radioButtonMage;
        private RadioButton radioButtonWarrior;
    }
}