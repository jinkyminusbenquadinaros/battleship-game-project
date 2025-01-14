﻿namespace battleship_game
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
            components = new System.ComponentModel.Container();
            txtPlayer = new Label();
            txtEnemy = new Label();
            txtRounds = new Label();
            enemyMove = new Label();
            txtHelp = new Label();
            EnemyLocationListBox = new ComboBox();
            btnAttack = new Button();
            w1 = new Button();
            w3 = new Button();
            w2 = new Button();
            w4 = new Button();
            x1 = new Button();
            x3 = new Button();
            x4 = new Button();
            x2 = new Button();
            y1 = new Button();
            y3 = new Button();
            y4 = new Button();
            y2 = new Button();
            z1 = new Button();
            z3 = new Button();
            z4 = new Button();
            z2 = new Button();
            a1 = new Button();
            a3 = new Button();
            a4 = new Button();
            a2 = new Button();
            b1 = new Button();
            b3 = new Button();
            b4 = new Button();
            b2 = new Button();
            c1 = new Button();
            c3 = new Button();
            c4 = new Button();
            c2 = new Button();
            d1 = new Button();
            d3 = new Button();
            d4 = new Button();
            d2 = new Button();
            EnemyPlayTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // txtPlayer
            // 
            txtPlayer.AutoSize = true;
            txtPlayer.BackColor = Color.Transparent;
            txtPlayer.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPlayer.ForeColor = Color.White;
            txtPlayer.Location = new Point(278, 103);
            txtPlayer.Name = "txtPlayer";
            txtPlayer.Size = new Size(37, 30);
            txtPlayer.TabIndex = 0;
            txtPlayer.Text = "00";
            // 
            // txtEnemy
            // 
            txtEnemy.AutoSize = true;
            txtEnemy.BackColor = Color.Transparent;
            txtEnemy.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEnemy.ForeColor = Color.White;
            txtEnemy.Location = new Point(783, 103);
            txtEnemy.Name = "txtEnemy";
            txtEnemy.Size = new Size(37, 30);
            txtEnemy.TabIndex = 0;
            txtEnemy.Text = "00";
            // 
            // txtRounds
            // 
            txtRounds.AutoSize = true;
            txtRounds.BackColor = Color.Transparent;
            txtRounds.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRounds.ForeColor = Color.White;
            txtRounds.Location = new Point(441, 160);
            txtRounds.Name = "txtRounds";
            txtRounds.Size = new Size(120, 30);
            txtRounds.TabIndex = 0;
            txtRounds.Text = "Round : 01";
            // 
            // enemyMove
            // 
            enemyMove.AutoSize = true;
            enemyMove.BackColor = Color.Transparent;
            enemyMove.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enemyMove.ForeColor = Color.Black;
            enemyMove.Location = new Point(856, 39);
            enemyMove.Name = "enemyMove";
            enemyMove.Size = new Size(45, 32);
            enemyMove.TabIndex = 0;
            enemyMove.Text = "A1";
            // 
            // txtHelp
            // 
            txtHelp.AutoSize = true;
            txtHelp.BackColor = Color.Transparent;
            txtHelp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHelp.ForeColor = Color.White;
            txtHelp.Location = new Point(12, 536);
            txtHelp.Name = "txtHelp";
            txtHelp.Size = new Size(352, 30);
            txtHelp.TabIndex = 0;
            txtHelp.Text = "click on 3 different boxes to begin";
            // 
            // EnemyLocationListBox
            // 
            EnemyLocationListBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EnemyLocationListBox.DropDownWidth = 95;
            EnemyLocationListBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnemyLocationListBox.FormattingEnabled = true;
            EnemyLocationListBox.Location = new Point(149, 39);
            EnemyLocationListBox.Name = "EnemyLocationListBox";
            EnemyLocationListBox.Size = new Size(101, 38);
            EnemyLocationListBox.TabIndex = 1;
            // 
            // btnAttack
            // 
            btnAttack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAttack.Location = new Point(289, 33);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(75, 38);
            btnAttack.TabIndex = 2;
            btnAttack.Text = "attack";
            btnAttack.UseVisualStyleBackColor = true;
            btnAttack.Click += AttackButtonEvent;
            // 
            // w1
            // 
            w1.BackColor = Color.White;
            w1.BackgroundImageLayout = ImageLayout.Stretch;
            w1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            w1.Location = new Point(78, 203);
            w1.Name = "w1";
            w1.Size = new Size(80, 75);
            w1.TabIndex = 2;
            w1.Text = "W1";
            w1.UseVisualStyleBackColor = false;
            w1.Click += PlayerPositionButtonEvent;
            // 
            // w3
            // 
            w3.BackColor = Color.White;
            w3.BackgroundImageLayout = ImageLayout.Stretch;
            w3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            w3.Location = new Point(254, 203);
            w3.Name = "w3";
            w3.Size = new Size(80, 75);
            w3.TabIndex = 2;
            w3.Text = "W3";
            w3.UseVisualStyleBackColor = false;
            w3.Click += PlayerPositionButtonEvent;
            // 
            // w2
            // 
            w2.BackColor = Color.White;
            w2.BackgroundImageLayout = ImageLayout.Stretch;
            w2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            w2.Location = new Point(164, 204);
            w2.Name = "w2";
            w2.Size = new Size(80, 75);
            w2.TabIndex = 2;
            w2.Text = "W2";
            w2.UseVisualStyleBackColor = false;
            w2.Click += PlayerPositionButtonEvent;
            // 
            // w4
            // 
            w4.BackColor = Color.White;
            w4.BackgroundImageLayout = ImageLayout.Stretch;
            w4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            w4.Location = new Point(340, 205);
            w4.Name = "w4";
            w4.Size = new Size(80, 75);
            w4.TabIndex = 2;
            w4.Text = "W4";
            w4.UseVisualStyleBackColor = false;
            w4.Click += PlayerPositionButtonEvent;
            // 
            // x1
            // 
            x1.BackColor = Color.White;
            x1.BackgroundImageLayout = ImageLayout.Stretch;
            x1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            x1.Location = new Point(78, 284);
            x1.Name = "x1";
            x1.Size = new Size(80, 75);
            x1.TabIndex = 2;
            x1.Text = "X1";
            x1.UseVisualStyleBackColor = false;
            x1.Click += PlayerPositionButtonEvent;
            // 
            // x3
            // 
            x3.BackColor = Color.White;
            x3.BackgroundImageLayout = ImageLayout.Stretch;
            x3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            x3.Location = new Point(254, 284);
            x3.Name = "x3";
            x3.Size = new Size(80, 75);
            x3.TabIndex = 2;
            x3.Text = "X3";
            x3.UseVisualStyleBackColor = false;
            x3.Click += PlayerPositionButtonEvent;
            // 
            // x4
            // 
            x4.BackColor = Color.White;
            x4.BackgroundImageLayout = ImageLayout.Stretch;
            x4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            x4.Location = new Point(340, 285);
            x4.Name = "x4";
            x4.Size = new Size(80, 75);
            x4.TabIndex = 2;
            x4.Text = "X4";
            x4.UseVisualStyleBackColor = false;
            x4.Click += PlayerPositionButtonEvent;
            // 
            // x2
            // 
            x2.BackColor = Color.White;
            x2.BackgroundImageLayout = ImageLayout.Stretch;
            x2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            x2.Location = new Point(164, 284);
            x2.Name = "x2";
            x2.Size = new Size(80, 75);
            x2.TabIndex = 2;
            x2.Text = "X2";
            x2.UseVisualStyleBackColor = false;
            x2.Click += PlayerPositionButtonEvent;
            // 
            // y1
            // 
            y1.BackColor = Color.White;
            y1.BackgroundImageLayout = ImageLayout.Stretch;
            y1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            y1.Location = new Point(79, 361);
            y1.Name = "y1";
            y1.Size = new Size(80, 75);
            y1.TabIndex = 2;
            y1.Text = "Y1";
            y1.UseVisualStyleBackColor = false;
            y1.Click += PlayerPositionButtonEvent;
            // 
            // y3
            // 
            y3.BackColor = Color.White;
            y3.BackgroundImageLayout = ImageLayout.Stretch;
            y3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            y3.Location = new Point(254, 361);
            y3.Name = "y3";
            y3.Size = new Size(80, 75);
            y3.TabIndex = 2;
            y3.Text = "Y3";
            y3.UseVisualStyleBackColor = false;
            y3.Click += PlayerPositionButtonEvent;
            // 
            // y4
            // 
            y4.BackColor = Color.White;
            y4.BackgroundImageLayout = ImageLayout.Stretch;
            y4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            y4.Location = new Point(340, 363);
            y4.Name = "y4";
            y4.Size = new Size(80, 75);
            y4.TabIndex = 2;
            y4.Text = "Y4";
            y4.UseVisualStyleBackColor = false;
            y4.Click += PlayerPositionButtonEvent;
            // 
            // y2
            // 
            y2.BackColor = Color.White;
            y2.BackgroundImageLayout = ImageLayout.Stretch;
            y2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            y2.Location = new Point(164, 361);
            y2.Name = "y2";
            y2.Size = new Size(80, 75);
            y2.TabIndex = 2;
            y2.Text = "Y2";
            y2.UseVisualStyleBackColor = false;
            y2.Click += PlayerPositionButtonEvent;
            // 
            // z1
            // 
            z1.BackColor = Color.White;
            z1.BackgroundImageLayout = ImageLayout.Stretch;
            z1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            z1.Location = new Point(78, 437);
            z1.Name = "z1";
            z1.Size = new Size(80, 75);
            z1.TabIndex = 2;
            z1.Text = "Z1";
            z1.UseVisualStyleBackColor = false;
            z1.Click += PlayerPositionButtonEvent;
            // 
            // z3
            // 
            z3.BackColor = Color.White;
            z3.BackgroundImageLayout = ImageLayout.Stretch;
            z3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            z3.Location = new Point(254, 438);
            z3.Name = "z3";
            z3.Size = new Size(80, 75);
            z3.TabIndex = 2;
            z3.Text = "Z3";
            z3.UseVisualStyleBackColor = false;
            z3.Click += PlayerPositionButtonEvent;
            // 
            // z4
            // 
            z4.BackColor = Color.White;
            z4.BackgroundImageLayout = ImageLayout.Stretch;
            z4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            z4.Location = new Point(340, 439);
            z4.Name = "z4";
            z4.Size = new Size(80, 75);
            z4.TabIndex = 2;
            z4.Text = "Z4";
            z4.UseVisualStyleBackColor = false;
            z4.Click += PlayerPositionButtonEvent;
            // 
            // z2
            // 
            z2.BackColor = Color.White;
            z2.BackgroundImageLayout = ImageLayout.Stretch;
            z2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            z2.Location = new Point(164, 438);
            z2.Name = "z2";
            z2.Size = new Size(80, 75);
            z2.TabIndex = 2;
            z2.Text = "Z2";
            z2.UseVisualStyleBackColor = false;
            z2.Click += PlayerPositionButtonEvent;
            // 
            // a1
            // 
            a1.BackColor = Color.White;
            a1.BackgroundImageLayout = ImageLayout.Stretch;
            a1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            a1.Location = new Point(581, 203);
            a1.Name = "a1";
            a1.Size = new Size(80, 75);
            a1.TabIndex = 2;
            a1.Text = "A1";
            a1.UseVisualStyleBackColor = false;
            // 
            // a3
            // 
            a3.BackColor = Color.White;
            a3.BackgroundImageLayout = ImageLayout.Stretch;
            a3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            a3.Location = new Point(753, 205);
            a3.Name = "a3";
            a3.Size = new Size(80, 75);
            a3.TabIndex = 2;
            a3.Text = "A3";
            a3.UseVisualStyleBackColor = false;
            // 
            // a4
            // 
            a4.BackColor = Color.White;
            a4.BackgroundImageLayout = ImageLayout.Stretch;
            a4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            a4.Location = new Point(837, 205);
            a4.Name = "a4";
            a4.Size = new Size(80, 75);
            a4.TabIndex = 2;
            a4.Text = "A4";
            a4.UseVisualStyleBackColor = false;
            // 
            // a2
            // 
            a2.BackColor = Color.White;
            a2.BackgroundImageLayout = ImageLayout.Stretch;
            a2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            a2.Location = new Point(667, 204);
            a2.Name = "a2";
            a2.Size = new Size(80, 75);
            a2.TabIndex = 2;
            a2.Text = "A2";
            a2.UseVisualStyleBackColor = false;
            // 
            // b1
            // 
            b1.BackColor = Color.White;
            b1.BackgroundImageLayout = ImageLayout.Stretch;
            b1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b1.Location = new Point(581, 282);
            b1.Name = "b1";
            b1.Size = new Size(80, 75);
            b1.TabIndex = 2;
            b1.Text = "B1";
            b1.UseVisualStyleBackColor = false;
            // 
            // b3
            // 
            b3.BackColor = Color.White;
            b3.BackgroundImageLayout = ImageLayout.Stretch;
            b3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b3.Location = new Point(753, 283);
            b3.Name = "b3";
            b3.Size = new Size(80, 75);
            b3.TabIndex = 2;
            b3.Text = "B3";
            b3.UseVisualStyleBackColor = false;
            // 
            // b4
            // 
            b4.BackColor = Color.White;
            b4.BackgroundImageLayout = ImageLayout.Stretch;
            b4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b4.Location = new Point(837, 283);
            b4.Name = "b4";
            b4.Size = new Size(80, 75);
            b4.TabIndex = 2;
            b4.Text = "B4";
            b4.UseVisualStyleBackColor = false;
            // 
            // b2
            // 
            b2.BackColor = Color.White;
            b2.BackgroundImageLayout = ImageLayout.Stretch;
            b2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b2.Location = new Point(667, 283);
            b2.Name = "b2";
            b2.Size = new Size(80, 75);
            b2.TabIndex = 2;
            b2.Text = "B2";
            b2.UseVisualStyleBackColor = false;
            // 
            // c1
            // 
            c1.BackColor = Color.White;
            c1.BackgroundImageLayout = ImageLayout.Stretch;
            c1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c1.Location = new Point(581, 362);
            c1.Name = "c1";
            c1.Size = new Size(80, 75);
            c1.TabIndex = 2;
            c1.Text = "C1";
            c1.UseVisualStyleBackColor = false;
            // 
            // c3
            // 
            c3.BackColor = Color.White;
            c3.BackgroundImageLayout = ImageLayout.Stretch;
            c3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c3.Location = new Point(753, 361);
            c3.Name = "c3";
            c3.Size = new Size(80, 75);
            c3.TabIndex = 2;
            c3.Text = "C3";
            c3.UseVisualStyleBackColor = false;
            // 
            // c4
            // 
            c4.BackColor = Color.White;
            c4.BackgroundImageLayout = ImageLayout.Stretch;
            c4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c4.Location = new Point(837, 362);
            c4.Name = "c4";
            c4.Size = new Size(80, 75);
            c4.TabIndex = 2;
            c4.Text = "C4";
            c4.UseVisualStyleBackColor = false;
            // 
            // c2
            // 
            c2.BackColor = Color.White;
            c2.BackgroundImageLayout = ImageLayout.Stretch;
            c2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c2.Location = new Point(667, 363);
            c2.Name = "c2";
            c2.Size = new Size(80, 75);
            c2.TabIndex = 2;
            c2.Text = "C2";
            c2.UseVisualStyleBackColor = false;
            // 
            // d1
            // 
            d1.BackColor = Color.White;
            d1.BackgroundImageLayout = ImageLayout.Stretch;
            d1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            d1.Location = new Point(581, 437);
            d1.Name = "d1";
            d1.Size = new Size(80, 75);
            d1.TabIndex = 2;
            d1.Text = "D1";
            d1.UseVisualStyleBackColor = false;
            // 
            // d3
            // 
            d3.BackColor = Color.White;
            d3.BackgroundImageLayout = ImageLayout.Stretch;
            d3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            d3.Location = new Point(753, 438);
            d3.Name = "d3";
            d3.Size = new Size(80, 75);
            d3.TabIndex = 2;
            d3.Text = "D3";
            d3.UseVisualStyleBackColor = false;
            // 
            // d4
            // 
            d4.BackColor = Color.White;
            d4.BackgroundImageLayout = ImageLayout.Stretch;
            d4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            d4.Location = new Point(837, 439);
            d4.Name = "d4";
            d4.Size = new Size(80, 75);
            d4.TabIndex = 2;
            d4.Text = "D4";
            d4.UseVisualStyleBackColor = false;
            // 
            // d2
            // 
            d2.BackColor = Color.White;
            d2.BackgroundImageLayout = ImageLayout.Stretch;
            d2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            d2.Location = new Point(666, 438);
            d2.Name = "d2";
            d2.Size = new Size(80, 75);
            d2.TabIndex = 2;
            d2.Text = "D2";
            d2.UseVisualStyleBackColor = false;
            // 
            // EnemyPlayTimer
            // 
            EnemyPlayTimer.Interval = 1000;
            EnemyPlayTimer.Tick += EnemyPlayTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_12_02_123022;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1064, 586);
            Controls.Add(d2);
            Controls.Add(c2);
            Controls.Add(b2);
            Controls.Add(a2);
            Controls.Add(z2);
            Controls.Add(y2);
            Controls.Add(x2);
            Controls.Add(w2);
            Controls.Add(d4);
            Controls.Add(d3);
            Controls.Add(c4);
            Controls.Add(c3);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(a4);
            Controls.Add(a3);
            Controls.Add(z4);
            Controls.Add(d1);
            Controls.Add(z3);
            Controls.Add(c1);
            Controls.Add(y4);
            Controls.Add(b1);
            Controls.Add(y3);
            Controls.Add(a1);
            Controls.Add(x4);
            Controls.Add(z1);
            Controls.Add(x3);
            Controls.Add(y1);
            Controls.Add(w4);
            Controls.Add(x1);
            Controls.Add(w3);
            Controls.Add(w1);
            Controls.Add(btnAttack);
            Controls.Add(EnemyLocationListBox);
            Controls.Add(txtHelp);
            Controls.Add(txtRounds);
            Controls.Add(enemyMove);
            Controls.Add(txtEnemy);
            Controls.Add(txtPlayer);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "\u007fBattle Ship Game Windows Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtPlayer;
        private Label txtEnemy;
        private Label txtRounds;
        private Label enemyMove;
        private Label txtHelp;
        private ComboBox EnemyLocationListBox;
        private Button btnAttack;
        private Button w1;
        private Button w3;
        private Button w2;
        private Button w4;
        private Button x1;
        private Button x3;
        private Button x4;
        private Button x2;
        private Button y1;
        private Button y3;
        private Button y4;
        private Button y2;
        private Button z1;
        private Button z3;
        private Button z4;
        private Button z2;
        private Button a1;
        private Button a3;
        private Button a4;
        private Button a2;
        private Button b1;
        private Button b3;
        private Button b4;
        private Button b2;
        private Button c1;
        private Button c3;
        private Button c4;
        private Button c2;
        private Button d1;
        private Button d3;
        private Button d4;
        private Button d2;
        private System.Windows.Forms.Timer EnemyPlayTimer;
    }
}
