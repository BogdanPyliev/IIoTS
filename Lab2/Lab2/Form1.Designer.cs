namespace Lab2
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
            this.button_signal = new System.Windows.Forms.Button();
            this.checkbox_Fuel = new System.Windows.Forms.CheckBox();
            this.checkbox_Temperature = new System.Windows.Forms.CheckBox();
            this.checkbox_Oil = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_onoff = new System.Windows.Forms.Label();
            this.label_signal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_state = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_connecton = new System.Windows.Forms.Button();
            this.timer_ReadOutput = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button_connectoff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_signal
            // 
            this.button_signal.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.button_signal.BackColor = System.Drawing.Color.Black;
            this.button_signal.Enabled = false;
            this.button_signal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_signal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_signal.Location = new System.Drawing.Point(492, 254);
            this.button_signal.Name = "button_signal";
            this.button_signal.Size = new System.Drawing.Size(97, 46);
            this.button_signal.TabIndex = 0;
            this.button_signal.Text = "Вім\\Вим сигнал";
            this.button_signal.UseVisualStyleBackColor = false;
            this.button_signal.Click += new System.EventHandler(this.button_signal_Click);
            // 
            // checkbox_Fuel
            // 
            this.checkbox_Fuel.AutoSize = true;
            this.checkbox_Fuel.Enabled = false;
            this.checkbox_Fuel.Location = new System.Drawing.Point(66, 303);
            this.checkbox_Fuel.Name = "checkbox_Fuel";
            this.checkbox_Fuel.Size = new System.Drawing.Size(15, 14);
            this.checkbox_Fuel.TabIndex = 1;
            this.checkbox_Fuel.UseVisualStyleBackColor = true;
            this.checkbox_Fuel.CheckedChanged += new System.EventHandler(this.checkbox_Fuel_CheckedChanged);
            // 
            // checkbox_Temperature
            // 
            this.checkbox_Temperature.AutoSize = true;
            this.checkbox_Temperature.Enabled = false;
            this.checkbox_Temperature.Location = new System.Drawing.Point(102, 303);
            this.checkbox_Temperature.Name = "checkbox_Temperature";
            this.checkbox_Temperature.Size = new System.Drawing.Size(15, 14);
            this.checkbox_Temperature.TabIndex = 2;
            this.checkbox_Temperature.UseVisualStyleBackColor = true;
            this.checkbox_Temperature.CheckedChanged += new System.EventHandler(this.checkbox_Temperature_CheckedChanged);
            // 
            // checkbox_Oil
            // 
            this.checkbox_Oil.AutoSize = true;
            this.checkbox_Oil.Enabled = false;
            this.checkbox_Oil.Location = new System.Drawing.Point(135, 303);
            this.checkbox_Oil.Name = "checkbox_Oil";
            this.checkbox_Oil.Size = new System.Drawing.Size(15, 14);
            this.checkbox_Oil.TabIndex = 3;
            this.checkbox_Oil.UseVisualStyleBackColor = true;
            this.checkbox_Oil.CheckedChanged += new System.EventHandler(this.checkbox_Oil_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(507, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Двигун:";
            // 
            // label_onoff
            // 
            this.label_onoff.AutoSize = true;
            this.label_onoff.BackColor = System.Drawing.Color.Black;
            this.label_onoff.Location = new System.Drawing.Point(557, 188);
            this.label_onoff.Name = "label_onoff";
            this.label_onoff.Size = new System.Drawing.Size(28, 13);
            this.label_onoff.TabIndex = 6;
            this.label_onoff.Text = "Вим";
            // 
            // label_signal
            // 
            this.label_signal.AutoSize = true;
            this.label_signal.BackColor = System.Drawing.Color.Black;
            this.label_signal.Location = new System.Drawing.Point(532, 303);
            this.label_signal.Name = "label_signal";
            this.label_signal.Size = new System.Drawing.Size(24, 13);
            this.label_signal.TabIndex = 8;
            this.label_signal.Text = "Вім";
            this.label_signal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(489, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сигнал:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_state
            // 
            this.label_state.AutoSize = true;
            this.label_state.BackColor = System.Drawing.Color.Black;
            this.label_state.Location = new System.Drawing.Point(519, 97);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(0, 13);
            this.label_state.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(489, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Стан:";
            // 
            // button_connecton
            // 
            this.button_connecton.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.button_connecton.BackColor = System.Drawing.Color.Black;
            this.button_connecton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_connecton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_connecton.Location = new System.Drawing.Point(490, 23);
            this.button_connecton.Name = "button_connecton";
            this.button_connecton.Size = new System.Drawing.Size(95, 27);
            this.button_connecton.TabIndex = 9;
            this.button_connecton.Text = "Підключення";
            this.button_connecton.UseVisualStyleBackColor = false;
            this.button_connecton.Click += new System.EventHandler(this.button_stateon_Click);
            // 
            // timer_ReadOutput
            // 
            this.timer_ReadOutput.Enabled = true;
            this.timer_ReadOutput.Tick += new System.EventHandler(this.timer_ReadOutput_Tick);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(511, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "Вім\\Вим двигун";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.checkBox_engine_Click);
            // 
            // button_connectoff
            // 
            this.button_connectoff.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.button_connectoff.BackColor = System.Drawing.Color.Black;
            this.button_connectoff.Enabled = false;
            this.button_connectoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_connectoff.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_connectoff.Location = new System.Drawing.Point(490, 56);
            this.button_connectoff.Name = "button_connectoff";
            this.button_connectoff.Size = new System.Drawing.Size(95, 27);
            this.button_connectoff.TabIndex = 13;
            this.button_connectoff.Text = "Відключення";
            this.button_connectoff.UseVisualStyleBackColor = false;
            this.button_connectoff.Click += new System.EventHandler(this.button_connectoff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab2.Properties.Resources.вфы;
            this.ClientSize = new System.Drawing.Size(601, 335);
            this.Controls.Add(this.button_connectoff);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_state);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_connecton);
            this.Controls.Add(this.label_signal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_onoff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkbox_Oil);
            this.Controls.Add(this.checkbox_Temperature);
            this.Controls.Add(this.checkbox_Fuel);
            this.Controls.Add(this.button_signal);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Приборна панель автомобіля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_signal;
        private System.Windows.Forms.CheckBox checkbox_Fuel;
        private System.Windows.Forms.CheckBox checkbox_Temperature;
        private System.Windows.Forms.CheckBox checkbox_Oil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_onoff;
        private System.Windows.Forms.Label label_signal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_connecton;
        private System.Windows.Forms.Timer timer_ReadOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_connectoff;
    }
}

