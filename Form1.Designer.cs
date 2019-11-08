namespace Фитоняшки
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
            this.components = new System.ComponentModel.Container();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_woman = new System.Windows.Forms.RadioButton();
            this.radioButton_man = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_max = new System.Windows.Forms.RadioButton();
            this.radioButton_middel = new System.Windows.Forms.RadioButton();
            this.radioButton_min = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_sport_super = new System.Windows.Forms.RadioButton();
            this.radioButton_sport_very_high = new System.Windows.Forms.RadioButton();
            this.radioButton_sport_high = new System.Windows.Forms.RadioButton();
            this.radioButton_sport_middel = new System.Windows.Forms.RadioButton();
            this.radioButton_Sport_min = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.оформлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сброситьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(302, 43);
            this.textBox_result.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_result.Size = new System.Drawing.Size(335, 481);
            this.textBox_result.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вес (кг)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Рост (см)";
            // 
            // textBox_weight
            // 
            this.textBox_weight.Location = new System.Drawing.Point(104, 67);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(113, 26);
            this.textBox_weight.TabIndex = 3;
            this.textBox_weight.TextChanged += new System.EventHandler(this.textBox_weight_TextChanged);
            this.textBox_weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_weight_KeyPress);
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(104, 101);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(113, 26);
            this.textBox_height.TabIndex = 4;
            this.textBox_height.TextChanged += new System.EventHandler(this.textBox_height_TextChanged);
            this.textBox_height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_height_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результаты расчётов";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(360, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_woman);
            this.groupBox1.Controls.Add(this.radioButton_man);
            this.groupBox1.Location = new System.Drawing.Point(17, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 95);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор пола";
            // 
            // radioButton_woman
            // 
            this.radioButton_woman.AutoSize = true;
            this.radioButton_woman.Location = new System.Drawing.Point(21, 63);
            this.radioButton_woman.Name = "radioButton_woman";
            this.radioButton_woman.Size = new System.Drawing.Size(93, 23);
            this.radioButton_woman.TabIndex = 1;
            this.radioButton_woman.TabStop = true;
            this.radioButton_woman.Text = "Женский";
            this.radioButton_woman.UseVisualStyleBackColor = true;
            // 
            // radioButton_man
            // 
            this.radioButton_man.AutoSize = true;
            this.radioButton_man.Location = new System.Drawing.Point(21, 34);
            this.radioButton_man.Name = "radioButton_man";
            this.radioButton_man.Size = new System.Drawing.Size(96, 23);
            this.radioButton_man.TabIndex = 0;
            this.radioButton_man.TabStop = true;
            this.radioButton_man.Text = "Мужской";
            this.radioButton_man.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_max);
            this.groupBox2.Controls.Add(this.radioButton_middel);
            this.groupBox2.Controls.Add(this.radioButton_min);
            this.groupBox2.Location = new System.Drawing.Point(18, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 129);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Обхват запястья";
            // 
            // radioButton_max
            // 
            this.radioButton_max.AutoSize = true;
            this.radioButton_max.Location = new System.Drawing.Point(21, 89);
            this.radioButton_max.Name = "radioButton_max";
            this.radioButton_max.Size = new System.Drawing.Size(110, 23);
            this.radioButton_max.TabIndex = 2;
            this.radioButton_max.TabStop = true;
            this.radioButton_max.Text = "более 17 см";
            this.radioButton_max.UseVisualStyleBackColor = true;
            // 
            // radioButton_middel
            // 
            this.radioButton_middel.AutoSize = true;
            this.radioButton_middel.Location = new System.Drawing.Point(21, 60);
            this.radioButton_middel.Name = "radioButton_middel";
            this.radioButton_middel.Size = new System.Drawing.Size(147, 23);
            this.radioButton_middel.TabIndex = 1;
            this.radioButton_middel.TabStop = true;
            this.radioButton_middel.Text = "от 15 см до 17 см";
            this.radioButton_middel.UseVisualStyleBackColor = true;
            // 
            // radioButton_min
            // 
            this.radioButton_min.AutoSize = true;
            this.radioButton_min.Location = new System.Drawing.Point(21, 31);
            this.radioButton_min.Name = "radioButton_min";
            this.radioButton_min.Size = new System.Drawing.Size(125, 23);
            this.radioButton_min.TabIndex = 0;
            this.radioButton_min.TabStop = true;
            this.radioButton_min.Text = "меньше 15 см";
            this.radioButton_min.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ваши параметры:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Возраст";
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(104, 133);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(113, 26);
            this.textBox_age.TabIndex = 11;
            this.textBox_age.TextChanged += new System.EventHandler(this.textBox_age_TextChanged);
            this.textBox_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_age_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_sport_super);
            this.groupBox3.Controls.Add(this.radioButton_sport_very_high);
            this.groupBox3.Controls.Add(this.radioButton_sport_high);
            this.groupBox3.Controls.Add(this.radioButton_sport_middel);
            this.groupBox3.Controls.Add(this.radioButton_Sport_min);
            this.groupBox3.Location = new System.Drawing.Point(19, 433);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 181);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Физическая активность";
            // 
            // radioButton_sport_super
            // 
            this.radioButton_sport_super.AutoSize = true;
            this.radioButton_sport_super.Location = new System.Drawing.Point(20, 141);
            this.radioButton_sport_super.Name = "radioButton_sport_super";
            this.radioButton_sport_super.Size = new System.Drawing.Size(115, 23);
            this.radioButton_sport_super.TabIndex = 4;
            this.radioButton_sport_super.TabStop = true;
            this.radioButton_sport_super.Text = "Придельная";
            this.radioButton_sport_super.UseVisualStyleBackColor = true;
            // 
            // radioButton_sport_very_high
            // 
            this.radioButton_sport_very_high.AutoSize = true;
            this.radioButton_sport_very_high.Location = new System.Drawing.Point(20, 112);
            this.radioButton_sport_very_high.Name = "radioButton_sport_very_high";
            this.radioButton_sport_very_high.Size = new System.Drawing.Size(140, 23);
            this.radioButton_sport_very_high.TabIndex = 3;
            this.radioButton_sport_very_high.TabStop = true;
            this.radioButton_sport_very_high.Text = "Очень высокая";
            this.radioButton_sport_very_high.UseVisualStyleBackColor = true;
            // 
            // radioButton_sport_high
            // 
            this.radioButton_sport_high.AutoSize = true;
            this.radioButton_sport_high.Location = new System.Drawing.Point(20, 83);
            this.radioButton_sport_high.Name = "radioButton_sport_high";
            this.radioButton_sport_high.Size = new System.Drawing.Size(92, 23);
            this.radioButton_sport_high.TabIndex = 2;
            this.radioButton_sport_high.TabStop = true;
            this.radioButton_sport_high.Text = "Высокая";
            this.radioButton_sport_high.UseVisualStyleBackColor = true;
            // 
            // radioButton_sport_middel
            // 
            this.radioButton_sport_middel.AutoSize = true;
            this.radioButton_sport_middel.Location = new System.Drawing.Point(20, 54);
            this.radioButton_sport_middel.Name = "radioButton_sport_middel";
            this.radioButton_sport_middel.Size = new System.Drawing.Size(108, 23);
            this.radioButton_sport_middel.TabIndex = 1;
            this.radioButton_sport_middel.TabStop = true;
            this.radioButton_sport_middel.Text = "Умеренная";
            this.radioButton_sport_middel.UseVisualStyleBackColor = true;
            // 
            // radioButton_Sport_min
            // 
            this.radioButton_Sport_min.AutoSize = true;
            this.radioButton_Sport_min.Location = new System.Drawing.Point(20, 25);
            this.radioButton_Sport_min.Name = "radioButton_Sport_min";
            this.radioButton_Sport_min.Size = new System.Drawing.Size(77, 23);
            this.radioButton_Sport_min.TabIndex = 0;
            this.radioButton_Sport_min.TabStop = true;
            this.radioButton_Sport_min.Text = "Малая";
            this.radioButton_Sport_min.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оформлениеToolStripMenuItem,
            this.сброситьToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 70);
            // 
            // оформлениеToolStripMenuItem
            // 
            this.оформлениеToolStripMenuItem.Name = "оформлениеToolStripMenuItem";
            this.оформлениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оформлениеToolStripMenuItem.Text = "Оформление";
            this.оформлениеToolStripMenuItem.Click += new System.EventHandler(this.оформлениеToolStripMenuItem_Click);
            // 
            // сброситьToolStripMenuItem
            // 
            this.сброситьToolStripMenuItem.Name = "сброситьToolStripMenuItem";
            this.сброситьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сброситьToolStripMenuItem.Text = "Сбросить ";
            this.сброситьToolStripMenuItem.Click += new System.EventHandler(this.сброситьToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.информацияToolStripMenuItem.Text = "Информация";
            this.информацияToolStripMenuItem.Click += new System.EventHandler(this.информацияToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 648);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_height);
            this.Controls.Add(this.textBox_weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_result);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Фитоняшки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_weight;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_woman;
        private System.Windows.Forms.RadioButton radioButton_man;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_max;
        private System.Windows.Forms.RadioButton radioButton_middel;
        private System.Windows.Forms.RadioButton radioButton_min;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_sport_super;
        private System.Windows.Forms.RadioButton radioButton_sport_very_high;
        private System.Windows.Forms.RadioButton radioButton_sport_high;
        private System.Windows.Forms.RadioButton radioButton_sport_middel;
        private System.Windows.Forms.RadioButton radioButton_Sport_min;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оформлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сброситьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
    }
}

