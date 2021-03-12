
namespace Circuits_and_Physics_Calculator
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
            this.OpGroup = new System.Windows.Forms.GroupBox();
            this.Physics = new System.Windows.Forms.RadioButton();
            this.Circuits = new System.Windows.Forms.RadioButton();
            this.CGroup = new System.Windows.Forms.GroupBox();
            this.Power3 = new System.Windows.Forms.RadioButton();
            this.Power2 = new System.Windows.Forms.RadioButton();
            this.Power1 = new System.Windows.Forms.RadioButton();
            this.Resistor = new System.Windows.Forms.RadioButton();
            this.Current = new System.Windows.Forms.RadioButton();
            this.Voltage = new System.Windows.Forms.RadioButton();
            this.SeriesPara = new System.Windows.Forms.Button();
            this.Pgroup = new System.Windows.Forms.GroupBox();
            this.Work = new System.Windows.Forms.RadioButton();
            this.Pressure = new System.Windows.Forms.RadioButton();
            this.Force = new System.Windows.Forms.RadioButton();
            this.Speed = new System.Windows.Forms.RadioButton();
            this.Distance = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Solve = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.anspanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OpGroup.SuspendLayout();
            this.CGroup.SuspendLayout();
            this.Pgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.anspanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpGroup
            // 
            this.OpGroup.Controls.Add(this.Physics);
            this.OpGroup.Controls.Add(this.Circuits);
            this.OpGroup.Location = new System.Drawing.Point(66, 39);
            this.OpGroup.Name = "OpGroup";
            this.OpGroup.Size = new System.Drawing.Size(146, 91);
            this.OpGroup.TabIndex = 0;
            this.OpGroup.TabStop = false;
            this.OpGroup.Text = "Operation Group";
            // 
            // Physics
            // 
            this.Physics.AutoSize = true;
            this.Physics.Location = new System.Drawing.Point(28, 52);
            this.Physics.Name = "Physics";
            this.Physics.Size = new System.Drawing.Size(61, 17);
            this.Physics.TabIndex = 1;
            this.Physics.TabStop = true;
            this.Physics.Text = "Physics";
            this.Physics.UseVisualStyleBackColor = true;
            this.Physics.CheckedChanged += new System.EventHandler(this.Physics_CheckedChanged);
            // 
            // Circuits
            // 
            this.Circuits.AutoSize = true;
            this.Circuits.Location = new System.Drawing.Point(28, 29);
            this.Circuits.Name = "Circuits";
            this.Circuits.Size = new System.Drawing.Size(59, 17);
            this.Circuits.TabIndex = 0;
            this.Circuits.TabStop = true;
            this.Circuits.Text = "Circuits";
            this.Circuits.UseVisualStyleBackColor = true;
            this.Circuits.CheckedChanged += new System.EventHandler(this.Circuits_CheckedChanged);
            // 
            // CGroup
            // 
            this.CGroup.Controls.Add(this.Power3);
            this.CGroup.Controls.Add(this.Power2);
            this.CGroup.Controls.Add(this.Power1);
            this.CGroup.Controls.Add(this.Resistor);
            this.CGroup.Controls.Add(this.Current);
            this.CGroup.Controls.Add(this.Voltage);
            this.CGroup.Location = new System.Drawing.Point(66, 148);
            this.CGroup.Name = "CGroup";
            this.CGroup.Size = new System.Drawing.Size(146, 192);
            this.CGroup.TabIndex = 1;
            this.CGroup.TabStop = false;
            this.CGroup.Text = "Circuits";
            this.CGroup.Visible = false;
            // 
            // Power3
            // 
            this.Power3.AutoSize = true;
            this.Power3.Location = new System.Drawing.Point(33, 149);
            this.Power3.Name = "Power3";
            this.Power3.Size = new System.Drawing.Size(79, 17);
            this.Power3.TabIndex = 5;
            this.Power3.TabStop = true;
            this.Power3.Text = "Power (VR)";
            this.Power3.UseVisualStyleBackColor = true;
            this.Power3.CheckedChanged += new System.EventHandler(this.Power3_CheckedChanged);
            // 
            // Power2
            // 
            this.Power2.AutoSize = true;
            this.Power2.Location = new System.Drawing.Point(33, 126);
            this.Power2.Name = "Power2";
            this.Power2.Size = new System.Drawing.Size(75, 17);
            this.Power2.TabIndex = 4;
            this.Power2.TabStop = true;
            this.Power2.Text = "Power (IR)";
            this.Power2.UseVisualStyleBackColor = true;
            this.Power2.CheckedChanged += new System.EventHandler(this.Power2_CheckedChanged);
            // 
            // Power1
            // 
            this.Power1.AutoSize = true;
            this.Power1.Location = new System.Drawing.Point(33, 103);
            this.Power1.Name = "Power1";
            this.Power1.Size = new System.Drawing.Size(71, 17);
            this.Power1.TabIndex = 3;
            this.Power1.TabStop = true;
            this.Power1.Text = "Power(IV)";
            this.Power1.UseVisualStyleBackColor = true;
            this.Power1.CheckedChanged += new System.EventHandler(this.Power1_CheckedChanged);
            // 
            // Resistor
            // 
            this.Resistor.AutoSize = true;
            this.Resistor.Location = new System.Drawing.Point(33, 80);
            this.Resistor.Name = "Resistor";
            this.Resistor.Size = new System.Drawing.Size(78, 17);
            this.Resistor.TabIndex = 2;
            this.Resistor.TabStop = true;
            this.Resistor.Text = "Resistance";
            this.Resistor.UseVisualStyleBackColor = true;
            this.Resistor.CheckedChanged += new System.EventHandler(this.Resistor_CheckedChanged);
            // 
            // Current
            // 
            this.Current.AutoSize = true;
            this.Current.Location = new System.Drawing.Point(33, 57);
            this.Current.Name = "Current";
            this.Current.Size = new System.Drawing.Size(59, 17);
            this.Current.TabIndex = 1;
            this.Current.TabStop = true;
            this.Current.Text = "Current";
            this.Current.UseVisualStyleBackColor = true;
            this.Current.CheckedChanged += new System.EventHandler(this.Current_CheckedChanged);
            // 
            // Voltage
            // 
            this.Voltage.AutoSize = true;
            this.Voltage.Location = new System.Drawing.Point(33, 34);
            this.Voltage.Name = "Voltage";
            this.Voltage.Size = new System.Drawing.Size(61, 17);
            this.Voltage.TabIndex = 0;
            this.Voltage.TabStop = true;
            this.Voltage.Text = "Voltage";
            this.Voltage.UseVisualStyleBackColor = true;
            this.Voltage.CheckedChanged += new System.EventHandler(this.Voltage_CheckedChanged);
            // 
            // SeriesPara
            // 
            this.SeriesPara.Location = new System.Drawing.Point(74, 346);
            this.SeriesPara.Name = "SeriesPara";
            this.SeriesPara.Size = new System.Drawing.Size(125, 23);
            this.SeriesPara.TabIndex = 2;
            this.SeriesPara.Text = "Series/Parallel";
            this.SeriesPara.UseVisualStyleBackColor = true;
            this.SeriesPara.Visible = false;
            this.SeriesPara.Click += new System.EventHandler(this.SeriesPara_Click);
            // 
            // Pgroup
            // 
            this.Pgroup.Controls.Add(this.Work);
            this.Pgroup.Controls.Add(this.Pressure);
            this.Pgroup.Controls.Add(this.Force);
            this.Pgroup.Controls.Add(this.Speed);
            this.Pgroup.Controls.Add(this.Distance);
            this.Pgroup.Location = new System.Drawing.Point(66, 148);
            this.Pgroup.Name = "Pgroup";
            this.Pgroup.Size = new System.Drawing.Size(146, 192);
            this.Pgroup.TabIndex = 4;
            this.Pgroup.TabStop = false;
            this.Pgroup.Text = "Physics";
            this.Pgroup.Visible = false;
            // 
            // Work
            // 
            this.Work.AutoSize = true;
            this.Work.Location = new System.Drawing.Point(26, 132);
            this.Work.Name = "Work";
            this.Work.Size = new System.Drawing.Size(51, 17);
            this.Work.TabIndex = 6;
            this.Work.TabStop = true;
            this.Work.Text = "Work";
            this.Work.UseVisualStyleBackColor = true;
            this.Work.CheckedChanged += new System.EventHandler(this.Work_CheckedChanged);
            // 
            // Pressure
            // 
            this.Pressure.AutoSize = true;
            this.Pressure.Location = new System.Drawing.Point(26, 107);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(66, 17);
            this.Pressure.TabIndex = 5;
            this.Pressure.TabStop = true;
            this.Pressure.Text = "Pressure";
            this.Pressure.UseVisualStyleBackColor = true;
            this.Pressure.CheckedChanged += new System.EventHandler(this.Pressure_CheckedChanged);
            // 
            // Force
            // 
            this.Force.AutoSize = true;
            this.Force.Location = new System.Drawing.Point(26, 82);
            this.Force.Name = "Force";
            this.Force.Size = new System.Drawing.Size(52, 17);
            this.Force.TabIndex = 3;
            this.Force.TabStop = true;
            this.Force.Text = "Force";
            this.Force.UseVisualStyleBackColor = true;
            this.Force.CheckedChanged += new System.EventHandler(this.Force_CheckedChanged);
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Location = new System.Drawing.Point(26, 59);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(98, 17);
            this.Speed.TabIndex = 1;
            this.Speed.TabStop = true;
            this.Speed.Text = "Speed/Velocity";
            this.Speed.UseVisualStyleBackColor = true;
            this.Speed.CheckedChanged += new System.EventHandler(this.Speed_CheckedChanged);
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Location = new System.Drawing.Point(26, 36);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(67, 17);
            this.Distance.TabIndex = 0;
            this.Distance.TabStop = true;
            this.Distance.Text = "Distance";
            this.Distance.UseVisualStyleBackColor = true;
            this.Distance.CheckedChanged += new System.EventHandler(this.Distance_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "The Answer is:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(23, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Visible = false;
            // 
            // Solve
            // 
            this.Solve.Location = new System.Drawing.Point(298, 243);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(75, 23);
            this.Solve.TabIndex = 11;
            this.Solve.Text = "Solve";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Visible = false;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(103, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.ImageLocation = "C:\\Users\\JB\\source\\repos\\Circuits and Physics Calculator";
            this.pictureBox1.Location = new System.Drawing.Point(253, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // anspanel
            // 
            this.anspanel.Controls.Add(this.label3);
            this.anspanel.Controls.Add(this.label4);
            this.anspanel.Controls.Add(this.label5);
            this.anspanel.Location = new System.Drawing.Point(271, 272);
            this.anspanel.Name = "anspanel";
            this.anspanel.Size = new System.Drawing.Size(142, 68);
            this.anspanel.TabIndex = 14;
            this.anspanel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(254, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 88);
            this.panel2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Circuits_and_Physics_Calculator.Properties.Resources.Math_Background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 402);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.anspanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Solve);
            this.Controls.Add(this.Pgroup);
            this.Controls.Add(this.SeriesPara);
            this.Controls.Add(this.CGroup);
            this.Controls.Add(this.OpGroup);
            this.Name = "Form1";
            this.Text = "Circuits and Physics Calculator";
            this.OpGroup.ResumeLayout(false);
            this.OpGroup.PerformLayout();
            this.CGroup.ResumeLayout(false);
            this.CGroup.PerformLayout();
            this.Pgroup.ResumeLayout(false);
            this.Pgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.anspanel.ResumeLayout(false);
            this.anspanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OpGroup;
        private System.Windows.Forms.RadioButton Physics;
        private System.Windows.Forms.RadioButton Circuits;
        private System.Windows.Forms.GroupBox CGroup;
        private System.Windows.Forms.RadioButton Power3;
        private System.Windows.Forms.RadioButton Power2;
        private System.Windows.Forms.RadioButton Power1;
        private System.Windows.Forms.RadioButton Resistor;
        private System.Windows.Forms.RadioButton Current;
        private System.Windows.Forms.RadioButton Voltage;
        private System.Windows.Forms.Button SeriesPara;
        private System.Windows.Forms.GroupBox Pgroup;
        private System.Windows.Forms.RadioButton Work;
        private System.Windows.Forms.RadioButton Pressure;
        private System.Windows.Forms.RadioButton Force;
        private System.Windows.Forms.RadioButton Speed;
        private System.Windows.Forms.RadioButton Distance;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Solve;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel anspanel;
        private System.Windows.Forms.Panel panel2;
    }
}

