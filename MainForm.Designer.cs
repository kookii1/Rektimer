namespace Rektimer
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.retimeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fStart = new System.Windows.Forms.TextBox();
            this.fEnd = new System.Windows.Forms.TextBox();
            this.vFPS = new System.Windows.Forms.TextBox();
            this.loadAdd = new System.Windows.Forms.Button();
            this.loadCounter = new System.Windows.Forms.Label();
            this.loadRem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // retimeBtn
            // 
            this.retimeBtn.FlatAppearance.BorderSize = 0;
            this.retimeBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retimeBtn.Location = new System.Drawing.Point(176, 240);
            this.retimeBtn.Name = "retimeBtn";
            this.retimeBtn.Size = new System.Drawing.Size(164, 67);
            this.retimeBtn.TabIndex = 0;
            this.retimeBtn.Text = "Retime!";
            this.retimeBtn.UseVisualStyleBackColor = true;
            this.retimeBtn.Click += new System.EventHandler(this.retimeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(15, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 123);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(16, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Load Frame end";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(16, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Load frame start";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frame Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(173, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Frame End";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(344, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Video FPS";
            // 
            // fStart
            // 
            this.fStart.Location = new System.Drawing.Point(83, 12);
            this.fStart.Name = "fStart";
            this.fStart.ShortcutsEnabled = false;
            this.fStart.Size = new System.Drawing.Size(84, 20);
            this.fStart.TabIndex = 5;
            this.fStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allowDigitsOnly);
            // 
            // fEnd
            // 
            this.fEnd.Location = new System.Drawing.Point(240, 12);
            this.fEnd.Name = "fEnd";
            this.fEnd.ShortcutsEnabled = false;
            this.fEnd.Size = new System.Drawing.Size(98, 20);
            this.fEnd.TabIndex = 6;
            this.fEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allowDigitsOnly);
            // 
            // vFPS
            // 
            this.vFPS.Location = new System.Drawing.Point(408, 12);
            this.vFPS.Name = "vFPS";
            this.vFPS.ShortcutsEnabled = false;
            this.vFPS.Size = new System.Drawing.Size(99, 20);
            this.vFPS.TabIndex = 7;
            this.vFPS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.allowDigitsOnly);
            // 
            // loadAdd
            // 
            this.loadAdd.FlatAppearance.BorderSize = 0;
            this.loadAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadAdd.Location = new System.Drawing.Point(15, 45);
            this.loadAdd.Name = "loadAdd";
            this.loadAdd.Size = new System.Drawing.Size(117, 37);
            this.loadAdd.TabIndex = 1;
            this.loadAdd.Text = "Add Load";
            this.loadAdd.UseVisualStyleBackColor = true;
            this.loadAdd.Click += new System.EventHandler(this.loadAdd_Click);
            // 
            // loadCounter
            // 
            this.loadCounter.AutoSize = true;
            this.loadCounter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadCounter.ForeColor = System.Drawing.SystemColors.Control;
            this.loadCounter.Location = new System.Drawing.Point(387, 51);
            this.loadCounter.Name = "loadCounter";
            this.loadCounter.Size = new System.Drawing.Size(120, 21);
            this.loadCounter.TabIndex = 8;
            this.loadCounter.Text = "Load Counter: 0";
            // 
            // loadRem
            // 
            this.loadRem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadRem.Location = new System.Drawing.Point(138, 45);
            this.loadRem.Name = "loadRem";
            this.loadRem.Size = new System.Drawing.Size(125, 37);
            this.loadRem.TabIndex = 9;
            this.loadRem.Text = "Remove Load";
            this.loadRem.UseVisualStyleBackColor = true;
            this.loadRem.Click += new System.EventHandler(this.loadRem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(519, 319);
            this.Controls.Add(this.loadRem);
            this.Controls.Add(this.loadCounter);
            this.Controls.Add(this.loadAdd);
            this.Controls.Add(this.vFPS);
            this.Controls.Add(this.fEnd);
            this.Controls.Add(this.fStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.retimeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rektimer";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button retimeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fStart;
        private System.Windows.Forms.TextBox fEnd;
        private System.Windows.Forms.TextBox vFPS;
        private System.Windows.Forms.Button loadAdd;
        private System.Windows.Forms.Label loadCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loadRem;
    }
}

