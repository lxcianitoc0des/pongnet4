namespace Pong
{
    partial class AboutForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.jug1 = new System.Windows.Forms.PictureBox();
            this.jug2 = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.bola = new System.Windows.Forms.PictureBox();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyF3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePlayerUsernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aliceBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transparentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deepSkyBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antiqueWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsCPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infiniteModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerInfiniteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doublePongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutF7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScoreLabel1 = new System.Windows.Forms.Label();
            this.ScoreLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jug1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jug2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bola)).BeginInit();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // jug1
            // 
            this.jug1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("jug1.BackgroundImage")));
            this.jug1.Location = new System.Drawing.Point(12, 180);
            this.jug1.Name = "jug1";
            this.jug1.Size = new System.Drawing.Size(30, 120);
            this.jug1.TabIndex = 0;
            this.jug1.TabStop = false;
            // 
            // jug2
            // 
            this.jug2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("jug2.BackgroundImage")));
            this.jug2.Location = new System.Drawing.Point(742, 180);
            this.jug2.Name = "jug2";
            this.jug2.Size = new System.Drawing.Size(30, 120);
            this.jug2.TabIndex = 1;
            this.jug2.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvents);
            // 
            // bola
            // 
            this.bola.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bola.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bola.BackgroundImage")));
            this.bola.Location = new System.Drawing.Point(379, 180);
            this.bola.Name = "bola";
            this.bola.Size = new System.Drawing.Size(30, 30);
            this.bola.TabIndex = 2;
            this.bola.TabStop = false;
            this.bola.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(784, 24);
            this.menuBar.TabIndex = 3;
            this.menuBar.Text = "menuStrip1";
            this.menuBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newF2ToolStripMenuItem,
            this.exitF4ToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.gameToolStripMenuItem_Click);
            // 
            // newF2ToolStripMenuItem
            // 
            this.newF2ToolStripMenuItem.Name = "newF2ToolStripMenuItem";
            this.newF2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newF2ToolStripMenuItem.Text = "New (F2)";
            this.newF2ToolStripMenuItem.Click += new System.EventHandler(this.newF2ToolStripMenuItem_Click);
            // 
            // exitF4ToolStripMenuItem
            // 
            this.exitF4ToolStripMenuItem.Name = "exitF4ToolStripMenuItem";
            this.exitF4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitF4ToolStripMenuItem.Text = "Exit... (F4)";
            this.exitF4ToolStripMenuItem.Click += new System.EventHandler(this.exitF4ToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficultyF3ToolStripMenuItem,
            this.modeF8ToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // difficultyF3ToolStripMenuItem
            // 
            this.difficultyF3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePlayerUsernameToolStripMenuItem,
            this.speedToolStripMenuItem,
            this.changeBackgroundColorToolStripMenuItem});
            this.difficultyF3ToolStripMenuItem.Name = "difficultyF3ToolStripMenuItem";
            this.difficultyF3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.difficultyF3ToolStripMenuItem.Text = "Preferences";
            this.difficultyF3ToolStripMenuItem.Click += new System.EventHandler(this.difficultyF3ToolStripMenuItem_Click);
            // 
            // changePlayerUsernameToolStripMenuItem
            // 
            this.changePlayerUsernameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2});
            this.changePlayerUsernameToolStripMenuItem.Name = "changePlayerUsernameToolStripMenuItem";
            this.changePlayerUsernameToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.changePlayerUsernameToolStripMenuItem.Text = "Change Player Usernames";
            this.changePlayerUsernameToolStripMenuItem.Click += new System.EventHandler(this.changePlayerUsernameToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slowToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.fastToolStripMenuItem});
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.speedToolStripMenuItem.Text = "Speed";
            // 
            // slowToolStripMenuItem
            // 
            this.slowToolStripMenuItem.Name = "slowToolStripMenuItem";
            this.slowToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.slowToolStripMenuItem.Text = "Slow";
            this.slowToolStripMenuItem.Click += new System.EventHandler(this.slowToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // fastToolStripMenuItem
            // 
            this.fastToolStripMenuItem.Name = "fastToolStripMenuItem";
            this.fastToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.fastToolStripMenuItem.Text = "Fast";
            this.fastToolStripMenuItem.Click += new System.EventHandler(this.fastToolStripMenuItem_Click);
            // 
            // changeBackgroundColorToolStripMenuItem
            // 
            this.changeBackgroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteToolStripMenuItem,
            this.blackToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.aliceBlueToolStripMenuItem,
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.orangeToolStripMenuItem,
            this.purpleToolStripMenuItem,
            this.transparentToolStripMenuItem,
            this.deepSkyBlueToolStripMenuItem,
            this.antiqueWhiteToolStripMenuItem});
            this.changeBackgroundColorToolStripMenuItem.Name = "changeBackgroundColorToolStripMenuItem";
            this.changeBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.changeBackgroundColorToolStripMenuItem.Text = "Change Background Color";
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.whiteToolStripMenuItem.Text = "White";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // aliceBlueToolStripMenuItem
            // 
            this.aliceBlueToolStripMenuItem.Name = "aliceBlueToolStripMenuItem";
            this.aliceBlueToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aliceBlueToolStripMenuItem.Text = "Alice Blue";
            this.aliceBlueToolStripMenuItem.Click += new System.EventHandler(this.aliceBlueToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // orangeToolStripMenuItem
            // 
            this.orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            this.orangeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.orangeToolStripMenuItem.Text = "Orange";
            this.orangeToolStripMenuItem.Click += new System.EventHandler(this.orangeToolStripMenuItem_Click);
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.purpleToolStripMenuItem.Text = "Purple";
            this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
            // 
            // transparentToolStripMenuItem
            // 
            this.transparentToolStripMenuItem.Name = "transparentToolStripMenuItem";
            this.transparentToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.transparentToolStripMenuItem.Text = "Transparent";
            this.transparentToolStripMenuItem.Click += new System.EventHandler(this.transparentToolStripMenuItem_Click);
            // 
            // deepSkyBlueToolStripMenuItem
            // 
            this.deepSkyBlueToolStripMenuItem.Name = "deepSkyBlueToolStripMenuItem";
            this.deepSkyBlueToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.deepSkyBlueToolStripMenuItem.Text = "Deep Sky Blue";
            this.deepSkyBlueToolStripMenuItem.Click += new System.EventHandler(this.deepSkyBlueToolStripMenuItem_Click);
            // 
            // antiqueWhiteToolStripMenuItem
            // 
            this.antiqueWhiteToolStripMenuItem.Name = "antiqueWhiteToolStripMenuItem";
            this.antiqueWhiteToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.antiqueWhiteToolStripMenuItem.Text = "Antique White";
            this.antiqueWhiteToolStripMenuItem.Click += new System.EventHandler(this.antiqueWhiteToolStripMenuItem_Click);
            // 
            // modeF8ToolStripMenuItem
            // 
            this.modeF8ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerVsCPUToolStripMenuItem,
            this.playerModeToolStripMenuItem,
            this.infiniteModeToolStripMenuItem,
            this.playerInfiniteToolStripMenuItem,
            this.doublePongToolStripMenuItem,
            this.breakoutToolStripMenuItem});
            this.modeF8ToolStripMenuItem.Name = "modeF8ToolStripMenuItem";
            this.modeF8ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modeF8ToolStripMenuItem.Text = "Mode";
            this.modeF8ToolStripMenuItem.Click += new System.EventHandler(this.modeF8ToolStripMenuItem_Click);
            // 
            // playerVsCPUToolStripMenuItem
            // 
            this.playerVsCPUToolStripMenuItem.Name = "playerVsCPUToolStripMenuItem";
            this.playerVsCPUToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playerVsCPUToolStripMenuItem.Text = "Player vs. CPU";
            this.playerVsCPUToolStripMenuItem.Click += new System.EventHandler(this.playerVsCPUToolStripMenuItem_Click);
            // 
            // playerModeToolStripMenuItem
            // 
            this.playerModeToolStripMenuItem.Name = "playerModeToolStripMenuItem";
            this.playerModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playerModeToolStripMenuItem.Text = "2-Player Mode";
            this.playerModeToolStripMenuItem.Click += new System.EventHandler(this.playerModeToolStripMenuItem_Click);
            // 
            // infiniteModeToolStripMenuItem
            // 
            this.infiniteModeToolStripMenuItem.Name = "infiniteModeToolStripMenuItem";
            this.infiniteModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infiniteModeToolStripMenuItem.Text = "Infinite Mode";
            this.infiniteModeToolStripMenuItem.Click += new System.EventHandler(this.infiniteModeToolStripMenuItem_Click);
            // 
            // playerInfiniteToolStripMenuItem
            // 
            this.playerInfiniteToolStripMenuItem.Name = "playerInfiniteToolStripMenuItem";
            this.playerInfiniteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playerInfiniteToolStripMenuItem.Text = "2-Player Infinite";
            this.playerInfiniteToolStripMenuItem.Click += new System.EventHandler(this.playerInfiniteToolStripMenuItem_Click);
            // 
            // doublePongToolStripMenuItem
            // 
            this.doublePongToolStripMenuItem.Name = "doublePongToolStripMenuItem";
            this.doublePongToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doublePongToolStripMenuItem.Text = "Double Pong";
            // 
            // breakoutToolStripMenuItem
            // 
            this.breakoutToolStripMenuItem.Name = "breakoutToolStripMenuItem";
            this.breakoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.breakoutToolStripMenuItem.Text = "Breakout!";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutF7ToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutF7ToolStripMenuItem
            // 
            this.aboutF7ToolStripMenuItem.Name = "aboutF7ToolStripMenuItem";
            this.aboutF7ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutF7ToolStripMenuItem.Text = "About... (F7)";
            this.aboutF7ToolStripMenuItem.Click += new System.EventHandler(this.aboutF7ToolStripMenuItem_Click);
            // 
            // ScoreLabel1
            // 
            this.ScoreLabel1.AutoSize = true;
            this.ScoreLabel1.BackColor = System.Drawing.SystemColors.Info;
            this.ScoreLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScoreLabel1.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel1.Location = new System.Drawing.Point(12, 409);
            this.ScoreLabel1.Name = "ScoreLabel1";
            this.ScoreLabel1.Size = new System.Drawing.Size(84, 23);
            this.ScoreLabel1.TabIndex = 4;
            this.ScoreLabel1.Text = "label1";
            // 
            // ScoreLabel2
            // 
            this.ScoreLabel2.AutoSize = true;
            this.ScoreLabel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ScoreLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScoreLabel2.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel2.Location = new System.Drawing.Point(532, 409);
            this.ScoreLabel2.Name = "ScoreLabel2";
            this.ScoreLabel2.Size = new System.Drawing.Size(84, 23);
            this.ScoreLabel2.TabIndex = 5;
            this.ScoreLabel2.Text = "label1";
            this.ScoreLabel2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.ScoreLabel2);
            this.Controls.Add(this.ScoreLabel1);
            this.Controls.Add(this.bola);
            this.Controls.Add(this.jug2);
            this.Controls.Add(this.jug1);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.MaximizeBox = false;
            this.Name = "PongForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PongForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyIsPressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.jug1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jug2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bola)).EndInit();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox jug1;
        private System.Windows.Forms.PictureBox jug2;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox bola;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newF2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficultyF3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutF7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeF8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePlayerUsernameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsCPUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infiniteModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerInfiniteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doublePongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakoutToolStripMenuItem;
        private System.Windows.Forms.Label ScoreLabel1;
        private System.Windows.Forms.Label ScoreLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem changeBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aliceBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transparentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deepSkyBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antiqueWhiteToolStripMenuItem;
    }
}

