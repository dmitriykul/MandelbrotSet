namespace MandelbrotDemo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUvel = new System.Windows.Forms.Button();
            this.btnUmen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(787, 634);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(793, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "      Во сколько раз уменьшить/увеличить";
            // 
            // text
            // 
            this.text.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.text.Location = new System.Drawing.Point(910, 310);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(78, 32);
            this.text.TabIndex = 2;
            this.text.Text = "2";
            this.text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(793, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Нарисовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUvel
            // 
            this.btnUvel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUvel.Location = new System.Drawing.Point(793, 360);
            this.btnUvel.Name = "btnUvel";
            this.btnUvel.Size = new System.Drawing.Size(100, 25);
            this.btnUvel.TabIndex = 4;
            this.btnUvel.Text = "увеличить";
            this.btnUvel.UseVisualStyleBackColor = true;
            this.btnUvel.Click += new System.EventHandler(this.btnUvel_Click);
            // 
            // btnUmen
            // 
            this.btnUmen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUmen.Location = new System.Drawing.Point(888, 360);
            this.btnUmen.Name = "btnUmen";
            this.btnUmen.Size = new System.Drawing.Size(100, 25);
            this.btnUmen.TabIndex = 5;
            this.btnUmen.Text = "уменьшить";
            this.btnUmen.UseVisualStyleBackColor = true;
            this.btnUmen.Click += new System.EventHandler(this.btnUmen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 638);
            this.Controls.Add(this.btnUmen);
            this.Controls.Add(this.btnUvel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUvel;
        private System.Windows.Forms.Button btnUmen;
    }
}

