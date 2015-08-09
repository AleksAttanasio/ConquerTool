namespace ConquerTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.infoButton = new System.Windows.Forms.Button();
            this.commandsLabel = new System.Windows.Forms.Label();
            this.commandsText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hoursText = new System.Windows.Forms.TextBox();
            this.secondText = new System.Windows.Forms.TextBox();
            this.minutesText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.xText = new System.Windows.Forms.TextBox();
            this.yText = new System.Windows.Forms.TextBox();
            this.saveTxtButton = new System.Windows.Forms.Button();
            this.conquerList = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.helpFake = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.helpPath = new System.Windows.Forms.Button();
            this.textArena = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(385, 12);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(23, 23);
            this.infoButton.TabIndex = 11;
            this.infoButton.Text = "?";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // commandsLabel
            // 
            this.commandsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.commandsLabel.AutoSize = true;
            this.commandsLabel.Location = new System.Drawing.Point(21, 54);
            this.commandsLabel.Name = "commandsLabel";
            this.commandsLabel.Size = new System.Drawing.Size(201, 13);
            this.commandsLabel.TabIndex = 2;
            this.commandsLabel.Text = "Incolla qui la comanda dell\'ordine di fake:";
            // 
            // commandsText
            // 
            this.commandsText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.commandsText.Location = new System.Drawing.Point(21, 76);
            this.commandsText.Name = "commandsText";
            this.commandsText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.commandsText.Size = new System.Drawing.Size(387, 108);
            this.commandsText.TabIndex = 1;
            this.commandsText.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Conquer Tool";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "by JeremyReevo";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inserisci l\'orario di arrivo (hh:mm:ss):";
            // 
            // hoursText
            // 
            this.hoursText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hoursText.Location = new System.Drawing.Point(197, 293);
            this.hoursText.Name = "hoursText";
            this.hoursText.Size = new System.Drawing.Size(32, 20);
            this.hoursText.TabIndex = 3;
            // 
            // secondText
            // 
            this.secondText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.secondText.Location = new System.Drawing.Point(273, 293);
            this.secondText.Name = "secondText";
            this.secondText.Size = new System.Drawing.Size(32, 20);
            this.secondText.TabIndex = 5;
            // 
            // minutesText
            // 
            this.minutesText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minutesText.Location = new System.Drawing.Point(235, 293);
            this.minutesText.Name = "minutesText";
            this.minutesText.Size = new System.Drawing.Size(32, 20);
            this.minutesText.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Inserisci le coordinate del villaggio attaccante (x|y):";
            // 
            // xText
            // 
            this.xText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.xText.Location = new System.Drawing.Point(263, 323);
            this.xText.Name = "xText";
            this.xText.Size = new System.Drawing.Size(32, 20);
            this.xText.TabIndex = 7;
            // 
            // yText
            // 
            this.yText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.yText.Location = new System.Drawing.Point(301, 323);
            this.yText.Name = "yText";
            this.yText.Size = new System.Drawing.Size(32, 20);
            this.yText.TabIndex = 8;
            // 
            // saveTxtButton
            // 
            this.saveTxtButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveTxtButton.Location = new System.Drawing.Point(301, 358);
            this.saveTxtButton.Name = "saveTxtButton";
            this.saveTxtButton.Size = new System.Drawing.Size(103, 31);
            this.saveTxtButton.TabIndex = 10;
            this.saveTxtButton.Text = "Crea file .txt";
            this.saveTxtButton.UseVisualStyleBackColor = true;
            this.saveTxtButton.Click += new System.EventHandler(this.saveTxtButton_Click);
            // 
            // conquerList
            // 
            this.conquerList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.conquerList.Location = new System.Drawing.Point(21, 215);
            this.conquerList.Name = "conquerList";
            this.conquerList.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.conquerList.Size = new System.Drawing.Size(387, 50);
            this.conquerList.TabIndex = 2;
            this.conquerList.Text = "";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Incolla qui la comanda dell\'ordine di attacco di conquista:";
            // 
            // helpFake
            // 
            this.helpFake.Location = new System.Drawing.Point(228, 49);
            this.helpFake.Name = "helpFake";
            this.helpFake.Size = new System.Drawing.Size(23, 23);
            this.helpFake.TabIndex = 12;
            this.helpFake.Text = "?";
            this.helpFake.UseVisualStyleBackColor = true;
            this.helpFake.Click += new System.EventHandler(this.helpFake_Click);
            // 
            // textPath
            // 
            this.textPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textPath.Location = new System.Drawing.Point(76, 364);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(187, 20);
            this.textPath.TabIndex = 9;
            this.textPath.Text = "C:\\Users\\";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Percorso:";
            // 
            // helpPath
            // 
            this.helpPath.Location = new System.Drawing.Point(269, 362);
            this.helpPath.Name = "helpPath";
            this.helpPath.Size = new System.Drawing.Size(23, 23);
            this.helpPath.TabIndex = 13;
            this.helpPath.Text = "?";
            this.helpPath.UseVisualStyleBackColor = true;
            this.helpPath.Click += new System.EventHandler(this.helpPath_Click);
            // 
            // textArena
            // 
            this.textArena.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textArena.Location = new System.Drawing.Point(367, 293);
            this.textArena.Name = "textArena";
            this.textArena.Size = new System.Drawing.Size(32, 20);
            this.textArena.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Arena:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 401);
            this.Controls.Add(this.textArena);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.helpPath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.helpFake);
            this.Controls.Add(this.conquerList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveTxtButton);
            this.Controls.Add(this.xText);
            this.Controls.Add(this.yText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minutesText);
            this.Controls.Add(this.secondText);
            this.Controls.Add(this.hoursText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commandsText);
            this.Controls.Add(this.commandsLabel);
            this.Controls.Add(this.infoButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(433, 440);
            this.MinimumSize = new System.Drawing.Size(433, 440);
            this.Name = "Form1";
            this.Text = "Conquer Tool (v1.4)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Label commandsLabel;
        private System.Windows.Forms.RichTextBox commandsText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hoursText;
        private System.Windows.Forms.TextBox secondText;
        private System.Windows.Forms.TextBox minutesText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xText;
        private System.Windows.Forms.TextBox yText;
        private System.Windows.Forms.Button saveTxtButton;
        private System.Windows.Forms.RichTextBox conquerList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button helpFake;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button helpPath;
        private System.Windows.Forms.TextBox textArena;
        private System.Windows.Forms.Label label7;
    }
}

