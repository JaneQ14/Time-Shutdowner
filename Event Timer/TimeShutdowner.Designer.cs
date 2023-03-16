
namespace Event_Timer
{
    partial class TimeShutdowner
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeShutdowner));
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.eventName_ComboBox = new System.Windows.Forms.ComboBox();
            this.clock = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.label_text = new System.Windows.Forms.Label();
            this.preview_text = new System.Windows.Forms.Label();
            this.hide_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(15, 85);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(135, 20);
            this.TimePicker.TabIndex = 2;
            this.TimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(15, 59);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(135, 20);
            this.datePicker.TabIndex = 1;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // eventName_ComboBox
            // 
            this.eventName_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventName_ComboBox.Items.AddRange(new object[] {
            "Shutdown",
            "Restart",
            "Logoff",
            "Lock",
            "Hibernation",
            "Sleep"});
            this.eventName_ComboBox.Location = new System.Drawing.Point(15, 32);
            this.eventName_ComboBox.Name = "eventName_ComboBox";
            this.eventName_ComboBox.Size = new System.Drawing.Size(135, 21);
            this.eventName_ComboBox.TabIndex = 0;
            this.eventName_ComboBox.SelectedIndexChanged += new System.EventHandler(this.eventName_ComboBox_SelectedIndexChanged);
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Location = new System.Drawing.Point(12, 139);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(47, 13);
            this.clock.TabIndex = 10;
            this.clock.Text = "loading..";
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.start_button.Location = new System.Drawing.Point(207, 125);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(77, 22);
            this.start_button.TabIndex = 3;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.startEvent_button);
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Location = new System.Drawing.Point(12, 9);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(38, 13);
            this.label_text.TabIndex = 8;
            this.label_text.Text = "Event:";
            // 
            // preview_text
            // 
            this.preview_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preview_text.Location = new System.Drawing.Point(199, 9);
            this.preview_text.Name = "preview_text";
            this.preview_text.Size = new System.Drawing.Size(93, 143);
            this.preview_text.TabIndex = 9;
            this.preview_text.Text = "Event:";
            // 
            // hide_Button
            // 
            this.hide_Button.Location = new System.Drawing.Point(143, 130);
            this.hide_Button.Name = "hide_Button";
            this.hide_Button.Size = new System.Drawing.Size(50, 22);
            this.hide_Button.TabIndex = 4;
            this.hide_Button.Text = "Hide";
            this.hide_Button.UseVisualStyleBackColor = true;
            this.hide_Button.Visible = false;
            this.hide_Button.Click += new System.EventHandler(this.hide_Button_Click);
            // 
            // EventTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 161);
            this.Controls.Add(this.hide_Button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.eventName_ComboBox);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.preview_text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 200);
            this.MinimumSize = new System.Drawing.Size(320, 200);
            this.Name = "EventTimer";
            this.ShowInTaskbar = false;
            this.Text = "Event Timer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox eventName_ComboBox;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.Label preview_text;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Button hide_Button;
    }
}