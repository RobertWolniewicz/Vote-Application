﻿namespace ONWELO_VOTE_APP
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.voterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserLable = new System.Windows.Forms.Label();
            this.InfoLabel3 = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.InfoLabel2 = new System.Windows.Forms.Label();
            this.ChoosedCandidatLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.AmountCandidateslabel = new System.Windows.Forms.Label();
            this.AddCandidateButton = new System.Windows.Forms.Button();
            this.VoteButton = new System.Windows.Forms.Button();
            this.VotersSearchTextBox = new System.Windows.Forms.TextBox();
            this.CandidatesSearchTextBox = new System.Windows.Forms.TextBox();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.DeleteAccountButton = new System.Windows.Forms.Button();
            this.EditAccountButton = new System.Windows.Forms.Button();
            this.VotersGroupBox = new System.Windows.Forms.GroupBox();
            this.CandidatesGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.VotersGroupBox.SuspendLayout();
            this.CandidatesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // voterBindingSource
            // 
            this.voterBindingSource.DataSource = typeof(ONWELO_VOTE_APP.Entity.Voter);
            // 
            // candidateBindingSource
            // 
            this.candidateBindingSource.DataSource = typeof(ONWELO_VOTE_APP.Entity.Candidate);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 90);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(428, 296);
            this.dataGridView.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(428, 296);
            this.dataGridView1.TabIndex = 2;
            // 
            // UserLable
            // 
            this.UserLable.AutoSize = true;
            this.UserLable.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserLable.Location = new System.Drawing.Point(12, 9);
            this.UserLable.Name = "UserLable";
            this.UserLable.Size = new System.Drawing.Size(75, 28);
            this.UserLable.TabIndex = 5;
            this.UserLable.Text = "Hi User";
            // 
            // InfoLabel3
            // 
            this.InfoLabel3.AutoSize = true;
            this.InfoLabel3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel3.Location = new System.Drawing.Point(485, 485);
            this.InfoLabel3.Name = "InfoLabel3";
            this.InfoLabel3.Size = new System.Drawing.Size(79, 37);
            this.InfoLabel3.TabIndex = 6;
            this.InfoLabel3.Text = "Vote!";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel.Location = new System.Drawing.Point(485, 457);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(251, 28);
            this.InfoLabel.TabIndex = 7;
            this.InfoLabel.Text = "Choose your candidate and";
            // 
            // InfoLabel2
            // 
            this.InfoLabel2.AutoSize = true;
            this.InfoLabel2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel2.Location = new System.Drawing.Point(485, 522);
            this.InfoLabel2.Name = "InfoLabel2";
            this.InfoLabel2.Size = new System.Drawing.Size(166, 28);
            this.InfoLabel2.TabIndex = 8;
            this.InfoLabel2.Text = "You are voting to:";
            // 
            // ChoosedCandidatLabel
            // 
            this.ChoosedCandidatLabel.AutoSize = true;
            this.ChoosedCandidatLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChoosedCandidatLabel.Location = new System.Drawing.Point(657, 522);
            this.ChoosedCandidatLabel.Name = "ChoosedCandidatLabel";
            this.ChoosedCandidatLabel.Size = new System.Drawing.Size(203, 28);
            this.ChoosedCandidatLabel.TabIndex = 9;
            this.ChoosedCandidatLabel.Text = "SomeCandidateName";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.ResultLabel.Location = new System.Drawing.Point(626, 564);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(154, 37);
            this.ResultLabel.TabIndex = 10;
            this.ResultLabel.Text = "Some value";
            // 
            // AmountCandidateslabel
            // 
            this.AmountCandidateslabel.AutoSize = true;
            this.AmountCandidateslabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountCandidateslabel.Location = new System.Drawing.Point(255, 23);
            this.AmountCandidateslabel.Name = "AmountCandidateslabel";
            this.AmountCandidateslabel.Size = new System.Drawing.Size(183, 21);
            this.AmountCandidateslabel.TabIndex = 11;
            this.AmountCandidateslabel.Text = "You can add x candidates";
            // 
            // AddCandidateButton
            // 
            this.AddCandidateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddCandidateButton.Location = new System.Drawing.Point(347, 47);
            this.AddCandidateButton.Name = "AddCandidateButton";
            this.AddCandidateButton.Size = new System.Drawing.Size(87, 37);
            this.AddCandidateButton.TabIndex = 13;
            this.AddCandidateButton.Text = "Add";
            this.AddCandidateButton.UseVisualStyleBackColor = true;
            // 
            // VoteButton
            // 
            this.VoteButton.Location = new System.Drawing.Point(491, 564);
            this.VoteButton.Name = "VoteButton";
            this.VoteButton.Size = new System.Drawing.Size(99, 34);
            this.VoteButton.TabIndex = 14;
            this.VoteButton.Text = "Vote";
            this.VoteButton.UseVisualStyleBackColor = true;
            // 
            // VotersSearchTextBox
            // 
            this.VotersSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VotersSearchTextBox.Location = new System.Drawing.Point(6, 33);
            this.VotersSearchTextBox.Name = "VotersSearchTextBox";
            this.VotersSearchTextBox.Size = new System.Drawing.Size(205, 29);
            this.VotersSearchTextBox.TabIndex = 15;
            this.VotersSearchTextBox.Text = "Search";
            // 
            // CandidatesSearchTextBox
            // 
            this.CandidatesSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CandidatesSearchTextBox.Location = new System.Drawing.Point(6, 33);
            this.CandidatesSearchTextBox.Name = "CandidatesSearchTextBox";
            this.CandidatesSearchTextBox.Size = new System.Drawing.Size(205, 29);
            this.CandidatesSearchTextBox.TabIndex = 16;
            this.CandidatesSearchTextBox.Text = "Search";
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(139, 7);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(75, 41);
            this.LogOutButton.TabIndex = 17;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            // 
            // DeleteAccountButton
            // 
            this.DeleteAccountButton.Location = new System.Drawing.Point(220, 7);
            this.DeleteAccountButton.Name = "DeleteAccountButton";
            this.DeleteAccountButton.Size = new System.Drawing.Size(75, 41);
            this.DeleteAccountButton.TabIndex = 18;
            this.DeleteAccountButton.Text = "Delete account";
            this.DeleteAccountButton.UseVisualStyleBackColor = true;
            // 
            // EditAccountButton
            // 
            this.EditAccountButton.Location = new System.Drawing.Point(301, 7);
            this.EditAccountButton.Name = "EditAccountButton";
            this.EditAccountButton.Size = new System.Drawing.Size(75, 41);
            this.EditAccountButton.TabIndex = 19;
            this.EditAccountButton.Text = "Edit account";
            this.EditAccountButton.UseVisualStyleBackColor = true;
            // 
            // VotersGroupBox
            // 
            this.VotersGroupBox.Controls.Add(this.VotersSearchTextBox);
            this.VotersGroupBox.Controls.Add(this.dataGridView);
            this.VotersGroupBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VotersGroupBox.Location = new System.Drawing.Point(12, 54);
            this.VotersGroupBox.Name = "VotersGroupBox";
            this.VotersGroupBox.Size = new System.Drawing.Size(450, 400);
            this.VotersGroupBox.TabIndex = 20;
            this.VotersGroupBox.TabStop = false;
            this.VotersGroupBox.Text = "Voters";
            // 
            // CandidatesGroupBox
            // 
            this.CandidatesGroupBox.Controls.Add(this.dataGridView1);
            this.CandidatesGroupBox.Controls.Add(this.CandidatesSearchTextBox);
            this.CandidatesGroupBox.Controls.Add(this.AddCandidateButton);
            this.CandidatesGroupBox.Controls.Add(this.AmountCandidateslabel);
            this.CandidatesGroupBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CandidatesGroupBox.Location = new System.Drawing.Point(485, 54);
            this.CandidatesGroupBox.Name = "CandidatesGroupBox";
            this.CandidatesGroupBox.Size = new System.Drawing.Size(444, 400);
            this.CandidatesGroupBox.TabIndex = 21;
            this.CandidatesGroupBox.TabStop = false;
            this.CandidatesGroupBox.Text = "Candidates";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ONWELO_VOTE_APP.Properties.Resources.Vote;
            this.pictureBox1.Location = new System.Drawing.Point(12, 457);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 641);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CandidatesGroupBox);
            this.Controls.Add(this.VotersGroupBox);
            this.Controls.Add(this.EditAccountButton);
            this.Controls.Add(this.DeleteAccountButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.VoteButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ChoosedCandidatLabel);
            this.Controls.Add(this.InfoLabel2);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.InfoLabel3);
            this.Controls.Add(this.UserLable);
            this.Name = "MainWindow";
            this.Text = "Voting app";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.voterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.VotersGroupBox.ResumeLayout(false);
            this.VotersGroupBox.PerformLayout();
            this.CandidatesGroupBox.ResumeLayout(false);
            this.CandidatesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource voterBindingSource;
        private BindingSource candidateBindingSource;
        private DataGridView dataGridView;
        private DataGridView dataGridView1;
        private Label UserLable;
        private Label InfoLabel3;
        private Label InfoLabel;
        private Label InfoLabel2;
        private Label ChoosedCandidatLabel;
        private Label ResultLabel;
        private Label AmountCandidateslabel;
        private Button AddCandidateButton;
        private Button VoteButton;
        private TextBox VotersSearchTextBox;
        private TextBox CandidatesSearchTextBox;
        private Button LogOutButton;
        private Button DeleteAccountButton;
        private Button EditAccountButton;
        private GroupBox VotersGroupBox;
        private GroupBox CandidatesGroupBox;
        private PictureBox pictureBox1;
    }
}