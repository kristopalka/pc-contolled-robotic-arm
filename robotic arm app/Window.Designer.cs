namespace RoboticArm
{
    partial class Window
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.Settings = new System.Windows.Forms.PictureBox();
            this.servo4 = new System.Windows.Forms.TrackBar();
            this.servo3 = new System.Windows.Forms.TrackBar();
            this.servo2 = new System.Windows.Forms.TrackBar();
            this.servo1 = new System.Windows.Forms.TrackBar();
            this.StepperSpeed = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StepperRightButton = new System.Windows.Forms.Button();
            this.StepperLeftButton = new System.Windows.Forms.Button();
            this.SliderLeftButton = new System.Windows.Forms.Button();
            this.SliderRightButton = new System.Windows.Forms.Button();
            this.Slider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepperSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Settings.Image = global::RoboticArm.Properties.Resources.settings;
            this.Settings.Location = new System.Drawing.Point(9, 9);
            this.Settings.Margin = new System.Windows.Forms.Padding(0);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(50, 50);
            this.Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Settings.TabIndex = 1;
            this.Settings.TabStop = false;
            this.Settings.Click += new System.EventHandler(this.OpenSettings);
            // 
            // servo4
            // 
            this.servo4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.servo4.Location = new System.Drawing.Point(240, 139);
            this.servo4.Maximum = 180;
            this.servo4.Name = "servo4";
            this.servo4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.servo4.Size = new System.Drawing.Size(45, 177);
            this.servo4.TabIndex = 2;
            this.servo4.TickFrequency = 10;
            this.servo4.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.servo4.Value = 90;
            this.servo4.Scroll += new System.EventHandler(this.servo4_Scroll);
            // 
            // servo3
            // 
            this.servo3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.servo3.Location = new System.Drawing.Point(514, 102);
            this.servo3.Maximum = 180;
            this.servo3.Name = "servo3";
            this.servo3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.servo3.Size = new System.Drawing.Size(45, 177);
            this.servo3.TabIndex = 3;
            this.servo3.TickFrequency = 10;
            this.servo3.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.servo3.Value = 90;
            this.servo3.Scroll += new System.EventHandler(this.servo3_Scroll);
            // 
            // servo2
            // 
            this.servo2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.servo2.Location = new System.Drawing.Point(726, 356);
            this.servo2.Maximum = 180;
            this.servo2.Name = "servo2";
            this.servo2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.servo2.Size = new System.Drawing.Size(45, 170);
            this.servo2.TabIndex = 4;
            this.servo2.TickFrequency = 10;
            this.servo2.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.servo2.Value = 90;
            this.servo2.Scroll += new System.EventHandler(this.servo2_Scroll);
            // 
            // servo1
            // 
            this.servo1.AccessibleName = "";
            this.servo1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.servo1.Location = new System.Drawing.Point(618, 256);
            this.servo1.Maximum = 180;
            this.servo1.Name = "servo1";
            this.servo1.Size = new System.Drawing.Size(171, 45);
            this.servo1.TabIndex = 5;
            this.servo1.TickFrequency = 10;
            this.servo1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.servo1.Value = 90;
            this.servo1.Scroll += new System.EventHandler(this.servo1_Scroll);
            // 
            // StepperSpeed
            // 
            this.StepperSpeed.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.StepperSpeed.LargeChange = 50;
            this.StepperSpeed.Location = new System.Drawing.Point(98, 308);
            this.StepperSpeed.Maximum = 255;
            this.StepperSpeed.Minimum = 1;
            this.StepperSpeed.Name = "StepperSpeed";
            this.StepperSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.StepperSpeed.Size = new System.Drawing.Size(45, 103);
            this.StepperSpeed.SmallChange = 2;
            this.StepperSpeed.TabIndex = 6;
            this.StepperSpeed.TickFrequency = 50;
            this.StepperSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.StepperSpeed.Value = 160;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, -84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(910, 711);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // StepperRightButton
            // 
            this.StepperRightButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StepperRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StepperRightButton.Location = new System.Drawing.Point(149, 363);
            this.StepperRightButton.Name = "StepperRightButton";
            this.StepperRightButton.Size = new System.Drawing.Size(52, 48);
            this.StepperRightButton.TabIndex = 9;
            this.StepperRightButton.Text = ">";
            this.StepperRightButton.UseVisualStyleBackColor = false;
            this.StepperRightButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StepperRightButton_MouseDown);
            this.StepperRightButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StepperStop);
            // 
            // StepperLeftButton
            // 
            this.StepperLeftButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StepperLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StepperLeftButton.Location = new System.Drawing.Point(40, 363);
            this.StepperLeftButton.Name = "StepperLeftButton";
            this.StepperLeftButton.Size = new System.Drawing.Size(52, 48);
            this.StepperLeftButton.TabIndex = 10;
            this.StepperLeftButton.Text = "<";
            this.StepperLeftButton.UseVisualStyleBackColor = false;
            this.StepperLeftButton.Click += new System.EventHandler(this.StepperLeftButton_Click);
            this.StepperLeftButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StepperLeftButton_MouseDown);
            this.StepperLeftButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StepperStop);
            // 
            // SliderLeftButton
            // 
            this.SliderLeftButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SliderLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SliderLeftButton.Location = new System.Drawing.Point(385, 465);
            this.SliderLeftButton.Name = "SliderLeftButton";
            this.SliderLeftButton.Size = new System.Drawing.Size(52, 48);
            this.SliderLeftButton.TabIndex = 12;
            this.SliderLeftButton.Text = "<";
            this.SliderLeftButton.UseVisualStyleBackColor = false;
            this.SliderLeftButton.Click += new System.EventHandler(this.SliderLeftButton_Click);
            // 
            // SliderRightButton
            // 
            this.SliderRightButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SliderRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SliderRightButton.Location = new System.Drawing.Point(501, 465);
            this.SliderRightButton.Name = "SliderRightButton";
            this.SliderRightButton.Size = new System.Drawing.Size(52, 48);
            this.SliderRightButton.TabIndex = 11;
            this.SliderRightButton.Text = ">";
            this.SliderRightButton.UseVisualStyleBackColor = false;
            this.SliderRightButton.Click += new System.EventHandler(this.SliderRightButton_Click);
            // 
            // Slider
            // 
            this.Slider.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Slider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Slider.Location = new System.Drawing.Point(443, 465);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(52, 48);
            this.Slider.TabIndex = 13;
            this.Slider.Text = "STOP";
            this.Slider.UseVisualStyleBackColor = false;
            this.Slider.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 593);
            this.Controls.Add(this.Slider);
            this.Controls.Add(this.SliderLeftButton);
            this.Controls.Add(this.SliderRightButton);
            this.Controls.Add(this.StepperLeftButton);
            this.Controls.Add(this.StepperRightButton);
            this.Controls.Add(this.StepperSpeed);
            this.Controls.Add(this.servo1);
            this.Controls.Add(this.servo2);
            this.Controls.Add(this.servo3);
            this.Controls.Add(this.servo4);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Window";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot Arm Controller";
            this.Shown += new System.EventHandler(this.Window_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepperSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Settings;
        private System.Windows.Forms.TrackBar servo4;
        private System.Windows.Forms.TrackBar servo3;
        private System.Windows.Forms.TrackBar servo2;
        private System.Windows.Forms.TrackBar servo1;
        private System.Windows.Forms.TrackBar StepperSpeed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button StepperRightButton;
        private System.Windows.Forms.Button StepperLeftButton;
        private System.Windows.Forms.Button SliderLeftButton;
        private System.Windows.Forms.Button SliderRightButton;
        private System.Windows.Forms.Button Slider;
    }
}

