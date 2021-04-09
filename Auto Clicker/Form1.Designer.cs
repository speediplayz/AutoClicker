namespace Auto_Clicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chkLeft = new System.Windows.Forms.CheckBox();
            this.chkRight = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTrigger = new System.Windows.Forms.TextBox();
            this.chkPressLeft = new System.Windows.Forms.CheckBox();
            this.chkPressRight = new System.Windows.Forms.CheckBox();
            this.txtKeyToPress = new System.Windows.Forms.TextBox();
            this.txtCPS = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkStacked = new System.Windows.Forms.CheckBox();
            this.cmdToggle = new System.Windows.Forms.Button();
            this.txtClicks = new System.Windows.Forms.TextBox();
            this.grpTrigger = new System.Windows.Forms.GroupBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.numScrollLines = new System.Windows.Forms.NumericUpDown();
            this.chkScroll = new System.Windows.Forms.CheckBox();
            this.chkToggled = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtCPS)).BeginInit();
            this.grpTrigger.SuspendLayout();
            this.grpOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScrollLines)).BeginInit();
            this.SuspendLayout();
            // 
            // chkLeft
            // 
            this.chkLeft.AutoSize = true;
            this.chkLeft.Location = new System.Drawing.Point(16, 103);
            this.chkLeft.Name = "chkLeft";
            this.chkLeft.Size = new System.Drawing.Size(70, 17);
            this.chkLeft.TabIndex = 0;
            this.chkLeft.Text = "Left Click";
            this.chkLeft.UseVisualStyleBackColor = true;
            // 
            // chkRight
            // 
            this.chkRight.AutoSize = true;
            this.chkRight.Location = new System.Drawing.Point(16, 124);
            this.chkRight.Name = "chkRight";
            this.chkRight.Size = new System.Drawing.Size(77, 17);
            this.chkRight.TabIndex = 1;
            this.chkRight.Text = "Right Click";
            this.chkRight.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CPS";
            // 
            // txtTrigger
            // 
            this.txtTrigger.Location = new System.Drawing.Point(3, 14);
            this.txtTrigger.MaxLength = 100;
            this.txtTrigger.Name = "txtTrigger";
            this.txtTrigger.Size = new System.Drawing.Size(64, 20);
            this.txtTrigger.TabIndex = 4;
            // 
            // chkPressLeft
            // 
            this.chkPressLeft.AutoSize = true;
            this.chkPressLeft.Location = new System.Drawing.Point(16, 190);
            this.chkPressLeft.Name = "chkPressLeft";
            this.chkPressLeft.Size = new System.Drawing.Size(70, 17);
            this.chkPressLeft.TabIndex = 8;
            this.chkPressLeft.Text = "Left Click";
            this.chkPressLeft.UseVisualStyleBackColor = true;
            // 
            // chkPressRight
            // 
            this.chkPressRight.AutoSize = true;
            this.chkPressRight.Location = new System.Drawing.Point(16, 211);
            this.chkPressRight.Name = "chkPressRight";
            this.chkPressRight.Size = new System.Drawing.Size(77, 17);
            this.chkPressRight.TabIndex = 9;
            this.chkPressRight.Text = "Right Click";
            this.chkPressRight.UseVisualStyleBackColor = true;
            // 
            // txtKeyToPress
            // 
            this.txtKeyToPress.Location = new System.Drawing.Point(16, 164);
            this.txtKeyToPress.MaxLength = 100;
            this.txtKeyToPress.Name = "txtKeyToPress";
            this.txtKeyToPress.Size = new System.Drawing.Size(64, 20);
            this.txtKeyToPress.TabIndex = 10;
            // 
            // txtCPS
            // 
            this.txtCPS.Location = new System.Drawing.Point(13, 38);
            this.txtCPS.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.txtCPS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCPS.Name = "txtCPS";
            this.txtCPS.Size = new System.Drawing.Size(65, 20);
            this.txtCPS.TabIndex = 14;
            this.txtCPS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCPS.ValueChanged += new System.EventHandler(this.txtCPS_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chkStacked
            // 
            this.chkStacked.AutoSize = true;
            this.chkStacked.Location = new System.Drawing.Point(3, 106);
            this.chkStacked.Name = "chkStacked";
            this.chkStacked.Size = new System.Drawing.Size(92, 17);
            this.chkStacked.TabIndex = 15;
            this.chkStacked.Text = "Stacked Click";
            this.chkStacked.UseVisualStyleBackColor = true;
            // 
            // cmdToggle
            // 
            this.cmdToggle.Location = new System.Drawing.Point(12, 281);
            this.cmdToggle.Name = "cmdToggle";
            this.cmdToggle.Size = new System.Drawing.Size(75, 23);
            this.cmdToggle.TabIndex = 12;
            this.cmdToggle.Text = "Stop";
            this.cmdToggle.UseVisualStyleBackColor = true;
            this.cmdToggle.Click += new System.EventHandler(this.cmdToggle_Click);
            // 
            // txtClicks
            // 
            this.txtClicks.Location = new System.Drawing.Point(13, 13);
            this.txtClicks.Name = "txtClicks";
            this.txtClicks.Size = new System.Drawing.Size(159, 20);
            this.txtClicks.TabIndex = 16;
            this.txtClicks.Text = "0";
            // 
            // grpTrigger
            // 
            this.grpTrigger.Controls.Add(this.txtTrigger);
            this.grpTrigger.Location = new System.Drawing.Point(13, 64);
            this.grpTrigger.Name = "grpTrigger";
            this.grpTrigger.Size = new System.Drawing.Size(160, 80);
            this.grpTrigger.TabIndex = 17;
            this.grpTrigger.TabStop = false;
            this.grpTrigger.Text = "Trigger";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.numScrollLines);
            this.grpOutput.Controls.Add(this.chkStacked);
            this.grpOutput.Controls.Add(this.chkScroll);
            this.grpOutput.Location = new System.Drawing.Point(13, 150);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(159, 125);
            this.grpOutput.TabIndex = 18;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // numScrollLines
            // 
            this.numScrollLines.Location = new System.Drawing.Point(61, 83);
            this.numScrollLines.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numScrollLines.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numScrollLines.Name = "numScrollLines";
            this.numScrollLines.Size = new System.Drawing.Size(92, 20);
            this.numScrollLines.TabIndex = 20;
            this.numScrollLines.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkScroll
            // 
            this.chkScroll.AutoSize = true;
            this.chkScroll.Location = new System.Drawing.Point(3, 83);
            this.chkScroll.Name = "chkScroll";
            this.chkScroll.Size = new System.Drawing.Size(52, 17);
            this.chkScroll.TabIndex = 19;
            this.chkScroll.Text = "Scroll";
            this.chkScroll.UseVisualStyleBackColor = true;
            // 
            // chkToggled
            // 
            this.chkToggled.AutoSize = true;
            this.chkToggled.Location = new System.Drawing.Point(13, 310);
            this.chkToggled.Name = "chkToggled";
            this.chkToggled.Size = new System.Drawing.Size(59, 17);
            this.chkToggled.TabIndex = 19;
            this.chkToggled.Text = "Toggle";
            this.chkToggled.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 334);
            this.Controls.Add(this.chkToggled);
            this.Controls.Add(this.txtClicks);
            this.Controls.Add(this.txtCPS);
            this.Controls.Add(this.cmdToggle);
            this.Controls.Add(this.txtKeyToPress);
            this.Controls.Add(this.chkPressRight);
            this.Controls.Add(this.chkPressLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkRight);
            this.Controls.Add(this.chkLeft);
            this.Controls.Add(this.grpTrigger);
            this.Controls.Add(this.grpOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AutoClicker";
            ((System.ComponentModel.ISupportInitialize)(this.txtCPS)).EndInit();
            this.grpTrigger.ResumeLayout(false);
            this.grpTrigger.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScrollLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkLeft;
        private System.Windows.Forms.CheckBox chkRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrigger;
        private System.Windows.Forms.CheckBox chkPressLeft;
        private System.Windows.Forms.CheckBox chkPressRight;
        private System.Windows.Forms.TextBox txtKeyToPress;
        private System.Windows.Forms.NumericUpDown txtCPS;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkStacked;
        private System.Windows.Forms.Button cmdToggle;
        private System.Windows.Forms.TextBox txtClicks;
        private System.Windows.Forms.GroupBox grpTrigger;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.NumericUpDown numScrollLines;
        private System.Windows.Forms.CheckBox chkScroll;
        private System.Windows.Forms.CheckBox chkToggled;
    }
}

