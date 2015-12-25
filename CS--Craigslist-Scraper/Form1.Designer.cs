namespace CS__Craigslist_Scraper
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
            this.mainTabWindow = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.browserTab = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.outputTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.scrapeOutputMainSplit = new System.Windows.Forms.SplitContainer();
            this.tbScrape = new System.Windows.Forms.TextBox();
            this.optionsTab = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.mainTabWindow.SuspendLayout();
            this.mainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.browserTab.SuspendLayout();
            this.outputTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scrapeOutputMainSplit)).BeginInit();
            this.scrapeOutputMainSplit.Panel1.SuspendLayout();
            this.scrapeOutputMainSplit.Panel2.SuspendLayout();
            this.scrapeOutputMainSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabWindow
            // 
            this.mainTabWindow.Controls.Add(this.mainTab);
            this.mainTabWindow.Controls.Add(this.browserTab);
            this.mainTabWindow.Controls.Add(this.outputTab);
            this.mainTabWindow.Controls.Add(this.optionsTab);
            this.mainTabWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabWindow.Location = new System.Drawing.Point(0, 0);
            this.mainTabWindow.Name = "mainTabWindow";
            this.mainTabWindow.SelectedIndex = 0;
            this.mainTabWindow.Size = new System.Drawing.Size(737, 646);
            this.mainTabWindow.TabIndex = 0;
            // 
            // mainTab
            // 
            this.mainTab.BackColor = System.Drawing.Color.Gainsboro;
            this.mainTab.Controls.Add(this.label6);
            this.mainTab.Controls.Add(this.button4);
            this.mainTab.Controls.Add(this.button5);
            this.mainTab.Controls.Add(this.label5);
            this.mainTab.Controls.Add(this.label4);
            this.mainTab.Controls.Add(this.button2);
            this.mainTab.Controls.Add(this.button3);
            this.mainTab.Controls.Add(this.button1);
            this.mainTab.Controls.Add(this.startButton);
            this.mainTab.Controls.Add(this.trackBar1);
            this.mainTab.Controls.Add(this.label1);
            this.mainTab.Location = new System.Drawing.Point(4, 22);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(729, 620);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Scraper";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 62);
            this.button2.TabIndex = 5;
            this.button2.Text = "Stop Scrape";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(631, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 62);
            this.button3.TabIndex = 4;
            this.button3.Text = "Start Scrape";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "Stop Scrape";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(631, 36);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 62);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start Scrape";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(142, 6);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(136, 23);
            this.trackBar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max Number to Scrape";
            // 
            // browserTab
            // 
            this.browserTab.Controls.Add(this.webBrowser1);
            this.browserTab.Location = new System.Drawing.Point(4, 22);
            this.browserTab.Name = "browserTab";
            this.browserTab.Padding = new System.Windows.Forms.Padding(3);
            this.browserTab.Size = new System.Drawing.Size(729, 620);
            this.browserTab.TabIndex = 1;
            this.browserTab.Text = "Browser Preview";
            this.browserTab.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(723, 614);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.craigslist.org/about/sites#US", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // outputTab
            // 
            this.outputTab.Controls.Add(this.splitContainer2);
            this.outputTab.Location = new System.Drawing.Point(4, 22);
            this.outputTab.Name = "outputTab";
            this.outputTab.Padding = new System.Windows.Forms.Padding(3);
            this.outputTab.Size = new System.Drawing.Size(729, 620);
            this.outputTab.TabIndex = 2;
            this.outputTab.Text = "Scrape Output";
            this.outputTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.scrapeOutputMainSplit);
            this.splitContainer2.Size = new System.Drawing.Size(723, 614);
            this.splitContainer2.SplitterDistance = 60;
            this.splitContainer2.TabIndex = 2;
            // 
            // scrapeOutputMainSplit
            // 
            this.scrapeOutputMainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrapeOutputMainSplit.Location = new System.Drawing.Point(0, 0);
            this.scrapeOutputMainSplit.Name = "scrapeOutputMainSplit";
            this.scrapeOutputMainSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scrapeOutputMainSplit.Panel1
            // 
            this.scrapeOutputMainSplit.Panel1.Controls.Add(this.tbScrape);
            // 
            // scrapeOutputMainSplit.Panel2
            // 
            this.scrapeOutputMainSplit.Panel2.Controls.Add(this.textBox4);
            this.scrapeOutputMainSplit.Size = new System.Drawing.Size(723, 550);
            this.scrapeOutputMainSplit.SplitterDistance = 275;
            this.scrapeOutputMainSplit.TabIndex = 0;
            // 
            // tbScrape
            // 
            this.tbScrape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbScrape.Location = new System.Drawing.Point(0, 0);
            this.tbScrape.Multiline = true;
            this.tbScrape.Name = "tbScrape";
            this.tbScrape.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbScrape.Size = new System.Drawing.Size(723, 275);
            this.tbScrape.TabIndex = 0;
            // 
            // optionsTab
            // 
            this.optionsTab.Location = new System.Drawing.Point(4, 22);
            this.optionsTab.Name = "optionsTab";
            this.optionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.optionsTab.Size = new System.Drawing.Size(729, 620);
            this.optionsTab.TabIndex = 3;
            this.optionsTab.Text = "Options";
            this.optionsTab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(723, 285);
            this.textBox1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox3);
            this.splitContainer1.Size = new System.Drawing.Size(723, 289);
            this.splitContainer1.SplitterDistance = 360;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(360, 289);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(359, 289);
            this.textBox3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(577, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pull listing pages";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(579, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pull Contact Pages";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(579, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Extract Numbers";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(550, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 62);
            this.button4.TabIndex = 9;
            this.button4.Text = "Stop Scrape";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(631, 239);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 62);
            this.button5.TabIndex = 8;
            this.button5.Text = "Start Scrape";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(0, 0);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(723, 271);
            this.textBox4.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 646);
            this.Controls.Add(this.mainTabWindow);
            this.Name = "Form1";
            this.Text = "Craigslist Scraper";
            this.mainTabWindow.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.browserTab.ResumeLayout(false);
            this.outputTab.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.scrapeOutputMainSplit.Panel1.ResumeLayout(false);
            this.scrapeOutputMainSplit.Panel1.PerformLayout();
            this.scrapeOutputMainSplit.Panel2.ResumeLayout(false);
            this.scrapeOutputMainSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scrapeOutputMainSplit)).EndInit();
            this.scrapeOutputMainSplit.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabWindow;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TabPage browserTab;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage outputTab;
        private System.Windows.Forms.TabPage optionsTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer scrapeOutputMainSplit;
        private System.Windows.Forms.TextBox tbScrape;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
    }
}

