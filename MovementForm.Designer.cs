namespace WindowsFormsApp1
{
    partial class MovementForm
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
            this.ChooseMovementType = new System.Windows.Forms.Label();
            this.comboBoxChooseMovementType = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.Speed = new System.Windows.Forms.Label();
            this.StartCoordinate = new System.Windows.Forms.Label();
            this.Acceleration = new System.Windows.Forms.Label();
            this.Amplitude = new System.Windows.Forms.Label();
            this.Frequency = new System.Windows.Forms.Label();
            this.StartPhase = new System.Windows.Forms.Label();
            this.maskedTextBoxSpeed = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxStartCoordinate = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAcceleration = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAmplitude = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxFrequency = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxStartPhase = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // ChooseMovementType
            // 
            this.ChooseMovementType.AutoSize = true;
            this.ChooseMovementType.Location = new System.Drawing.Point(13, 13);
            this.ChooseMovementType.Name = "ChooseMovementType";
            this.ChooseMovementType.Size = new System.Drawing.Size(126, 13);
            this.ChooseMovementType.TabIndex = 0;
            this.ChooseMovementType.Text = "Choose Movement Type:";
            // 
            // comboBoxChooseMovementType
            // 
            this.comboBoxChooseMovementType.FormattingEnabled = true;
            this.comboBoxChooseMovementType.Items.AddRange(new object[] {
            "Uniform",
            "Acelerated",
            "Oscillated"});
            this.comboBoxChooseMovementType.Location = new System.Drawing.Point(13, 30);
            this.comboBoxChooseMovementType.Name = "comboBoxChooseMovementType";
            this.comboBoxChooseMovementType.Size = new System.Drawing.Size(142, 21);
            this.comboBoxChooseMovementType.TabIndex = 1;
            this.comboBoxChooseMovementType.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseMovementType_SelectedIndexChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOk.Location = new System.Drawing.Point(13, 297);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(144, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.Location = new System.Drawing.Point(197, 297);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(96, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Location = new System.Drawing.Point(24, 73);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(38, 13);
            this.Speed.TabIndex = 4;
            this.Speed.Text = "Speed";
            // 
            // StartCoordinate
            // 
            this.StartCoordinate.AutoSize = true;
            this.StartCoordinate.Location = new System.Drawing.Point(20, 105);
            this.StartCoordinate.Name = "StartCoordinate";
            this.StartCoordinate.Size = new System.Drawing.Size(83, 13);
            this.StartCoordinate.TabIndex = 5;
            this.StartCoordinate.Text = "Start Coordinate";
            // 
            // Acceleration
            // 
            this.Acceleration.AutoSize = true;
            this.Acceleration.Location = new System.Drawing.Point(19, 134);
            this.Acceleration.Name = "Acceleration";
            this.Acceleration.Size = new System.Drawing.Size(66, 13);
            this.Acceleration.TabIndex = 6;
            this.Acceleration.Text = "Acceleration";
            // 
            // Amplitude
            // 
            this.Amplitude.AutoSize = true;
            this.Amplitude.Location = new System.Drawing.Point(19, 164);
            this.Amplitude.Name = "Amplitude";
            this.Amplitude.Size = new System.Drawing.Size(53, 13);
            this.Amplitude.TabIndex = 7;
            this.Amplitude.Text = "Amplitude";
            this.Amplitude.Click += new System.EventHandler(this.Amplitude_Click);
            // 
            // Frequency
            // 
            this.Frequency.AutoSize = true;
            this.Frequency.Location = new System.Drawing.Point(20, 192);
            this.Frequency.Name = "Frequency";
            this.Frequency.Size = new System.Drawing.Size(57, 13);
            this.Frequency.TabIndex = 8;
            this.Frequency.Text = "Frequency";
            // 
            // StartPhase
            // 
            this.StartPhase.AutoSize = true;
            this.StartPhase.Location = new System.Drawing.Point(19, 219);
            this.StartPhase.Name = "StartPhase";
            this.StartPhase.Size = new System.Drawing.Size(62, 13);
            this.StartPhase.TabIndex = 9;
            this.StartPhase.Text = "Start Phase";
            // 
            // maskedTextBoxSpeed
            // 
            this.maskedTextBoxSpeed.Location = new System.Drawing.Point(136, 70);
            this.maskedTextBoxSpeed.Name = "maskedTextBoxSpeed";
            this.maskedTextBoxSpeed.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxSpeed.TabIndex = 10;
            this.maskedTextBoxSpeed.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxSpeed_MaskInputRejected);
            // 
            // maskedTextBoxStartCoordinate
            // 
            this.maskedTextBoxStartCoordinate.Location = new System.Drawing.Point(136, 102);
            this.maskedTextBoxStartCoordinate.Name = "maskedTextBoxStartCoordinate";
            this.maskedTextBoxStartCoordinate.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxStartCoordinate.TabIndex = 11;
            // 
            // maskedTextBoxAcceleration
            // 
            this.maskedTextBoxAcceleration.Location = new System.Drawing.Point(136, 131);
            this.maskedTextBoxAcceleration.Name = "maskedTextBoxAcceleration";
            this.maskedTextBoxAcceleration.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxAcceleration.TabIndex = 12;
            // 
            // maskedTextBoxAmplitude
            // 
            this.maskedTextBoxAmplitude.Location = new System.Drawing.Point(136, 161);
            this.maskedTextBoxAmplitude.Name = "maskedTextBoxAmplitude";
            this.maskedTextBoxAmplitude.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxAmplitude.TabIndex = 13;
            // 
            // maskedTextBoxFrequency
            // 
            this.maskedTextBoxFrequency.Location = new System.Drawing.Point(136, 189);
            this.maskedTextBoxFrequency.Name = "maskedTextBoxFrequency";
            this.maskedTextBoxFrequency.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxFrequency.TabIndex = 14;
            // 
            // maskedTextBoxStartPhase
            // 
            this.maskedTextBoxStartPhase.Location = new System.Drawing.Point(136, 212);
            this.maskedTextBoxStartPhase.Name = "maskedTextBoxStartPhase";
            this.maskedTextBoxStartPhase.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxStartPhase.TabIndex = 15;
            // 
            // MovementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 340);
            this.Controls.Add(this.maskedTextBoxStartPhase);
            this.Controls.Add(this.maskedTextBoxFrequency);
            this.Controls.Add(this.maskedTextBoxAmplitude);
            this.Controls.Add(this.maskedTextBoxAcceleration);
            this.Controls.Add(this.maskedTextBoxStartCoordinate);
            this.Controls.Add(this.maskedTextBoxSpeed);
            this.Controls.Add(this.StartPhase);
            this.Controls.Add(this.Frequency);
            this.Controls.Add(this.Amplitude);
            this.Controls.Add(this.Acceleration);
            this.Controls.Add(this.StartCoordinate);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.comboBoxChooseMovementType);
            this.Controls.Add(this.ChooseMovementType);
            this.Name = "MovementForm";
            this.Text = "MovementForm";
            this.Load += new System.EventHandler(this.MovementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChooseMovementType;
        private System.Windows.Forms.ComboBox comboBoxChooseMovementType;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.Label StartCoordinate;
        private System.Windows.Forms.Label Acceleration;
        private System.Windows.Forms.Label Amplitude;
        private System.Windows.Forms.Label Frequency;
        private System.Windows.Forms.Label StartPhase;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSpeed;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartCoordinate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAcceleration;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmplitude;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFrequency;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartPhase;
    }
}