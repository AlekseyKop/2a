namespace MoneyBackTrack
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textdano = new System.Windows.Forms.TextBox();
            this.textvars = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butRun = new System.Windows.Forms.Button();
            this.butUslovie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textdano
            // 
            this.textdano.Location = new System.Drawing.Point(162, 50);
            this.textdano.Name = "textdano";
            this.textdano.Size = new System.Drawing.Size(132, 20);
            this.textdano.TabIndex = 0;
            // 
            // textvars
            // 
            this.textvars.Location = new System.Drawing.Point(162, 101);
            this.textvars.Name = "textvars";
            this.textvars.ReadOnly = true;
            this.textvars.Size = new System.Drawing.Size(132, 20);
            this.textvars.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сдача:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество вариантов:";
            // 
            // butRun
            // 
            this.butRun.Location = new System.Drawing.Point(326, 50);
            this.butRun.Name = "butRun";
            this.butRun.Size = new System.Drawing.Size(100, 71);
            this.butRun.TabIndex = 4;
            this.butRun.Text = "Посчитать";
            this.butRun.UseVisualStyleBackColor = true;
            this.butRun.Click += new System.EventHandler(this.butRun_Click);
            // 
            // butUslovie
            // 
            this.butUslovie.Location = new System.Drawing.Point(12, 12);
            this.butUslovie.Name = "butUslovie";
            this.butUslovie.Size = new System.Drawing.Size(78, 20);
            this.butUslovie.TabIndex = 5;
            this.butUslovie.Text = "Условие";
            this.butUslovie.UseVisualStyleBackColor = true;
            this.butUslovie.Click += new System.EventHandler(this.butUslovie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 161);
            this.Controls.Add(this.butUslovie);
            this.Controls.Add(this.butRun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textvars);
            this.Controls.Add(this.textdano);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textdano;
        private System.Windows.Forms.TextBox textvars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butRun;
        private System.Windows.Forms.Button butUslovie;
    }
}

