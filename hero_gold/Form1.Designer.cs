namespace hero_gold
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button2 = new System.Windows.Forms.Button();
      this.status = new System.Windows.Forms.RichTextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.buttongo = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxlev = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.checkBoxleg = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.Location = new System.Drawing.Point(47, 16);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(193, 45);
      this.textBox1.TabIndex = 0;
      this.textBox1.Text = "12345678";
      this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.Location = new System.Drawing.Point(969, 23);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 34);
      this.button2.TabIndex = 7;
      this.button2.Text = "Quit";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // status
      // 
      this.status.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.status.Location = new System.Drawing.Point(12, 79);
      this.status.Name = "status";
      this.status.Size = new System.Drawing.Size(1032, 290);
      this.status.TabIndex = 8;
      this.status.Text = "";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(29, 13);
      this.label1.TabIndex = 9;
      this.label1.Text = "Gold";
      // 
      // buttongo
      // 
      this.buttongo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttongo.Location = new System.Drawing.Point(547, 18);
      this.buttongo.Name = "buttongo";
      this.buttongo.Size = new System.Drawing.Size(75, 35);
      this.buttongo.TabIndex = 10;
      this.buttongo.TabStop = false;
      this.buttongo.Text = "Go";
      this.buttongo.UseVisualStyleBackColor = true;
      this.buttongo.Click += new System.EventHandler(this.buttongo_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(255, 19);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(27, 13);
      this.label2.TabIndex = 12;
      this.label2.Text = "Max";
      // 
      // textBoxlev
      // 
      this.textBoxlev.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxlev.Location = new System.Drawing.Point(299, 13);
      this.textBoxlev.Name = "textBoxlev";
      this.textBoxlev.Size = new System.Drawing.Size(86, 45);
      this.textBoxlev.TabIndex = 11;
      this.textBoxlev.Text = "15";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(255, 41);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(33, 13);
      this.label3.TabIndex = 13;
      this.label3.Text = "Level";
      // 
      // checkBoxleg
      // 
      this.checkBoxleg.AutoSize = true;
      this.checkBoxleg.Location = new System.Drawing.Point(402, 16);
      this.checkBoxleg.Name = "checkBoxleg";
      this.checkBoxleg.Size = new System.Drawing.Size(129, 17);
      this.checkBoxleg.TabIndex = 14;
      this.checkBoxleg.Text = "no legendary missions";
      this.checkBoxleg.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1056, 379);
      this.Controls.Add(this.checkBoxleg);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBoxlev);
      this.Controls.Add(this.buttongo);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.status);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.textBox1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "Gold Calculator";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.RichTextBox status;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button buttongo;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxlev;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.CheckBox checkBoxleg;
  }
}

