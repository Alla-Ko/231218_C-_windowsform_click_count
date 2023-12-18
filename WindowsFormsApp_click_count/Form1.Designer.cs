namespace WindowsFormsApp_click_count
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label_l = new System.Windows.Forms.Label();
            this.label_left = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_r = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.label_c = new System.Windows.Forms.Label();
            this.label_coord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Скинути";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_l
            // 
            this.label_l.AutoSize = true;
            this.label_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_l.Location = new System.Drawing.Point(95, 321);
            this.label_l.Name = "label_l";
            this.label_l.Size = new System.Drawing.Size(29, 31);
            this.label_l.TabIndex = 1;
            this.label_l.Text = "0";
            this.label_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_left
            // 
            this.label_left.AutoSize = true;
            this.label_left.Location = new System.Drawing.Point(12, 336);
            this.label_left.Name = "label_left";
            this.label_left.Size = new System.Drawing.Size(77, 13);
            this.label_left.TabIndex = 2;
            this.label_left.Text = "Клаців лівою: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Клаців правою: ";
            // 
            // label_r
            // 
            this.label_r.AutoSize = true;
            this.label_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_r.Location = new System.Drawing.Point(257, 321);
            this.label_r.Name = "label_r";
            this.label_r.Size = new System.Drawing.Size(29, 31);
            this.label_r.TabIndex = 3;
            this.label_r.Text = "0";
            this.label_r.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.Location = new System.Drawing.Point(12, 12);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(483, 254);
            this.Panel.TabIndex = 5;
            this.Panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseClick);
            this.Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // label_c
            // 
            this.label_c.AutoSize = true;
            this.label_c.Location = new System.Drawing.Point(12, 291);
            this.label_c.Name = "label_c";
            this.label_c.Size = new System.Drawing.Size(195, 13);
            this.label_c.TabIndex = 6;
            this.label_c.Text = "Координати вказівника мишки (X;Y): ";
            // 
            // label_coord
            // 
            this.label_coord.AutoSize = true;
            this.label_coord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_coord.Location = new System.Drawing.Point(213, 279);
            this.label_coord.Name = "label_coord";
            this.label_coord.Size = new System.Drawing.Size(0, 31);
            this.label_coord.TabIndex = 7;
            this.label_coord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(507, 376);
            this.Controls.Add(this.label_coord);
            this.Controls.Add(this.label_c);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_r);
            this.Controls.Add(this.label_left);
            this.Controls.Add(this.label_l);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(523, 415);
            this.MinimumSize = new System.Drawing.Size(523, 415);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лічильник клаців";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_l;
        private System.Windows.Forms.Label label_left;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_r;
        private System.Windows.Forms.FlowLayoutPanel Panel;
        private System.Windows.Forms.Label label_c;
        private System.Windows.Forms.Label label_coord;
    }
}

