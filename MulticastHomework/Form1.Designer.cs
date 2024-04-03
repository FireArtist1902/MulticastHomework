namespace MulticastHomework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GroupIp = new TextBox();
            Port = new TextBox();
            Messager = new TextBox();
            Name = new TextBox();
            Message = new TextBox();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // GroupIp
            // 
            GroupIp.Location = new Point(12, 62);
            GroupIp.Name = "GroupIp";
            GroupIp.Size = new Size(179, 27);
            GroupIp.TabIndex = 0;
            GroupIp.Text = "235.5.5.11";
            // 
            // Port
            // 
            Port.Location = new Point(258, 62);
            Port.Name = "Port";
            Port.Size = new Size(125, 27);
            Port.TabIndex = 1;
            Port.Text = "8001";
            // 
            // Messager
            // 
            Messager.Location = new Point(12, 244);
            Messager.Multiline = true;
            Messager.Name = "Messager";
            Messager.Size = new Size(546, 242);
            Messager.TabIndex = 4;
            // 
            // Name
            // 
            Name.Location = new Point(12, 503);
            Name.Name = "Name";
            Name.Size = new Size(125, 27);
            Name.TabIndex = 5;
            Name.Text = "Vadym";
            // 
            // Message
            // 
            Message.Location = new Point(12, 536);
            Message.Multiline = true;
            Message.Name = "Message";
            Message.Size = new Size(546, 108);
            Message.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(464, 492);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "Send";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(219, 492);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Receive";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 650);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(Message);
            Controls.Add(Name);
            Controls.Add(Messager);
            Controls.Add(Port);
            Controls.Add(GroupIp);
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button1;
        static private TextBox Port;
        static private TextBox Messager;
        static private TextBox Message;
        static private TextBox GroupIp;
        static private TextBox Name;
    }
}