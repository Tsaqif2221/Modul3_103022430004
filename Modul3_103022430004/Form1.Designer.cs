namespace Modul3_103022430004
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.satuanawal = new System.Windows.Forms.ComboBox();
            this.satuanakhir = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nilaiawal = new System.Windows.Forms.TextBox();
            this.nilaiakhir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // satuanawal
            // 
            this.satuanawal.FormattingEnabled = true;
            this.satuanawal.Location = new System.Drawing.Point(112, 129);
            this.satuanawal.Name = "satuanawal";
            this.satuanawal.Size = new System.Drawing.Size(121, 21);
            this.satuanawal.TabIndex = 0;
            this.satuanawal.SelectedIndexChanged += new System.EventHandler(this.satuanawal_SelectedIndexChanged);
            // 
            // satuanakhir
            // 
            this.satuanakhir.FormattingEnabled = true;
            this.satuanakhir.Location = new System.Drawing.Point(112, 213);
            this.satuanakhir.Name = "satuanakhir";
            this.satuanakhir.Size = new System.Drawing.Size(121, 21);
            this.satuanakhir.TabIndex = 1;
            this.satuanakhir.SelectedIndexChanged += new System.EventHandler(this.satuanakhir_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // nilaiawal
            // 
            this.nilaiawal.Location = new System.Drawing.Point(326, 130);
            this.nilaiawal.Name = "nilaiawal";
            this.nilaiawal.Size = new System.Drawing.Size(164, 20);
            this.nilaiawal.TabIndex = 3;
            this.nilaiawal.TextChanged += new System.EventHandler(this.nilaiawal_TextChanged);
            // 
            // nilaiakhir
            // 
            this.nilaiakhir.Location = new System.Drawing.Point(326, 214);
            this.nilaiakhir.Name = "nilaiakhir";
            this.nilaiakhir.Size = new System.Drawing.Size(164, 20);
            this.nilaiakhir.TabIndex = 4;
            this.nilaiakhir.TextChanged += new System.EventHandler(this.nilaiakhir_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "satuan awal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "satuan ahir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "nilai awal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "nilai akhir";
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(579, 126);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(75, 23);
            this.convert.TabIndex = 9;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nilaiakhir);
            this.Controls.Add(this.nilaiawal);
            this.Controls.Add(this.satuanakhir);
            this.Controls.Add(this.satuanawal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox satuanawal;
        private System.Windows.Forms.ComboBox satuanakhir;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox nilaiawal;
        private System.Windows.Forms.TextBox nilaiakhir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button convert;
    }
}

