﻿using Retro_Achievement_Tracker.Models;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Retro_Achievement_Tracker
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.apiKeyLabel = new System.Windows.Forms.Label();
            this.apiKeyTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.userProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.autoStartCheckbox = new System.Windows.Forms.CheckBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.awardsLabel = new System.Windows.Forms.Label();
            this.siteRankLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.timerStatusLabel = new System.Windows.Forms.Label();
            this.statsGroupBox = new System.Windows.Forms.GroupBox();
            this.autoLaunchStatsWindowCheckbox = new System.Windows.Forms.CheckBox();
            this.customizeStatsButton = new System.Windows.Forms.Button();
            this.openStatsWindowButton = new System.Windows.Forms.Button();
            this.focusGroupBox = new System.Windows.Forms.GroupBox();
            this.focusAchievementDescriptionLabel = new System.Windows.Forms.Label();
            this.setFocusButton = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.focusAchievementButtonRight = new System.Windows.Forms.Button();
            this.hideFocusButton = new System.Windows.Forms.Button();
            this.customizeFocusButton = new System.Windows.Forms.Button();
            this.focusAchievementButtonLeft = new System.Windows.Forms.Button();
            this.autoLaunchFocusWindowCheckBox = new System.Windows.Forms.CheckBox();
            this.focusAchievementPictureBox = new System.Windows.Forms.PictureBox();
            this.showFocusWindowButton = new System.Windows.Forms.Button();
            this.focusAchievementTitleLabel = new System.Windows.Forms.Label();
            this.notificationsGroupBox = new System.Windows.Forms.GroupBox();
            this.customizeAlertsButton = new System.Windows.Forms.Button();
            this.autoLaunchNotificationsWindowCheckbox = new System.Windows.Forms.CheckBox();
            this.openAlertsWindowButton = new System.Windows.Forms.Button();
            this.userInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.truePointsLabel = new System.Windows.Forms.Label();
            this.ratioLabel = new System.Windows.Forms.Label();
            this.hideButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.raConnectionStatusPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customizeGameButton = new System.Windows.Forms.Button();
            this.autoLaunchGameInfoWindowCheckbox = new System.Windows.Forms.CheckBox();
            this.openGameInfoWindowButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.customizeLastFiveButton = new System.Windows.Forms.Button();
            this.autoLaunchLastFiveWindowCheckbox = new System.Windows.Forms.CheckBox();
            this.openLastFiveWindowButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.focusStreamLabelsCheckBox = new System.Windows.Forms.CheckBox();
            this.alertsStreamLabelsCheckBox = new System.Windows.Forms.CheckBox();
            this.lastFiveStreamLabelsCheckBox = new System.Windows.Forms.CheckBox();
            this.gameInfoStreamLabelsCheckBox = new System.Windows.Forms.CheckBox();
            this.statsStreamLabelsCheckBox = new System.Windows.Forms.CheckBox();
            this.statsGameRatioOverrideTextBox = new System.Windows.Forms.TextBox();
            this.statsTruePointsOverrideTextBox = new System.Windows.Forms.TextBox();
            this.statsPointsOverrideTextBox = new System.Windows.Forms.TextBox();
            this.statsRatioOverrideTextBox = new System.Windows.Forms.TextBox();
            this.statsAwardsOverrideTextBox = new System.Windows.Forms.TextBox();
            this.statsRankOverrideTextBox = new System.Windows.Forms.TextBox();
            this.statsOverrideGroupBox = new System.Windows.Forms.GroupBox();
            this.statsGameAchievementsCheckBox = new System.Windows.Forms.CheckBox();
            this.statsGameTruePointsCheckBox = new System.Windows.Forms.CheckBox();
            this.statsGamePointsCheckBox = new System.Windows.Forms.CheckBox();
            this.statsGameRatioCheckBox = new System.Windows.Forms.CheckBox();
            this.statsRatioCheckBox = new System.Windows.Forms.CheckBox();
            this.statsTruePointsCheckBox = new System.Windows.Forms.CheckBox();
            this.statsPointsCheckBox = new System.Windows.Forms.CheckBox();
            this.statsAwardsCheckBox = new System.Windows.Forms.CheckBox();
            this.statsRankCheckBox = new System.Windows.Forms.CheckBox();
            this.statsDefaultButton = new System.Windows.Forms.Button();
            this.statsGameTruePointsOverrideTextBox = new System.Windows.Forms.TextBox();
            this.statsGamePointsOverrideTextBox = new System.Windows.Forms.TextBox();
            this.statsGameAchievementsOverrideTextBox = new System.Windows.Forms.TextBox();
            this.fontFamilyComboBox = new System.Windows.Forms.ComboBox();
            this.setBackgroundColorButton = new System.Windows.Forms.Button();
            this.backgroundColorPictureBox = new System.Windows.Forms.PictureBox();
            this.backgroundColorLabel = new System.Windows.Forms.Label();
            this.fontOutlineNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fontOutlineCheckBox = new System.Windows.Forms.CheckBox();
            this.fontOutlineColorButton = new System.Windows.Forms.Button();
            this.fontOutlineColorPictureBox = new System.Windows.Forms.PictureBox();
            this.setFontColorButton = new System.Windows.Forms.Button();
            this.fontColorPictureBox = new System.Windows.Forms.PictureBox();
            this.fontColorLabel = new System.Windows.Forms.Label();
            this.fontSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.inAchievementNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.inLabel1 = new System.Windows.Forms.Label();
            this.outAchievementNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.selectCustomAchievementButton = new System.Windows.Forms.Button();
            this.outLabel1 = new System.Windows.Forms.Label();
            this.scaleLabel1 = new System.Windows.Forms.Label();
            this.scaleAchievementNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yPositionLabel1 = new System.Windows.Forms.Label();
            this.xPositionLabel1 = new System.Windows.Forms.Label();
            this.customAchievementYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.customAchievementXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.useCustomAchievementCheckbox = new System.Windows.Forms.CheckBox();
            this.showAchievementButton = new System.Windows.Forms.Button();
            this.customAchievementSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.acheivementEditOutlineCheckbox = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.inMasteryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.inLabel2 = new System.Windows.Forms.Label();
            this.outMasteryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.selectCustomMasteryNotificationButton = new System.Windows.Forms.Button();
            this.outLabel2 = new System.Windows.Forms.Label();
            this.scaleLabel2 = new System.Windows.Forms.Label();
            this.scaleMasteryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yPositionLabel2 = new System.Windows.Forms.Label();
            this.xPositionLabel2 = new System.Windows.Forms.Label();
            this.customMasteryYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.customMasteryXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.useCustomMasteryCheckbox = new System.Windows.Forms.CheckBox();
            this.showGameMasteryButton = new System.Windows.Forms.Button();
            this.customMasterySettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.masteryEditOultineCheckbox = new System.Windows.Forms.CheckBox();
            this.gameInfoOverrideSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.gameInfoTitleCheckBox = new System.Windows.Forms.CheckBox();
            this.gameInfoTitleOverrideTextBox = new System.Windows.Forms.TextBox();
            this.gameInfoBoxArtCheckbox = new System.Windows.Forms.CheckBox();
            this.gameInfoReleaseDateCheckBox = new System.Windows.Forms.CheckBox();
            this.gameInfoGenreCheckBox = new System.Windows.Forms.CheckBox();
            this.gameInfoPublisherCheckBox = new System.Windows.Forms.CheckBox();
            this.gameInfoDeveloperCheckBox = new System.Windows.Forms.CheckBox();
            this.gameInfoConsoleCheckBox = new System.Windows.Forms.CheckBox();
            this.gameInfoDefaultButton = new System.Windows.Forms.Button();
            this.gameInfoGenreOverrideTextBox = new System.Windows.Forms.TextBox();
            this.gameInfoConsoleOverrideTextBox = new System.Windows.Forms.TextBox();
            this.gameInfoPublisherOverrideTextBox = new System.Windows.Forms.TextBox();
            this.gameInfoReleaseDateOverrideTextBox = new System.Windows.Forms.TextBox();
            this.gameInfoDeveloperOverrideTextBox = new System.Windows.Forms.TextBox();
            this.lastFiveOverridesGroupBox = new System.Windows.Forms.GroupBox();
            this.lastFiveVerboseCheckbox = new System.Windows.Forms.CheckBox();
            this.lastFiveSimpleCheckbox = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePictureBox)).BeginInit();
            this.statsGroupBox.SuspendLayout();
            this.focusGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.focusAchievementPictureBox)).BeginInit();
            this.notificationsGroupBox.SuspendLayout();
            this.userInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raConnectionStatusPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statsOverrideGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontOutlineNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontOutlineColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontColorPictureBox)).BeginInit();
            this.fontSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inAchievementNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outAchievementNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleAchievementNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customAchievementYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customAchievementXNumericUpDown)).BeginInit();
            this.customAchievementSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inMasteryNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outMasteryNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleMasteryNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customMasteryYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customMasteryXNumericUpDown)).BeginInit();
            this.customMasterySettingsGroupBox.SuspendLayout();
            this.gameInfoOverrideSettingsGroupBox.SuspendLayout();
            this.lastFiveOverridesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // apiKeyLabel
            // 
            this.apiKeyLabel.AutoSize = true;
            this.apiKeyLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apiKeyLabel.Location = new System.Drawing.Point(3, 145);
            this.apiKeyLabel.Name = "apiKeyLabel";
            this.apiKeyLabel.Size = new System.Drawing.Size(70, 13);
            this.apiKeyLabel.TabIndex = 31;
            this.apiKeyLabel.Text = "API Key";
            // 
            // apiKeyTextBox
            // 
            this.apiKeyTextBox.Font = new System.Drawing.Font("Calibri", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apiKeyTextBox.Location = new System.Drawing.Point(4, 161);
            this.apiKeyTextBox.Name = "apiKeyTextBox";
            this.apiKeyTextBox.PasswordChar = '*';
            this.apiKeyTextBox.Size = new System.Drawing.Size(199, 19);
            this.apiKeyTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(3, 107);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(79, 13);
            this.usernameLabel.TabIndex = 26;
            this.usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Calibri", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(5, 123);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(199, 19);
            this.usernameTextBox.TabIndex = 0;
            // 
            // userProfilePictureBox
            // 
            this.userProfilePictureBox.Location = new System.Drawing.Point(6, 22);
            this.userProfilePictureBox.Name = "userProfilePictureBox";
            this.userProfilePictureBox.Size = new System.Drawing.Size(80, 80);
            this.userProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userProfilePictureBox.TabIndex = 20;
            this.userProfilePictureBox.TabStop = false;
            // 
            // autoStartCheckbox
            // 
            this.autoStartCheckbox.AutoSize = true;
            this.autoStartCheckbox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoStartCheckbox.Location = new System.Drawing.Point(107, 102);
            this.autoStartCheckbox.Name = "autoStartCheckbox";
            this.autoStartCheckbox.Size = new System.Drawing.Size(96, 18);
            this.autoStartCheckbox.TabIndex = 2;
            this.autoStartCheckbox.Text = "Auto-Start";
            this.autoStartCheckbox.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stopButton.Location = new System.Drawing.Point(212, 157);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(69, 23);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // awardsLabel
            // 
            this.awardsLabel.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awardsLabel.Location = new System.Drawing.Point(86, 33);
            this.awardsLabel.Name = "awardsLabel";
            this.awardsLabel.Size = new System.Drawing.Size(195, 10);
            this.awardsLabel.TabIndex = 34;
            this.awardsLabel.Text = "Awards: ---";
            // 
            // siteRankLabel
            // 
            this.siteRankLabel.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteRankLabel.Location = new System.Drawing.Point(86, 22);
            this.siteRankLabel.Name = "siteRankLabel";
            this.siteRankLabel.Size = new System.Drawing.Size(195, 11);
            this.siteRankLabel.TabIndex = 33;
            this.siteRankLabel.Text = "Rank: -----";
            // 
            // pointsLabel
            // 
            this.pointsLabel.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.Location = new System.Drawing.Point(86, 43);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(195, 10);
            this.pointsLabel.TabIndex = 32;
            this.pointsLabel.Text = "Points: --------";
            // 
            // timerStatusLabel
            // 
            this.timerStatusLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerStatusLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.timerStatusLabel.Location = new System.Drawing.Point(4, 26);
            this.timerStatusLabel.Name = "timerStatusLabel";
            this.timerStatusLabel.Size = new System.Drawing.Size(285, 39);
            this.timerStatusLabel.TabIndex = 10024;
            this.timerStatusLabel.Text = "Offline";
            // 
            // statsGroupBox
            // 
            this.statsGroupBox.Controls.Add(this.autoLaunchStatsWindowCheckbox);
            this.statsGroupBox.Controls.Add(this.customizeStatsButton);
            this.statsGroupBox.Controls.Add(this.openStatsWindowButton);
            this.statsGroupBox.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statsGroupBox.Location = new System.Drawing.Point(76, 194);
            this.statsGroupBox.Name = "statsGroupBox";
            this.statsGroupBox.Size = new System.Drawing.Size(72, 116);
            this.statsGroupBox.TabIndex = 10023;
            this.statsGroupBox.TabStop = false;
            this.statsGroupBox.Text = "Stats";
            // 
            // autoLaunchStatsWindowCheckbox
            // 
            this.autoLaunchStatsWindowCheckbox.AutoSize = true;
            this.autoLaunchStatsWindowCheckbox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLaunchStatsWindowCheckbox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.autoLaunchStatsWindowCheckbox.Location = new System.Drawing.Point(5, 95);
            this.autoLaunchStatsWindowCheckbox.Name = "autoLaunchStatsWindowCheckbox";
            this.autoLaunchStatsWindowCheckbox.Size = new System.Drawing.Size(54, 18);
            this.autoLaunchStatsWindowCheckbox.TabIndex = 10022;
            this.autoLaunchStatsWindowCheckbox.Text = "Auto";
            this.autoLaunchStatsWindowCheckbox.UseVisualStyleBackColor = true;
            // 
            // customizeStatsButton
            // 
            this.customizeStatsButton.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizeStatsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customizeStatsButton.Location = new System.Drawing.Point(4, 57);
            this.customizeStatsButton.Name = "customizeStatsButton";
            this.customizeStatsButton.Size = new System.Drawing.Size(61, 28);
            this.customizeStatsButton.TabIndex = 10024;
            this.customizeStatsButton.Text = "Custom";
            this.customizeStatsButton.UseVisualStyleBackColor = true;
            // 
            // openStatsWindowButton
            // 
            this.openStatsWindowButton.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openStatsWindowButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.openStatsWindowButton.Location = new System.Drawing.Point(5, 23);
            this.openStatsWindowButton.Name = "openStatsWindowButton";
            this.openStatsWindowButton.Size = new System.Drawing.Size(61, 28);
            this.openStatsWindowButton.TabIndex = 10021;
            this.openStatsWindowButton.Text = "Open";
            this.openStatsWindowButton.UseVisualStyleBackColor = true;
            // 
            // focusGroupBox
            // 
            this.focusGroupBox.Controls.Add(this.focusAchievementDescriptionLabel);
            this.focusGroupBox.Controls.Add(this.setFocusButton);
            this.focusGroupBox.Controls.Add(this.label33);
            this.focusGroupBox.Controls.Add(this.focusAchievementButtonRight);
            this.focusGroupBox.Controls.Add(this.hideFocusButton);
            this.focusGroupBox.Controls.Add(this.customizeFocusButton);
            this.focusGroupBox.Controls.Add(this.focusAchievementButtonLeft);
            this.focusGroupBox.Controls.Add(this.autoLaunchFocusWindowCheckBox);
            this.focusGroupBox.Controls.Add(this.focusAchievementPictureBox);
            this.focusGroupBox.Controls.Add(this.showFocusWindowButton);
            this.focusGroupBox.Controls.Add(this.focusAchievementTitleLabel);
            this.focusGroupBox.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.focusGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.focusGroupBox.Location = new System.Drawing.Point(294, 138);
            this.focusGroupBox.Name = "focusGroupBox";
            this.focusGroupBox.Size = new System.Drawing.Size(291, 172);
            this.focusGroupBox.TabIndex = 10001;
            this.focusGroupBox.TabStop = false;
            this.focusGroupBox.Text = "Focus";
            // 
            // focusAchievementDescriptionLabel
            // 
            this.focusAchievementDescriptionLabel.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.focusAchievementDescriptionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.focusAchievementDescriptionLabel.Location = new System.Drawing.Point(71, 79);
            this.focusAchievementDescriptionLabel.Name = "focusAchievementDescriptionLabel";
            this.focusAchievementDescriptionLabel.Size = new System.Drawing.Size(214, 62);
            this.focusAchievementDescriptionLabel.TabIndex = 5;
            this.focusAchievementDescriptionLabel.Text = "Defeat 1 of every enemy on The Island Closest to Hell in 1 session without magic " +
    "junctioned, leveling up or lowering the enemy\'";
            // 
            // setFocusButton
            // 
            this.setFocusButton.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setFocusButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.setFocusButton.Location = new System.Drawing.Point(71, 144);
            this.setFocusButton.Name = "setFocusButton";
            this.setFocusButton.Size = new System.Drawing.Size(46, 22);
            this.setFocusButton.TabIndex = 10001;
            this.setFocusButton.Text = "Set";
            this.setFocusButton.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label33.Location = new System.Drawing.Point(4, 69);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(282, 2);
            this.label33.TabIndex = 10002;
            // 
            // focusAchievementButtonRight
            // 
            this.focusAchievementButtonRight.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.focusAchievementButtonRight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.focusAchievementButtonRight.Location = new System.Drawing.Point(244, 144);
            this.focusAchievementButtonRight.Name = "focusAchievementButtonRight";
            this.focusAchievementButtonRight.Size = new System.Drawing.Size(42, 22);
            this.focusAchievementButtonRight.TabIndex = 10;
            this.focusAchievementButtonRight.Text = ">";
            this.focusAchievementButtonRight.UseVisualStyleBackColor = true;
            // 
            // hideFocusButton
            // 
            this.hideFocusButton.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideFocusButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hideFocusButton.Location = new System.Drawing.Point(123, 144);
            this.hideFocusButton.Name = "hideFocusButton";
            this.hideFocusButton.Size = new System.Drawing.Size(46, 22);
            this.hideFocusButton.TabIndex = 10001;
            this.hideFocusButton.Text = "Hide";
            this.hideFocusButton.UseVisualStyleBackColor = true;
            // 
            // customizeFocusButton
            // 
            this.customizeFocusButton.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizeFocusButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customizeFocusButton.Location = new System.Drawing.Point(6, 113);
            this.customizeFocusButton.Name = "customizeFocusButton";
            this.customizeFocusButton.Size = new System.Drawing.Size(62, 28);
            this.customizeFocusButton.TabIndex = 10025;
            this.customizeFocusButton.Text = "Custom";
            this.customizeFocusButton.UseVisualStyleBackColor = true;
            // 
            // focusAchievementButtonLeft
            // 
            this.focusAchievementButtonLeft.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.focusAchievementButtonLeft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.focusAchievementButtonLeft.Location = new System.Drawing.Point(196, 144);
            this.focusAchievementButtonLeft.Name = "focusAchievementButtonLeft";
            this.focusAchievementButtonLeft.Size = new System.Drawing.Size(42, 22);
            this.focusAchievementButtonLeft.TabIndex = 9;
            this.focusAchievementButtonLeft.Text = "<";
            this.focusAchievementButtonLeft.UseVisualStyleBackColor = true;
            // 
            // autoLaunchFocusWindowCheckBox
            // 
            this.autoLaunchFocusWindowCheckBox.AutoSize = true;
            this.autoLaunchFocusWindowCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLaunchFocusWindowCheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.autoLaunchFocusWindowCheckBox.Location = new System.Drawing.Point(10, 151);
            this.autoLaunchFocusWindowCheckBox.Name = "autoLaunchFocusWindowCheckBox";
            this.autoLaunchFocusWindowCheckBox.Size = new System.Drawing.Size(54, 18);
            this.autoLaunchFocusWindowCheckBox.TabIndex = 10020;
            this.autoLaunchFocusWindowCheckBox.Text = "Auto";
            this.autoLaunchFocusWindowCheckBox.UseVisualStyleBackColor = true;
            // 
            // focusAchievementPictureBox
            // 
            this.focusAchievementPictureBox.Location = new System.Drawing.Point(7, 11);
            this.focusAchievementPictureBox.Name = "focusAchievementPictureBox";
            this.focusAchievementPictureBox.Size = new System.Drawing.Size(55, 55);
            this.focusAchievementPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.focusAchievementPictureBox.TabIndex = 21;
            this.focusAchievementPictureBox.TabStop = false;
            // 
            // showFocusWindowButton
            // 
            this.showFocusWindowButton.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFocusWindowButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showFocusWindowButton.Location = new System.Drawing.Point(6, 79);
            this.showFocusWindowButton.Name = "showFocusWindowButton";
            this.showFocusWindowButton.Size = new System.Drawing.Size(62, 28);
            this.showFocusWindowButton.TabIndex = 10014;
            this.showFocusWindowButton.Text = "Open";
            this.showFocusWindowButton.UseVisualStyleBackColor = true;
            // 
            // focusAchievementTitleLabel
            // 
            this.focusAchievementTitleLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.focusAchievementTitleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.focusAchievementTitleLabel.Location = new System.Drawing.Point(68, 11);
            this.focusAchievementTitleLabel.Name = "focusAchievementTitleLabel";
            this.focusAchievementTitleLabel.Size = new System.Drawing.Size(218, 55);
            this.focusAchievementTitleLabel.TabIndex = 6;
            this.focusAchievementTitleLabel.Text = "Phantasy Explorer X (Laconian Shield Cave)";
            // 
            // notificationsGroupBox
            // 
            this.notificationsGroupBox.Controls.Add(this.customizeAlertsButton);
            this.notificationsGroupBox.Controls.Add(this.autoLaunchNotificationsWindowCheckbox);
            this.notificationsGroupBox.Controls.Add(this.openAlertsWindowButton);
            this.notificationsGroupBox.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationsGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.notificationsGroupBox.Location = new System.Drawing.Point(4, 194);
            this.notificationsGroupBox.Name = "notificationsGroupBox";
            this.notificationsGroupBox.Size = new System.Drawing.Size(72, 116);
            this.notificationsGroupBox.TabIndex = 10006;
            this.notificationsGroupBox.TabStop = false;
            this.notificationsGroupBox.Text = "Alerts";
            // 
            // customizeAlertsButton
            // 
            this.customizeAlertsButton.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizeAlertsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customizeAlertsButton.Location = new System.Drawing.Point(6, 57);
            this.customizeAlertsButton.Name = "customizeAlertsButton";
            this.customizeAlertsButton.Size = new System.Drawing.Size(61, 28);
            this.customizeAlertsButton.TabIndex = 10025;
            this.customizeAlertsButton.Text = "Custom";
            this.customizeAlertsButton.UseVisualStyleBackColor = true;
            // 
            // autoLaunchNotificationsWindowCheckbox
            // 
            this.autoLaunchNotificationsWindowCheckbox.AutoSize = true;
            this.autoLaunchNotificationsWindowCheckbox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLaunchNotificationsWindowCheckbox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.autoLaunchNotificationsWindowCheckbox.Location = new System.Drawing.Point(6, 95);
            this.autoLaunchNotificationsWindowCheckbox.Name = "autoLaunchNotificationsWindowCheckbox";
            this.autoLaunchNotificationsWindowCheckbox.Size = new System.Drawing.Size(54, 18);
            this.autoLaunchNotificationsWindowCheckbox.TabIndex = 10022;
            this.autoLaunchNotificationsWindowCheckbox.Text = "Auto";
            this.autoLaunchNotificationsWindowCheckbox.UseVisualStyleBackColor = true;
            // 
            // openAlertsWindowButton
            // 
            this.openAlertsWindowButton.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAlertsWindowButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.openAlertsWindowButton.Location = new System.Drawing.Point(5, 23);
            this.openAlertsWindowButton.Name = "openAlertsWindowButton";
            this.openAlertsWindowButton.Size = new System.Drawing.Size(61, 28);
            this.openAlertsWindowButton.TabIndex = 10021;
            this.openAlertsWindowButton.Text = "Open";
            this.openAlertsWindowButton.UseVisualStyleBackColor = true;
            // 
            // userInfoGroupBox
            // 
            this.userInfoGroupBox.Controls.Add(this.truePointsLabel);
            this.userInfoGroupBox.Controls.Add(this.ratioLabel);
            this.userInfoGroupBox.Controls.Add(this.hideButton);
            this.userInfoGroupBox.Controls.Add(this.userProfilePictureBox);
            this.userInfoGroupBox.Controls.Add(this.apiKeyLabel);
            this.userInfoGroupBox.Controls.Add(this.apiKeyTextBox);
            this.userInfoGroupBox.Controls.Add(this.usernameLabel);
            this.userInfoGroupBox.Controls.Add(this.usernameTextBox);
            this.userInfoGroupBox.Controls.Add(this.startButton);
            this.userInfoGroupBox.Controls.Add(this.pointsLabel);
            this.userInfoGroupBox.Controls.Add(this.autoStartCheckbox);
            this.userInfoGroupBox.Controls.Add(this.siteRankLabel);
            this.userInfoGroupBox.Controls.Add(this.stopButton);
            this.userInfoGroupBox.Controls.Add(this.awardsLabel);
            this.userInfoGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userInfoGroupBox.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfoGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userInfoGroupBox.Location = new System.Drawing.Point(4, 1);
            this.userInfoGroupBox.Name = "userInfoGroupBox";
            this.userInfoGroupBox.Size = new System.Drawing.Size(287, 187);
            this.userInfoGroupBox.TabIndex = 10008;
            this.userInfoGroupBox.TabStop = false;
            this.userInfoGroupBox.Text = "User Info";
            // 
            // truePointsLabel
            // 
            this.truePointsLabel.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truePointsLabel.Location = new System.Drawing.Point(86, 53);
            this.truePointsLabel.Name = "truePointsLabel";
            this.truePointsLabel.Size = new System.Drawing.Size(195, 11);
            this.truePointsLabel.TabIndex = 38;
            this.truePointsLabel.Text = "True Points: --------";
            // 
            // ratioLabel
            // 
            this.ratioLabel.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratioLabel.Location = new System.Drawing.Point(86, 64);
            this.ratioLabel.Name = "ratioLabel";
            this.ratioLabel.Size = new System.Drawing.Size(195, 11);
            this.ratioLabel.TabIndex = 36;
            this.ratioLabel.Text = "Ratio: ---";
            // 
            // hideButton
            // 
            this.hideButton.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hideButton.Location = new System.Drawing.Point(212, 92);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(69, 23);
            this.hideButton.TabIndex = 35;
            this.hideButton.Text = "Hide";
            this.hideButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startButton.Location = new System.Drawing.Point(212, 121);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(69, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // raConnectionStatusPictureBox
            // 
            this.raConnectionStatusPictureBox.Image = global::Retro_Achievement_Tracker.Properties.Resources.red_button;
            this.raConnectionStatusPictureBox.Location = new System.Drawing.Point(71, 0);
            this.raConnectionStatusPictureBox.Name = "raConnectionStatusPictureBox";
            this.raConnectionStatusPictureBox.Size = new System.Drawing.Size(23, 23);
            this.raConnectionStatusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raConnectionStatusPictureBox.TabIndex = 10025;
            this.raConnectionStatusPictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customizeGameButton);
            this.groupBox1.Controls.Add(this.autoLaunchGameInfoWindowCheckbox);
            this.groupBox1.Controls.Add(this.openGameInfoWindowButton);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(148, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(72, 116);
            this.groupBox1.TabIndex = 10025;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game";
            // 
            // customizeGameButton
            // 
            this.customizeGameButton.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizeGameButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customizeGameButton.Location = new System.Drawing.Point(6, 57);
            this.customizeGameButton.Name = "customizeGameButton";
            this.customizeGameButton.Size = new System.Drawing.Size(61, 28);
            this.customizeGameButton.TabIndex = 10024;
            this.customizeGameButton.Text = "Custom";
            this.customizeGameButton.UseVisualStyleBackColor = true;
            // 
            // autoLaunchGameInfoWindowCheckbox
            // 
            this.autoLaunchGameInfoWindowCheckbox.AutoSize = true;
            this.autoLaunchGameInfoWindowCheckbox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLaunchGameInfoWindowCheckbox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.autoLaunchGameInfoWindowCheckbox.Location = new System.Drawing.Point(6, 95);
            this.autoLaunchGameInfoWindowCheckbox.Name = "autoLaunchGameInfoWindowCheckbox";
            this.autoLaunchGameInfoWindowCheckbox.Size = new System.Drawing.Size(54, 18);
            this.autoLaunchGameInfoWindowCheckbox.TabIndex = 10022;
            this.autoLaunchGameInfoWindowCheckbox.Text = "Auto";
            this.autoLaunchGameInfoWindowCheckbox.UseVisualStyleBackColor = true;
            // 
            // openGameInfoWindowButton
            // 
            this.openGameInfoWindowButton.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openGameInfoWindowButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.openGameInfoWindowButton.Location = new System.Drawing.Point(5, 23);
            this.openGameInfoWindowButton.Name = "openGameInfoWindowButton";
            this.openGameInfoWindowButton.Size = new System.Drawing.Size(60, 28);
            this.openGameInfoWindowButton.TabIndex = 10021;
            this.openGameInfoWindowButton.Text = "Open";
            this.openGameInfoWindowButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.raConnectionStatusPictureBox);
            this.groupBox2.Controls.Add(this.timerStatusLabel);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(294, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 70);
            this.groupBox2.TabIndex = 10027;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.customizeLastFiveButton);
            this.groupBox3.Controls.Add(this.autoLaunchLastFiveWindowCheckbox);
            this.groupBox3.Controls.Add(this.openLastFiveWindowButton);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(219, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(72, 116);
            this.groupBox3.TabIndex = 10026;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Last 5";
            // 
            // customizeLastFiveButton
            // 
            this.customizeLastFiveButton.Enabled = false;
            this.customizeLastFiveButton.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizeLastFiveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customizeLastFiveButton.Location = new System.Drawing.Point(5, 56);
            this.customizeLastFiveButton.Name = "customizeLastFiveButton";
            this.customizeLastFiveButton.Size = new System.Drawing.Size(61, 29);
            this.customizeLastFiveButton.TabIndex = 10024;
            this.customizeLastFiveButton.Text = "Custom";
            this.customizeLastFiveButton.UseVisualStyleBackColor = true;
            // 
            // autoLaunchLastFiveWindowCheckbox
            // 
            this.autoLaunchLastFiveWindowCheckbox.AutoSize = true;
            this.autoLaunchLastFiveWindowCheckbox.Enabled = false;
            this.autoLaunchLastFiveWindowCheckbox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLaunchLastFiveWindowCheckbox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.autoLaunchLastFiveWindowCheckbox.Location = new System.Drawing.Point(5, 95);
            this.autoLaunchLastFiveWindowCheckbox.Name = "autoLaunchLastFiveWindowCheckbox";
            this.autoLaunchLastFiveWindowCheckbox.Size = new System.Drawing.Size(54, 18);
            this.autoLaunchLastFiveWindowCheckbox.TabIndex = 10022;
            this.autoLaunchLastFiveWindowCheckbox.Text = "Auto";
            this.autoLaunchLastFiveWindowCheckbox.UseVisualStyleBackColor = true;
            // 
            // openLastFiveWindowButton
            // 
            this.openLastFiveWindowButton.Enabled = false;
            this.openLastFiveWindowButton.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openLastFiveWindowButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.openLastFiveWindowButton.Location = new System.Drawing.Point(5, 23);
            this.openLastFiveWindowButton.Name = "openLastFiveWindowButton";
            this.openLastFiveWindowButton.Size = new System.Drawing.Size(61, 28);
            this.openLastFiveWindowButton.TabIndex = 10021;
            this.openLastFiveWindowButton.Text = "Open";
            this.openLastFiveWindowButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.focusStreamLabelsCheckBox);
            this.groupBox4.Controls.Add(this.alertsStreamLabelsCheckBox);
            this.groupBox4.Controls.Add(this.lastFiveStreamLabelsCheckBox);
            this.groupBox4.Controls.Add(this.gameInfoStreamLabelsCheckBox);
            this.groupBox4.Controls.Add(this.statsStreamLabelsCheckBox);
            this.groupBox4.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(294, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(291, 55);
            this.groupBox4.TabIndex = 10028;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stream Labels";
            // 
            // focusStreamLabelsCheckBox
            // 
            this.focusStreamLabelsCheckBox.AutoSize = true;
            this.focusStreamLabelsCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.focusStreamLabelsCheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.focusStreamLabelsCheckBox.Location = new System.Drawing.Point(203, 16);
            this.focusStreamLabelsCheckBox.Name = "focusStreamLabelsCheckBox";
            this.focusStreamLabelsCheckBox.Size = new System.Drawing.Size(61, 18);
            this.focusStreamLabelsCheckBox.TabIndex = 10029;
            this.focusStreamLabelsCheckBox.Text = "Focus";
            this.focusStreamLabelsCheckBox.UseVisualStyleBackColor = true;
            // 
            // alertsStreamLabelsCheckBox
            // 
            this.alertsStreamLabelsCheckBox.AutoSize = true;
            this.alertsStreamLabelsCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertsStreamLabelsCheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.alertsStreamLabelsCheckBox.Location = new System.Drawing.Point(105, 16);
            this.alertsStreamLabelsCheckBox.Name = "alertsStreamLabelsCheckBox";
            this.alertsStreamLabelsCheckBox.Size = new System.Drawing.Size(68, 18);
            this.alertsStreamLabelsCheckBox.TabIndex = 10028;
            this.alertsStreamLabelsCheckBox.Text = "Alerts";
            this.alertsStreamLabelsCheckBox.UseVisualStyleBackColor = true;
            // 
            // lastFiveStreamLabelsCheckBox
            // 
            this.lastFiveStreamLabelsCheckBox.AutoSize = true;
            this.lastFiveStreamLabelsCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastFiveStreamLabelsCheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lastFiveStreamLabelsCheckBox.Location = new System.Drawing.Point(105, 31);
            this.lastFiveStreamLabelsCheckBox.Name = "lastFiveStreamLabelsCheckBox";
            this.lastFiveStreamLabelsCheckBox.Size = new System.Drawing.Size(68, 18);
            this.lastFiveStreamLabelsCheckBox.TabIndex = 10027;
            this.lastFiveStreamLabelsCheckBox.Text = "Last 5";
            this.lastFiveStreamLabelsCheckBox.UseVisualStyleBackColor = true;
            this.lastFiveStreamLabelsCheckBox.CheckedChanged += new System.EventHandler(this.lastFiveStreamLabelsCheckBox_CheckedChanged);
            // 
            // gameInfoStreamLabelsCheckBox
            // 
            this.gameInfoStreamLabelsCheckBox.AutoSize = true;
            this.gameInfoStreamLabelsCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoStreamLabelsCheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gameInfoStreamLabelsCheckBox.Location = new System.Drawing.Point(10, 31);
            this.gameInfoStreamLabelsCheckBox.Name = "gameInfoStreamLabelsCheckBox";
            this.gameInfoStreamLabelsCheckBox.Size = new System.Drawing.Size(89, 18);
            this.gameInfoStreamLabelsCheckBox.TabIndex = 10026;
            this.gameInfoStreamLabelsCheckBox.Text = "Game Info";
            this.gameInfoStreamLabelsCheckBox.UseVisualStyleBackColor = true;
            this.gameInfoStreamLabelsCheckBox.CheckedChanged += new System.EventHandler(this.gameInfoStreamLabelsCheckBox_CheckedChanged);
            // 
            // statsStreamLabelsCheckBox
            // 
            this.statsStreamLabelsCheckBox.AutoSize = true;
            this.statsStreamLabelsCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsStreamLabelsCheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.statsStreamLabelsCheckBox.Location = new System.Drawing.Point(10, 16);
            this.statsStreamLabelsCheckBox.Name = "statsStreamLabelsCheckBox";
            this.statsStreamLabelsCheckBox.Size = new System.Drawing.Size(61, 18);
            this.statsStreamLabelsCheckBox.TabIndex = 10025;
            this.statsStreamLabelsCheckBox.Text = "Stats";
            this.statsStreamLabelsCheckBox.UseVisualStyleBackColor = true;
            this.statsStreamLabelsCheckBox.CheckedChanged += new System.EventHandler(this.statsStreamLabelsCheckBox_CheckedChanged);
            // 
            // statsGameRatioOverrideTextBox
            // 
            this.statsGameRatioOverrideTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsGameRatioOverrideTextBox.Location = new System.Drawing.Point(145, 118);
            this.statsGameRatioOverrideTextBox.Name = "statsGameRatioOverrideTextBox";
            this.statsGameRatioOverrideTextBox.Size = new System.Drawing.Size(133, 20);
            this.statsGameRatioOverrideTextBox.TabIndex = 8;
            this.statsGameRatioOverrideTextBox.Text = "Ratio";
            this.statsGameRatioOverrideTextBox.TextChanged += new System.EventHandler(this.statsGameRatioOverrideTextBox_TextChanged);
            // 
            // statsTruePointsOverrideTextBox
            // 
            this.statsTruePointsOverrideTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsTruePointsOverrideTextBox.Location = new System.Drawing.Point(144, 74);
            this.statsTruePointsOverrideTextBox.Name = "statsTruePointsOverrideTextBox";
            this.statsTruePointsOverrideTextBox.Size = new System.Drawing.Size(133, 20);
            this.statsTruePointsOverrideTextBox.TabIndex = 7;
            this.statsTruePointsOverrideTextBox.Text = "T. Points";
            this.statsTruePointsOverrideTextBox.TextChanged += new System.EventHandler(this.statsTruePointsOverrideTextBox_TextChanged);
            // 
            // statsPointsOverrideTextBox
            // 
            this.statsPointsOverrideTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsPointsOverrideTextBox.Location = new System.Drawing.Point(144, 32);
            this.statsPointsOverrideTextBox.Name = "statsPointsOverrideTextBox";
            this.statsPointsOverrideTextBox.Size = new System.Drawing.Size(133, 20);
            this.statsPointsOverrideTextBox.TabIndex = 6;
            this.statsPointsOverrideTextBox.Text = "Points";
            this.statsPointsOverrideTextBox.TextChanged += new System.EventHandler(this.statsPointsOverrideTextBox_TextChanged);
            // 
            // statsRatioOverrideTextBox
            // 
            this.statsRatioOverrideTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsRatioOverrideTextBox.Location = new System.Drawing.Point(6, 118);
            this.statsRatioOverrideTextBox.Name = "statsRatioOverrideTextBox";
            this.statsRatioOverrideTextBox.Size = new System.Drawing.Size(133, 20);
            this.statsRatioOverrideTextBox.TabIndex = 5;
            this.statsRatioOverrideTextBox.Text = "Ratio";
            this.statsRatioOverrideTextBox.TextChanged += new System.EventHandler(this.statsRatioOverrideTextBox_TextChanged);
            // 
            // statsAwardsOverrideTextBox
            // 
            this.statsAwardsOverrideTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsAwardsOverrideTextBox.Location = new System.Drawing.Point(6, 74);
            this.statsAwardsOverrideTextBox.Name = "statsAwardsOverrideTextBox";
            this.statsAwardsOverrideTextBox.Size = new System.Drawing.Size(133, 20);
            this.statsAwardsOverrideTextBox.TabIndex = 3;
            this.statsAwardsOverrideTextBox.Text = "Awards";
            this.statsAwardsOverrideTextBox.TextChanged += new System.EventHandler(this.statsAwardsOverrideTextBox_TextChanged);
            // 
            // statsRankOverrideTextBox
            // 
            this.statsRankOverrideTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsRankOverrideTextBox.Location = new System.Drawing.Point(5, 31);
            this.statsRankOverrideTextBox.Name = "statsRankOverrideTextBox";
            this.statsRankOverrideTextBox.Size = new System.Drawing.Size(133, 20);
            this.statsRankOverrideTextBox.TabIndex = 1;
            this.statsRankOverrideTextBox.Text = "Rank";
            this.statsRankOverrideTextBox.TextChanged += new System.EventHandler(this.statsRankOverrideTextBox_TextChanged);
            // 
            // statsOverrideGroupBox
            // 
            this.statsOverrideGroupBox.Controls.Add(this.statsGameAchievementsCheckBox);
            this.statsOverrideGroupBox.Controls.Add(this.statsGameTruePointsCheckBox);
            this.statsOverrideGroupBox.Controls.Add(this.statsGamePointsCheckBox);
            this.statsOverrideGroupBox.Controls.Add(this.statsGameRatioCheckBox);
            this.statsOverrideGroupBox.Controls.Add(this.statsRatioCheckBox);
            this.statsOverrideGroupBox.Controls.Add(this.statsTruePointsCheckBox);
            this.statsOverrideGroupBox.Controls.Add(this.statsPointsCheckBox);
            this.statsOverrideGroupBox.Controls.Add(this.statsAwardsCheckBox);
            this.statsOverrideGroupBox.Controls.Add(this.statsRankCheckBox);
            this.statsOverrideGroupBox.Controls.Add(this.statsDefaultButton);
            this.statsOverrideGroupBox.Controls.Add(this.statsGameTruePointsOverrideTextBox);
            this.statsOverrideGroupBox.Controls.Add(this.statsGamePointsOverrideTextBox);
            this.statsOverrideGroupBox.Controls.Add(this.statsGameAchievementsOverrideTextBox);
            this.statsOverrideGroupBox.Controls.Add(this.statsGameRatioOverrideTextBox);
            this.statsOverrideGroupBox.Controls.Add(this.statsTruePointsOverrideTextBox);
            this.statsOverrideGroupBox.Controls.Add(this.statsPointsOverrideTextBox);
            this.statsOverrideGroupBox.Controls.Add(this.statsRatioOverrideTextBox);
            this.statsOverrideGroupBox.Controls.Add(this.statsAwardsOverrideTextBox);
            this.statsOverrideGroupBox.Controls.Add(this.statsRankOverrideTextBox);
            this.statsOverrideGroupBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsOverrideGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statsOverrideGroupBox.Location = new System.Drawing.Point(593, 313);
            this.statsOverrideGroupBox.Name = "statsOverrideGroupBox";
            this.statsOverrideGroupBox.Size = new System.Drawing.Size(287, 305);
            this.statsOverrideGroupBox.TabIndex = 10007;
            this.statsOverrideGroupBox.TabStop = false;
            this.statsOverrideGroupBox.Text = "Stats Overrides";
            // 
            // statsGameAchievementsCheckBox
            // 
            this.statsGameAchievementsCheckBox.AutoSize = true;
            this.statsGameAchievementsCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsGameAchievementsCheckBox.Location = new System.Drawing.Point(5, 256);
            this.statsGameAchievementsCheckBox.Name = "statsGameAchievementsCheckBox";
            this.statsGameAchievementsCheckBox.Size = new System.Drawing.Size(145, 18);
            this.statsGameAchievementsCheckBox.TabIndex = 47;
            this.statsGameAchievementsCheckBox.Text = "Game Achievements";
            this.statsGameAchievementsCheckBox.UseVisualStyleBackColor = true;
            this.statsGameAchievementsCheckBox.CheckedChanged += new System.EventHandler(this.statsGameAchievementsCheckBox_CheckedChanged);
            // 
            // statsGameTruePointsCheckBox
            // 
            this.statsGameTruePointsCheckBox.AutoSize = true;
            this.statsGameTruePointsCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsGameTruePointsCheckBox.Location = new System.Drawing.Point(6, 212);
            this.statsGameTruePointsCheckBox.Name = "statsGameTruePointsCheckBox";
            this.statsGameTruePointsCheckBox.Size = new System.Drawing.Size(138, 18);
            this.statsGameTruePointsCheckBox.TabIndex = 46;
            this.statsGameTruePointsCheckBox.Text = "Game True Points";
            this.statsGameTruePointsCheckBox.UseVisualStyleBackColor = true;
            this.statsGameTruePointsCheckBox.CheckedChanged += new System.EventHandler(this.statsGameTruePointsCheckBox_CheckedChanged);
            // 
            // statsGamePointsCheckBox
            // 
            this.statsGamePointsCheckBox.AutoSize = true;
            this.statsGamePointsCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsGamePointsCheckBox.Location = new System.Drawing.Point(6, 168);
            this.statsGamePointsCheckBox.Name = "statsGamePointsCheckBox";
            this.statsGamePointsCheckBox.Size = new System.Drawing.Size(103, 18);
            this.statsGamePointsCheckBox.TabIndex = 45;
            this.statsGamePointsCheckBox.Text = "Game Points";
            this.statsGamePointsCheckBox.UseVisualStyleBackColor = true;
            this.statsGamePointsCheckBox.CheckedChanged += new System.EventHandler(this.statsGamePointsCheckBox_CheckedChanged);
            // 
            // statsGameRatioCheckBox
            // 
            this.statsGameRatioCheckBox.AutoSize = true;
            this.statsGameRatioCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsGameRatioCheckBox.Location = new System.Drawing.Point(145, 98);
            this.statsGameRatioCheckBox.Name = "statsGameRatioCheckBox";
            this.statsGameRatioCheckBox.Size = new System.Drawing.Size(96, 18);
            this.statsGameRatioCheckBox.TabIndex = 44;
            this.statsGameRatioCheckBox.Text = "Game Ratio";
            this.statsGameRatioCheckBox.UseVisualStyleBackColor = true;
            this.statsGameRatioCheckBox.CheckedChanged += new System.EventHandler(this.statsGameRatioCheckBox_CheckedChanged);
            // 
            // statsRatioCheckBox
            // 
            this.statsRatioCheckBox.AutoSize = true;
            this.statsRatioCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsRatioCheckBox.Location = new System.Drawing.Point(6, 100);
            this.statsRatioCheckBox.Name = "statsRatioCheckBox";
            this.statsRatioCheckBox.Size = new System.Drawing.Size(61, 18);
            this.statsRatioCheckBox.TabIndex = 43;
            this.statsRatioCheckBox.Text = "Ratio";
            this.statsRatioCheckBox.UseVisualStyleBackColor = true;
            this.statsRatioCheckBox.CheckedChanged += new System.EventHandler(this.statsRatioCheckBox_CheckedChanged);
            // 
            // statsTruePointsCheckBox
            // 
            this.statsTruePointsCheckBox.AutoSize = true;
            this.statsTruePointsCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsTruePointsCheckBox.Location = new System.Drawing.Point(144, 55);
            this.statsTruePointsCheckBox.Name = "statsTruePointsCheckBox";
            this.statsTruePointsCheckBox.Size = new System.Drawing.Size(103, 18);
            this.statsTruePointsCheckBox.TabIndex = 42;
            this.statsTruePointsCheckBox.Text = "True Points";
            this.statsTruePointsCheckBox.UseVisualStyleBackColor = true;
            this.statsTruePointsCheckBox.CheckedChanged += new System.EventHandler(this.statsTruePointsCheckBox_CheckedChanged);
            // 
            // statsPointsCheckBox
            // 
            this.statsPointsCheckBox.AutoSize = true;
            this.statsPointsCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsPointsCheckBox.Location = new System.Drawing.Point(144, 14);
            this.statsPointsCheckBox.Name = "statsPointsCheckBox";
            this.statsPointsCheckBox.Size = new System.Drawing.Size(68, 18);
            this.statsPointsCheckBox.TabIndex = 41;
            this.statsPointsCheckBox.Text = "Points";
            this.statsPointsCheckBox.UseVisualStyleBackColor = true;
            this.statsPointsCheckBox.CheckedChanged += new System.EventHandler(this.statsPointsCheckBox_CheckedChanged);
            // 
            // statsAwardsCheckBox
            // 
            this.statsAwardsCheckBox.AutoSize = true;
            this.statsAwardsCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsAwardsCheckBox.Location = new System.Drawing.Point(6, 57);
            this.statsAwardsCheckBox.Name = "statsAwardsCheckBox";
            this.statsAwardsCheckBox.Size = new System.Drawing.Size(68, 18);
            this.statsAwardsCheckBox.TabIndex = 40;
            this.statsAwardsCheckBox.Text = "Awards";
            this.statsAwardsCheckBox.UseVisualStyleBackColor = true;
            this.statsAwardsCheckBox.CheckedChanged += new System.EventHandler(this.statsAwardsCheckBox_CheckedChanged);
            // 
            // statsRankCheckBox
            // 
            this.statsRankCheckBox.AutoSize = true;
            this.statsRankCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsRankCheckBox.Location = new System.Drawing.Point(6, 12);
            this.statsRankCheckBox.Name = "statsRankCheckBox";
            this.statsRankCheckBox.Size = new System.Drawing.Size(54, 18);
            this.statsRankCheckBox.TabIndex = 39;
            this.statsRankCheckBox.Text = "Rank";
            this.statsRankCheckBox.UseVisualStyleBackColor = true;
            this.statsRankCheckBox.CheckedChanged += new System.EventHandler(this.StatsRankCheckBox_CheckedChanged);
            // 
            // statsDefaultButton
            // 
            this.statsDefaultButton.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsDefaultButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statsDefaultButton.Location = new System.Drawing.Point(209, 276);
            this.statsDefaultButton.Name = "statsDefaultButton";
            this.statsDefaultButton.Size = new System.Drawing.Size(72, 23);
            this.statsDefaultButton.TabIndex = 39;
            this.statsDefaultButton.Text = "Default";
            this.statsDefaultButton.UseVisualStyleBackColor = true;
            this.statsDefaultButton.Click += new System.EventHandler(this.StatsDefaultButton_Click);
            // 
            // statsGameTruePointsOverrideTextBox
            // 
            this.statsGameTruePointsOverrideTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsGameTruePointsOverrideTextBox.Location = new System.Drawing.Point(6, 230);
            this.statsGameTruePointsOverrideTextBox.Name = "statsGameTruePointsOverrideTextBox";
            this.statsGameTruePointsOverrideTextBox.Size = new System.Drawing.Size(166, 20);
            this.statsGameTruePointsOverrideTextBox.TabIndex = 16;
            this.statsGameTruePointsOverrideTextBox.Text = "T. Points";
            this.statsGameTruePointsOverrideTextBox.TextChanged += new System.EventHandler(this.statsGameTruePointsOverrideTextBox_TextChanged);
            // 
            // statsGamePointsOverrideTextBox
            // 
            this.statsGamePointsOverrideTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsGamePointsOverrideTextBox.Location = new System.Drawing.Point(6, 186);
            this.statsGamePointsOverrideTextBox.Name = "statsGamePointsOverrideTextBox";
            this.statsGamePointsOverrideTextBox.Size = new System.Drawing.Size(166, 20);
            this.statsGamePointsOverrideTextBox.TabIndex = 15;
            this.statsGamePointsOverrideTextBox.Text = "Points";
            this.statsGamePointsOverrideTextBox.TextChanged += new System.EventHandler(this.statsGamePointsOverrideTextBox_TextChanged);
            // 
            // statsGameAchievementsOverrideTextBox
            // 
            this.statsGameAchievementsOverrideTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsGameAchievementsOverrideTextBox.Location = new System.Drawing.Point(5, 277);
            this.statsGameAchievementsOverrideTextBox.Name = "statsGameAchievementsOverrideTextBox";
            this.statsGameAchievementsOverrideTextBox.Size = new System.Drawing.Size(167, 20);
            this.statsGameAchievementsOverrideTextBox.TabIndex = 13;
            this.statsGameAchievementsOverrideTextBox.Text = "Cheevos";
            this.statsGameAchievementsOverrideTextBox.TextChanged += new System.EventHandler(this.statsGameAchievementsOverrideTextBox_TextChanged);
            // 
            // fontFamilyComboBox
            // 
            this.fontFamilyComboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontFamilyComboBox.FormattingEnabled = true;
            this.fontFamilyComboBox.Location = new System.Drawing.Point(4, 19);
            this.fontFamilyComboBox.Name = "fontFamilyComboBox";
            this.fontFamilyComboBox.Size = new System.Drawing.Size(276, 23);
            this.fontFamilyComboBox.TabIndex = 38;
            // 
            // setBackgroundColorButton
            // 
            this.setBackgroundColorButton.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setBackgroundColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.setBackgroundColorButton.Location = new System.Drawing.Point(231, 48);
            this.setBackgroundColorButton.Name = "setBackgroundColorButton";
            this.setBackgroundColorButton.Size = new System.Drawing.Size(49, 23);
            this.setBackgroundColorButton.TabIndex = 37;
            this.setBackgroundColorButton.Text = "Set";
            this.setBackgroundColorButton.UseVisualStyleBackColor = true;
            // 
            // backgroundColorPictureBox
            // 
            this.backgroundColorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.backgroundColorPictureBox.Location = new System.Drawing.Point(175, 49);
            this.backgroundColorPictureBox.Name = "backgroundColorPictureBox";
            this.backgroundColorPictureBox.Size = new System.Drawing.Size(50, 22);
            this.backgroundColorPictureBox.TabIndex = 36;
            this.backgroundColorPictureBox.TabStop = false;
            // 
            // backgroundColorLabel
            // 
            this.backgroundColorLabel.AutoSize = true;
            this.backgroundColorLabel.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundColorLabel.Location = new System.Drawing.Point(2, 57);
            this.backgroundColorLabel.Name = "backgroundColorLabel";
            this.backgroundColorLabel.Size = new System.Drawing.Size(85, 12);
            this.backgroundColorLabel.TabIndex = 35;
            this.backgroundColorLabel.Text = "Background";
            // 
            // fontOutlineNumericUpDown
            // 
            this.fontOutlineNumericUpDown.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontOutlineNumericUpDown.Location = new System.Drawing.Point(121, 105);
            this.fontOutlineNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fontOutlineNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fontOutlineNumericUpDown.Name = "fontOutlineNumericUpDown";
            this.fontOutlineNumericUpDown.Size = new System.Drawing.Size(48, 22);
            this.fontOutlineNumericUpDown.TabIndex = 28;
            this.fontOutlineNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fontOutlineCheckBox
            // 
            this.fontOutlineCheckBox.AutoSize = true;
            this.fontOutlineCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontOutlineCheckBox.Location = new System.Drawing.Point(7, 109);
            this.fontOutlineCheckBox.Name = "fontOutlineCheckBox";
            this.fontOutlineCheckBox.Size = new System.Drawing.Size(75, 18);
            this.fontOutlineCheckBox.TabIndex = 27;
            this.fontOutlineCheckBox.Text = "Outline";
            this.fontOutlineCheckBox.UseVisualStyleBackColor = true;
            // 
            // fontOutlineColorButton
            // 
            this.fontOutlineColorButton.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontOutlineColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fontOutlineColorButton.Location = new System.Drawing.Point(231, 104);
            this.fontOutlineColorButton.Name = "fontOutlineColorButton";
            this.fontOutlineColorButton.Size = new System.Drawing.Size(49, 23);
            this.fontOutlineColorButton.TabIndex = 26;
            this.fontOutlineColorButton.Text = "Set";
            this.fontOutlineColorButton.UseVisualStyleBackColor = true;
            // 
            // fontOutlineColorPictureBox
            // 
            this.fontOutlineColorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fontOutlineColorPictureBox.Location = new System.Drawing.Point(175, 104);
            this.fontOutlineColorPictureBox.Name = "fontOutlineColorPictureBox";
            this.fontOutlineColorPictureBox.Size = new System.Drawing.Size(50, 22);
            this.fontOutlineColorPictureBox.TabIndex = 25;
            this.fontOutlineColorPictureBox.TabStop = false;
            // 
            // setFontColorButton
            // 
            this.setFontColorButton.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setFontColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.setFontColorButton.Location = new System.Drawing.Point(231, 76);
            this.setFontColorButton.Name = "setFontColorButton";
            this.setFontColorButton.Size = new System.Drawing.Size(49, 23);
            this.setFontColorButton.TabIndex = 22;
            this.setFontColorButton.Text = "Set";
            this.setFontColorButton.UseVisualStyleBackColor = true;
            // 
            // fontColorPictureBox
            // 
            this.fontColorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fontColorPictureBox.Location = new System.Drawing.Point(175, 77);
            this.fontColorPictureBox.Name = "fontColorPictureBox";
            this.fontColorPictureBox.Size = new System.Drawing.Size(50, 22);
            this.fontColorPictureBox.TabIndex = 21;
            this.fontColorPictureBox.TabStop = false;
            // 
            // fontColorLabel
            // 
            this.fontColorLabel.AutoSize = true;
            this.fontColorLabel.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontColorLabel.Location = new System.Drawing.Point(4, 83);
            this.fontColorLabel.Name = "fontColorLabel";
            this.fontColorLabel.Size = new System.Drawing.Size(85, 12);
            this.fontColorLabel.TabIndex = 20;
            this.fontColorLabel.Text = "Font Color";
            // 
            // fontSettingsGroupBox
            // 
            this.fontSettingsGroupBox.Controls.Add(this.fontFamilyComboBox);
            this.fontSettingsGroupBox.Controls.Add(this.setBackgroundColorButton);
            this.fontSettingsGroupBox.Controls.Add(this.backgroundColorPictureBox);
            this.fontSettingsGroupBox.Controls.Add(this.backgroundColorLabel);
            this.fontSettingsGroupBox.Controls.Add(this.fontOutlineNumericUpDown);
            this.fontSettingsGroupBox.Controls.Add(this.fontOutlineCheckBox);
            this.fontSettingsGroupBox.Controls.Add(this.fontOutlineColorButton);
            this.fontSettingsGroupBox.Controls.Add(this.fontOutlineColorPictureBox);
            this.fontSettingsGroupBox.Controls.Add(this.setFontColorButton);
            this.fontSettingsGroupBox.Controls.Add(this.fontColorPictureBox);
            this.fontSettingsGroupBox.Controls.Add(this.fontColorLabel);
            this.fontSettingsGroupBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontSettingsGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fontSettingsGroupBox.Location = new System.Drawing.Point(294, 313);
            this.fontSettingsGroupBox.Name = "fontSettingsGroupBox";
            this.fontSettingsGroupBox.Size = new System.Drawing.Size(291, 133);
            this.fontSettingsGroupBox.TabIndex = 10006;
            this.fontSettingsGroupBox.TabStop = false;
            this.fontSettingsGroupBox.Text = "Font Settings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 12);
            this.label9.TabIndex = 46;
            this.label9.Text = "Out-Animation";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 12);
            this.label10.TabIndex = 40;
            this.label10.Text = "In-Animation";
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(5, 276);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(134, 23);
            this.comboBox2.TabIndex = 45;
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(4, 225);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(136, 23);
            this.comboBox3.TabIndex = 39;
            // 
            // inAchievementNumericUpDown
            // 
            this.inAchievementNumericUpDown.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inAchievementNumericUpDown.Location = new System.Drawing.Point(83, 154);
            this.inAchievementNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inAchievementNumericUpDown.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.inAchievementNumericUpDown.Name = "inAchievementNumericUpDown";
            this.inAchievementNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.inAchievementNumericUpDown.TabIndex = 26;
            this.inAchievementNumericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // inLabel1
            // 
            this.inLabel1.AutoSize = true;
            this.inLabel1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inLabel1.Location = new System.Drawing.Point(3, 159);
            this.inLabel1.Name = "inLabel1";
            this.inLabel1.Size = new System.Drawing.Size(61, 12);
            this.inLabel1.TabIndex = 25;
            this.inLabel1.Text = "In (ms)";
            // 
            // outAchievementNumericUpDown
            // 
            this.outAchievementNumericUpDown.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outAchievementNumericUpDown.Location = new System.Drawing.Point(83, 180);
            this.outAchievementNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.outAchievementNumericUpDown.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.outAchievementNumericUpDown.Name = "outAchievementNumericUpDown";
            this.outAchievementNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.outAchievementNumericUpDown.TabIndex = 24;
            this.outAchievementNumericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // selectCustomAchievementButton
            // 
            this.selectCustomAchievementButton.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCustomAchievementButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectCustomAchievementButton.Location = new System.Drawing.Point(76, 16);
            this.selectCustomAchievementButton.Name = "selectCustomAchievementButton";
            this.selectCustomAchievementButton.Size = new System.Drawing.Size(66, 23);
            this.selectCustomAchievementButton.TabIndex = 14;
            this.selectCustomAchievementButton.Text = "File";
            this.selectCustomAchievementButton.UseVisualStyleBackColor = true;
            // 
            // outLabel1
            // 
            this.outLabel1.AutoSize = true;
            this.outLabel1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outLabel1.Location = new System.Drawing.Point(3, 183);
            this.outLabel1.Name = "outLabel1";
            this.outLabel1.Size = new System.Drawing.Size(69, 12);
            this.outLabel1.TabIndex = 23;
            this.outLabel1.Text = "Out (ms)";
            // 
            // scaleLabel1
            // 
            this.scaleLabel1.AutoSize = true;
            this.scaleLabel1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaleLabel1.Location = new System.Drawing.Point(4, 131);
            this.scaleLabel1.Name = "scaleLabel1";
            this.scaleLabel1.Size = new System.Drawing.Size(45, 12);
            this.scaleLabel1.TabIndex = 21;
            this.scaleLabel1.Text = "Scale";
            this.scaleLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scaleAchievementNumericUpDown
            // 
            this.scaleAchievementNumericUpDown.DecimalPlaces = 2;
            this.scaleAchievementNumericUpDown.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaleAchievementNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.scaleAchievementNumericUpDown.Location = new System.Drawing.Point(83, 128);
            this.scaleAchievementNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.scaleAchievementNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.scaleAchievementNumericUpDown.Name = "scaleAchievementNumericUpDown";
            this.scaleAchievementNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.scaleAchievementNumericUpDown.TabIndex = 20;
            this.scaleAchievementNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yPositionLabel1
            // 
            this.yPositionLabel1.AutoSize = true;
            this.yPositionLabel1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yPositionLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.yPositionLabel1.Location = new System.Drawing.Point(3, 105);
            this.yPositionLabel1.Name = "yPositionLabel1";
            this.yPositionLabel1.Size = new System.Drawing.Size(61, 12);
            this.yPositionLabel1.TabIndex = 19;
            this.yPositionLabel1.Text = "Y Coor.";
            this.yPositionLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // xPositionLabel1
            // 
            this.xPositionLabel1.AutoSize = true;
            this.xPositionLabel1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPositionLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.xPositionLabel1.Location = new System.Drawing.Point(2, 81);
            this.xPositionLabel1.Name = "xPositionLabel1";
            this.xPositionLabel1.Size = new System.Drawing.Size(61, 12);
            this.xPositionLabel1.TabIndex = 18;
            this.xPositionLabel1.Text = "X Coor.";
            // 
            // customAchievementYNumericUpDown
            // 
            this.customAchievementYNumericUpDown.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customAchievementYNumericUpDown.Location = new System.Drawing.Point(83, 102);
            this.customAchievementYNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.customAchievementYNumericUpDown.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.customAchievementYNumericUpDown.Name = "customAchievementYNumericUpDown";
            this.customAchievementYNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.customAchievementYNumericUpDown.TabIndex = 16;
            // 
            // customAchievementXNumericUpDown
            // 
            this.customAchievementXNumericUpDown.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customAchievementXNumericUpDown.Location = new System.Drawing.Point(83, 75);
            this.customAchievementXNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.customAchievementXNumericUpDown.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.customAchievementXNumericUpDown.Name = "customAchievementXNumericUpDown";
            this.customAchievementXNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.customAchievementXNumericUpDown.TabIndex = 15;
            // 
            // useCustomAchievementCheckbox
            // 
            this.useCustomAchievementCheckbox.AutoSize = true;
            this.useCustomAchievementCheckbox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useCustomAchievementCheckbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.useCustomAchievementCheckbox.Location = new System.Drawing.Point(6, 19);
            this.useCustomAchievementCheckbox.Name = "useCustomAchievementCheckbox";
            this.useCustomAchievementCheckbox.Size = new System.Drawing.Size(68, 18);
            this.useCustomAchievementCheckbox.TabIndex = 13;
            this.useCustomAchievementCheckbox.Text = "Enable";
            this.useCustomAchievementCheckbox.UseVisualStyleBackColor = true;
            // 
            // showAchievementButton
            // 
            this.showAchievementButton.BackColor = System.Drawing.SystemColors.Control;
            this.showAchievementButton.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAchievementButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showAchievementButton.Location = new System.Drawing.Point(76, 48);
            this.showAchievementButton.Name = "showAchievementButton";
            this.showAchievementButton.Size = new System.Drawing.Size(66, 23);
            this.showAchievementButton.TabIndex = 2;
            this.showAchievementButton.Text = "Recent";
            this.showAchievementButton.UseVisualStyleBackColor = false;
            // 
            // customAchievementSettingsGroupBox
            // 
            this.customAchievementSettingsGroupBox.Controls.Add(this.acheivementEditOutlineCheckbox);
            this.customAchievementSettingsGroupBox.Controls.Add(this.label9);
            this.customAchievementSettingsGroupBox.Controls.Add(this.label10);
            this.customAchievementSettingsGroupBox.Controls.Add(this.comboBox2);
            this.customAchievementSettingsGroupBox.Controls.Add(this.comboBox3);
            this.customAchievementSettingsGroupBox.Controls.Add(this.inAchievementNumericUpDown);
            this.customAchievementSettingsGroupBox.Controls.Add(this.inLabel1);
            this.customAchievementSettingsGroupBox.Controls.Add(this.outAchievementNumericUpDown);
            this.customAchievementSettingsGroupBox.Controls.Add(this.selectCustomAchievementButton);
            this.customAchievementSettingsGroupBox.Controls.Add(this.outLabel1);
            this.customAchievementSettingsGroupBox.Controls.Add(this.scaleLabel1);
            this.customAchievementSettingsGroupBox.Controls.Add(this.scaleAchievementNumericUpDown);
            this.customAchievementSettingsGroupBox.Controls.Add(this.yPositionLabel1);
            this.customAchievementSettingsGroupBox.Controls.Add(this.xPositionLabel1);
            this.customAchievementSettingsGroupBox.Controls.Add(this.customAchievementYNumericUpDown);
            this.customAchievementSettingsGroupBox.Controls.Add(this.customAchievementXNumericUpDown);
            this.customAchievementSettingsGroupBox.Controls.Add(this.useCustomAchievementCheckbox);
            this.customAchievementSettingsGroupBox.Controls.Add(this.showAchievementButton);
            this.customAchievementSettingsGroupBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customAchievementSettingsGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.customAchievementSettingsGroupBox.Location = new System.Drawing.Point(4, 313);
            this.customAchievementSettingsGroupBox.Name = "customAchievementSettingsGroupBox";
            this.customAchievementSettingsGroupBox.Size = new System.Drawing.Size(146, 305);
            this.customAchievementSettingsGroupBox.TabIndex = 10008;
            this.customAchievementSettingsGroupBox.TabStop = false;
            this.customAchievementSettingsGroupBox.Text = "Achievement";
            // 
            // acheivementEditOutlineCheckbox
            // 
            this.acheivementEditOutlineCheckbox.AutoSize = true;
            this.acheivementEditOutlineCheckbox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acheivementEditOutlineCheckbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.acheivementEditOutlineCheckbox.Location = new System.Drawing.Point(6, 51);
            this.acheivementEditOutlineCheckbox.Name = "acheivementEditOutlineCheckbox";
            this.acheivementEditOutlineCheckbox.Size = new System.Drawing.Size(54, 18);
            this.acheivementEditOutlineCheckbox.TabIndex = 47;
            this.acheivementEditOutlineCheckbox.Text = "Edit";
            this.acheivementEditOutlineCheckbox.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Enabled = false;
            this.label16.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(2, 261);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 12);
            this.label16.TabIndex = 44;
            this.label16.Text = "Out-Animation";
            // 
            // comboBox4
            // 
            this.comboBox4.Enabled = false;
            this.comboBox4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(4, 276);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(136, 23);
            this.comboBox4.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Enabled = false;
            this.label17.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(2, 210);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 12);
            this.label17.TabIndex = 42;
            this.label17.Text = "In-Animation";
            // 
            // inMasteryNumericUpDown
            // 
            this.inMasteryNumericUpDown.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inMasteryNumericUpDown.Location = new System.Drawing.Point(81, 154);
            this.inMasteryNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inMasteryNumericUpDown.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.inMasteryNumericUpDown.Name = "inMasteryNumericUpDown";
            this.inMasteryNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.inMasteryNumericUpDown.TabIndex = 26;
            this.inMasteryNumericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // comboBox5
            // 
            this.comboBox5.Enabled = false;
            this.comboBox5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(4, 225);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(136, 23);
            this.comboBox5.TabIndex = 41;
            // 
            // inLabel2
            // 
            this.inLabel2.AutoSize = true;
            this.inLabel2.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inLabel2.Location = new System.Drawing.Point(3, 159);
            this.inLabel2.Name = "inLabel2";
            this.inLabel2.Size = new System.Drawing.Size(61, 12);
            this.inLabel2.TabIndex = 25;
            this.inLabel2.Text = "In (ms)";
            // 
            // outMasteryNumericUpDown
            // 
            this.outMasteryNumericUpDown.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outMasteryNumericUpDown.Location = new System.Drawing.Point(81, 180);
            this.outMasteryNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.outMasteryNumericUpDown.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.outMasteryNumericUpDown.Name = "outMasteryNumericUpDown";
            this.outMasteryNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.outMasteryNumericUpDown.TabIndex = 24;
            this.outMasteryNumericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // selectCustomMasteryNotificationButton
            // 
            this.selectCustomMasteryNotificationButton.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCustomMasteryNotificationButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectCustomMasteryNotificationButton.Location = new System.Drawing.Point(74, 16);
            this.selectCustomMasteryNotificationButton.Name = "selectCustomMasteryNotificationButton";
            this.selectCustomMasteryNotificationButton.Size = new System.Drawing.Size(66, 23);
            this.selectCustomMasteryNotificationButton.TabIndex = 14;
            this.selectCustomMasteryNotificationButton.Text = "File";
            this.selectCustomMasteryNotificationButton.UseVisualStyleBackColor = true;
            this.selectCustomMasteryNotificationButton.Click += new System.EventHandler(this.SelectCustomMasteryNotificationButton_Click);
            // 
            // outLabel2
            // 
            this.outLabel2.AutoSize = true;
            this.outLabel2.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outLabel2.Location = new System.Drawing.Point(2, 183);
            this.outLabel2.Name = "outLabel2";
            this.outLabel2.Size = new System.Drawing.Size(69, 12);
            this.outLabel2.TabIndex = 23;
            this.outLabel2.Text = "Out (ms)";
            // 
            // scaleLabel2
            // 
            this.scaleLabel2.AutoSize = true;
            this.scaleLabel2.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaleLabel2.Location = new System.Drawing.Point(6, 131);
            this.scaleLabel2.Name = "scaleLabel2";
            this.scaleLabel2.Size = new System.Drawing.Size(45, 12);
            this.scaleLabel2.TabIndex = 21;
            this.scaleLabel2.Text = "Scale";
            this.scaleLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scaleMasteryNumericUpDown
            // 
            this.scaleMasteryNumericUpDown.DecimalPlaces = 2;
            this.scaleMasteryNumericUpDown.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaleMasteryNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.scaleMasteryNumericUpDown.Location = new System.Drawing.Point(81, 128);
            this.scaleMasteryNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.scaleMasteryNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.scaleMasteryNumericUpDown.Name = "scaleMasteryNumericUpDown";
            this.scaleMasteryNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.scaleMasteryNumericUpDown.TabIndex = 20;
            this.scaleMasteryNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yPositionLabel2
            // 
            this.yPositionLabel2.AutoSize = true;
            this.yPositionLabel2.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yPositionLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.yPositionLabel2.Location = new System.Drawing.Point(3, 105);
            this.yPositionLabel2.Name = "yPositionLabel2";
            this.yPositionLabel2.Size = new System.Drawing.Size(61, 12);
            this.yPositionLabel2.TabIndex = 19;
            this.yPositionLabel2.Text = "Y Coor.";
            this.yPositionLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // xPositionLabel2
            // 
            this.xPositionLabel2.AutoSize = true;
            this.xPositionLabel2.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPositionLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.xPositionLabel2.Location = new System.Drawing.Point(3, 81);
            this.xPositionLabel2.Name = "xPositionLabel2";
            this.xPositionLabel2.Size = new System.Drawing.Size(61, 12);
            this.xPositionLabel2.TabIndex = 18;
            this.xPositionLabel2.Text = "X Coor.";
            // 
            // customMasteryYNumericUpDown
            // 
            this.customMasteryYNumericUpDown.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customMasteryYNumericUpDown.Location = new System.Drawing.Point(81, 102);
            this.customMasteryYNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.customMasteryYNumericUpDown.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.customMasteryYNumericUpDown.Name = "customMasteryYNumericUpDown";
            this.customMasteryYNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.customMasteryYNumericUpDown.TabIndex = 16;
            // 
            // customMasteryXNumericUpDown
            // 
            this.customMasteryXNumericUpDown.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customMasteryXNumericUpDown.Location = new System.Drawing.Point(81, 78);
            this.customMasteryXNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.customMasteryXNumericUpDown.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.customMasteryXNumericUpDown.Name = "customMasteryXNumericUpDown";
            this.customMasteryXNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.customMasteryXNumericUpDown.TabIndex = 15;
            // 
            // useCustomMasteryCheckbox
            // 
            this.useCustomMasteryCheckbox.AutoSize = true;
            this.useCustomMasteryCheckbox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useCustomMasteryCheckbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.useCustomMasteryCheckbox.Location = new System.Drawing.Point(5, 19);
            this.useCustomMasteryCheckbox.Name = "useCustomMasteryCheckbox";
            this.useCustomMasteryCheckbox.Size = new System.Drawing.Size(68, 18);
            this.useCustomMasteryCheckbox.TabIndex = 13;
            this.useCustomMasteryCheckbox.Text = "Enable";
            this.useCustomMasteryCheckbox.UseVisualStyleBackColor = true;
            // 
            // showGameMasteryButton
            // 
            this.showGameMasteryButton.BackColor = System.Drawing.SystemColors.Control;
            this.showGameMasteryButton.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showGameMasteryButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showGameMasteryButton.Location = new System.Drawing.Point(74, 48);
            this.showGameMasteryButton.Name = "showGameMasteryButton";
            this.showGameMasteryButton.Size = new System.Drawing.Size(66, 23);
            this.showGameMasteryButton.TabIndex = 2;
            this.showGameMasteryButton.Text = "Recent";
            this.showGameMasteryButton.UseVisualStyleBackColor = false;
            // 
            // customMasterySettingsGroupBox
            // 
            this.customMasterySettingsGroupBox.Controls.Add(this.masteryEditOultineCheckbox);
            this.customMasterySettingsGroupBox.Controls.Add(this.label16);
            this.customMasterySettingsGroupBox.Controls.Add(this.comboBox4);
            this.customMasterySettingsGroupBox.Controls.Add(this.label17);
            this.customMasterySettingsGroupBox.Controls.Add(this.inMasteryNumericUpDown);
            this.customMasterySettingsGroupBox.Controls.Add(this.comboBox5);
            this.customMasterySettingsGroupBox.Controls.Add(this.inLabel2);
            this.customMasterySettingsGroupBox.Controls.Add(this.outMasteryNumericUpDown);
            this.customMasterySettingsGroupBox.Controls.Add(this.selectCustomMasteryNotificationButton);
            this.customMasterySettingsGroupBox.Controls.Add(this.outLabel2);
            this.customMasterySettingsGroupBox.Controls.Add(this.scaleLabel2);
            this.customMasterySettingsGroupBox.Controls.Add(this.scaleMasteryNumericUpDown);
            this.customMasterySettingsGroupBox.Controls.Add(this.yPositionLabel2);
            this.customMasterySettingsGroupBox.Controls.Add(this.xPositionLabel2);
            this.customMasterySettingsGroupBox.Controls.Add(this.customMasteryYNumericUpDown);
            this.customMasterySettingsGroupBox.Controls.Add(this.customMasteryXNumericUpDown);
            this.customMasterySettingsGroupBox.Controls.Add(this.useCustomMasteryCheckbox);
            this.customMasterySettingsGroupBox.Controls.Add(this.showGameMasteryButton);
            this.customMasterySettingsGroupBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customMasterySettingsGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.customMasterySettingsGroupBox.Location = new System.Drawing.Point(148, 313);
            this.customMasterySettingsGroupBox.Name = "customMasterySettingsGroupBox";
            this.customMasterySettingsGroupBox.Size = new System.Drawing.Size(143, 305);
            this.customMasterySettingsGroupBox.TabIndex = 10009;
            this.customMasterySettingsGroupBox.TabStop = false;
            this.customMasterySettingsGroupBox.Text = "Mastery";
            // 
            // masteryEditOultineCheckbox
            // 
            this.masteryEditOultineCheckbox.AutoSize = true;
            this.masteryEditOultineCheckbox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masteryEditOultineCheckbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.masteryEditOultineCheckbox.Location = new System.Drawing.Point(6, 51);
            this.masteryEditOultineCheckbox.Name = "masteryEditOultineCheckbox";
            this.masteryEditOultineCheckbox.Size = new System.Drawing.Size(54, 18);
            this.masteryEditOultineCheckbox.TabIndex = 48;
            this.masteryEditOultineCheckbox.Text = "Edit";
            this.masteryEditOultineCheckbox.UseVisualStyleBackColor = true;
            // 
            // gameInfoOverrideSettingsGroupBox
            // 
            this.gameInfoOverrideSettingsGroupBox.Controls.Add(this.gameInfoTitleCheckBox);
            this.gameInfoOverrideSettingsGroupBox.Controls.Add(this.gameInfoTitleOverrideTextBox);
            this.gameInfoOverrideSettingsGroupBox.Controls.Add(this.gameInfoBoxArtCheckbox);
            this.gameInfoOverrideSettingsGroupBox.Controls.Add(this.gameInfoReleaseDateCheckBox);
            this.gameInfoOverrideSettingsGroupBox.Controls.Add(this.gameInfoGenreCheckBox);
            this.gameInfoOverrideSettingsGroupBox.Controls.Add(this.gameInfoPublisherCheckBox);
            this.gameInfoOverrideSettingsGroupBox.Controls.Add(this.gameInfoDeveloperCheckBox);
            this.gameInfoOverrideSettingsGroupBox.Controls.Add(this.gameInfoConsoleCheckBox);
            this.gameInfoOverrideSettingsGroupBox.Controls.Add(this.gameInfoDefaultButton);
            this.gameInfoOverrideSettingsGroupBox.Controls.Add(this.gameInfoGenreOverrideTextBox);
            this.gameInfoOverrideSettingsGroupBox.Controls.Add(this.gameInfoConsoleOverrideTextBox);
            this.gameInfoOverrideSettingsGroupBox.Controls.Add(this.gameInfoPublisherOverrideTextBox);
            this.gameInfoOverrideSettingsGroupBox.Controls.Add(this.gameInfoReleaseDateOverrideTextBox);
            this.gameInfoOverrideSettingsGroupBox.Controls.Add(this.gameInfoDeveloperOverrideTextBox);
            this.gameInfoOverrideSettingsGroupBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoOverrideSettingsGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gameInfoOverrideSettingsGroupBox.Location = new System.Drawing.Point(886, 313);
            this.gameInfoOverrideSettingsGroupBox.Name = "gameInfoOverrideSettingsGroupBox";
            this.gameInfoOverrideSettingsGroupBox.Size = new System.Drawing.Size(287, 171);
            this.gameInfoOverrideSettingsGroupBox.TabIndex = 10008;
            this.gameInfoOverrideSettingsGroupBox.TabStop = false;
            this.gameInfoOverrideSettingsGroupBox.Text = "Game Info Overrides";
            // 
            // gameInfoTitleCheckBox
            // 
            this.gameInfoTitleCheckBox.AutoSize = true;
            this.gameInfoTitleCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoTitleCheckBox.Location = new System.Drawing.Point(8, 12);
            this.gameInfoTitleCheckBox.Name = "gameInfoTitleCheckBox";
            this.gameInfoTitleCheckBox.Size = new System.Drawing.Size(61, 18);
            this.gameInfoTitleCheckBox.TabIndex = 54;
            this.gameInfoTitleCheckBox.Text = "Title";
            this.gameInfoTitleCheckBox.UseVisualStyleBackColor = true;
            this.gameInfoTitleCheckBox.CheckedChanged += new System.EventHandler(this.gameInfoTitleCheckBox_CheckedChanged);
            // 
            // gameInfoTitleOverrideTextBox
            // 
            this.gameInfoTitleOverrideTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoTitleOverrideTextBox.Location = new System.Drawing.Point(7, 30);
            this.gameInfoTitleOverrideTextBox.Name = "gameInfoTitleOverrideTextBox";
            this.gameInfoTitleOverrideTextBox.Size = new System.Drawing.Size(133, 20);
            this.gameInfoTitleOverrideTextBox.TabIndex = 53;
            this.gameInfoTitleOverrideTextBox.Text = "Title";
            this.gameInfoTitleOverrideTextBox.TextChanged += new System.EventHandler(this.gameInfoTitleOverrideTextBox_TextChanged);
            // 
            // gameInfoBoxArtCheckbox
            // 
            this.gameInfoBoxArtCheckbox.AutoSize = true;
            this.gameInfoBoxArtCheckbox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoBoxArtCheckbox.Location = new System.Drawing.Point(6, 144);
            this.gameInfoBoxArtCheckbox.Name = "gameInfoBoxArtCheckbox";
            this.gameInfoBoxArtCheckbox.Size = new System.Drawing.Size(68, 18);
            this.gameInfoBoxArtCheckbox.TabIndex = 39;
            this.gameInfoBoxArtCheckbox.Text = "Boxart";
            this.gameInfoBoxArtCheckbox.UseVisualStyleBackColor = true;
            this.gameInfoBoxArtCheckbox.CheckedChanged += new System.EventHandler(this.gameInfoBoxArtCheckbox_CheckedChanged);
            // 
            // gameInfoReleaseDateCheckBox
            // 
            this.gameInfoReleaseDateCheckBox.AutoSize = true;
            this.gameInfoReleaseDateCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoReleaseDateCheckBox.Location = new System.Drawing.Point(148, 95);
            this.gameInfoReleaseDateCheckBox.Name = "gameInfoReleaseDateCheckBox";
            this.gameInfoReleaseDateCheckBox.Size = new System.Drawing.Size(110, 18);
            this.gameInfoReleaseDateCheckBox.TabIndex = 52;
            this.gameInfoReleaseDateCheckBox.Text = "Release Date";
            this.gameInfoReleaseDateCheckBox.UseVisualStyleBackColor = true;
            this.gameInfoReleaseDateCheckBox.CheckedChanged += new System.EventHandler(this.gameInfoReleaseDateCheckBox_CheckedChanged);
            // 
            // gameInfoGenreCheckBox
            // 
            this.gameInfoGenreCheckBox.AutoSize = true;
            this.gameInfoGenreCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoGenreCheckBox.Location = new System.Drawing.Point(7, 95);
            this.gameInfoGenreCheckBox.Name = "gameInfoGenreCheckBox";
            this.gameInfoGenreCheckBox.Size = new System.Drawing.Size(61, 18);
            this.gameInfoGenreCheckBox.TabIndex = 51;
            this.gameInfoGenreCheckBox.Text = "Genre";
            this.gameInfoGenreCheckBox.UseVisualStyleBackColor = true;
            this.gameInfoGenreCheckBox.CheckedChanged += new System.EventHandler(this.gameInfoGenreCheckBox_CheckedChanged);
            // 
            // gameInfoPublisherCheckBox
            // 
            this.gameInfoPublisherCheckBox.AutoSize = true;
            this.gameInfoPublisherCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoPublisherCheckBox.Location = new System.Drawing.Point(148, 51);
            this.gameInfoPublisherCheckBox.Name = "gameInfoPublisherCheckBox";
            this.gameInfoPublisherCheckBox.Size = new System.Drawing.Size(89, 18);
            this.gameInfoPublisherCheckBox.TabIndex = 50;
            this.gameInfoPublisherCheckBox.Text = "Publisher";
            this.gameInfoPublisherCheckBox.UseVisualStyleBackColor = true;
            this.gameInfoPublisherCheckBox.CheckedChanged += new System.EventHandler(this.gameInfoPublisherCheckBox_CheckedChanged);
            // 
            // gameInfoDeveloperCheckBox
            // 
            this.gameInfoDeveloperCheckBox.AutoSize = true;
            this.gameInfoDeveloperCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoDeveloperCheckBox.Location = new System.Drawing.Point(6, 49);
            this.gameInfoDeveloperCheckBox.Name = "gameInfoDeveloperCheckBox";
            this.gameInfoDeveloperCheckBox.Size = new System.Drawing.Size(89, 18);
            this.gameInfoDeveloperCheckBox.TabIndex = 49;
            this.gameInfoDeveloperCheckBox.Text = "Developer";
            this.gameInfoDeveloperCheckBox.UseVisualStyleBackColor = true;
            this.gameInfoDeveloperCheckBox.CheckedChanged += new System.EventHandler(this.gameInfoDeveloperCheckBox_CheckedChanged);
            // 
            // gameInfoConsoleCheckBox
            // 
            this.gameInfoConsoleCheckBox.AutoSize = true;
            this.gameInfoConsoleCheckBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoConsoleCheckBox.Location = new System.Drawing.Point(149, 14);
            this.gameInfoConsoleCheckBox.Name = "gameInfoConsoleCheckBox";
            this.gameInfoConsoleCheckBox.Size = new System.Drawing.Size(75, 18);
            this.gameInfoConsoleCheckBox.TabIndex = 48;
            this.gameInfoConsoleCheckBox.Text = "Console";
            this.gameInfoConsoleCheckBox.UseVisualStyleBackColor = true;
            this.gameInfoConsoleCheckBox.CheckedChanged += new System.EventHandler(this.gameInfoConsoleCheckBox_CheckedChanged);
            // 
            // gameInfoDefaultButton
            // 
            this.gameInfoDefaultButton.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoDefaultButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gameInfoDefaultButton.Location = new System.Drawing.Point(209, 139);
            this.gameInfoDefaultButton.Name = "gameInfoDefaultButton";
            this.gameInfoDefaultButton.Size = new System.Drawing.Size(72, 23);
            this.gameInfoDefaultButton.TabIndex = 40;
            this.gameInfoDefaultButton.Text = "Default";
            this.gameInfoDefaultButton.UseVisualStyleBackColor = true;
            this.gameInfoDefaultButton.Click += new System.EventHandler(this.GameInfoDefaultButton_Click);
            // 
            // gameInfoGenreOverrideTextBox
            // 
            this.gameInfoGenreOverrideTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoGenreOverrideTextBox.Location = new System.Drawing.Point(6, 113);
            this.gameInfoGenreOverrideTextBox.Name = "gameInfoGenreOverrideTextBox";
            this.gameInfoGenreOverrideTextBox.Size = new System.Drawing.Size(133, 20);
            this.gameInfoGenreOverrideTextBox.TabIndex = 25;
            this.gameInfoGenreOverrideTextBox.Text = "Genre";
            this.gameInfoGenreOverrideTextBox.TextChanged += new System.EventHandler(this.gameInfoGenreOverrideTextBox_TextChanged);
            // 
            // gameInfoConsoleOverrideTextBox
            // 
            this.gameInfoConsoleOverrideTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoConsoleOverrideTextBox.Location = new System.Drawing.Point(148, 32);
            this.gameInfoConsoleOverrideTextBox.Name = "gameInfoConsoleOverrideTextBox";
            this.gameInfoConsoleOverrideTextBox.Size = new System.Drawing.Size(133, 20);
            this.gameInfoConsoleOverrideTextBox.TabIndex = 19;
            this.gameInfoConsoleOverrideTextBox.Text = "Console";
            this.gameInfoConsoleOverrideTextBox.TextChanged += new System.EventHandler(this.gameInfoConsoleOverrideTextBox_TextChanged);
            // 
            // gameInfoPublisherOverrideTextBox
            // 
            this.gameInfoPublisherOverrideTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoPublisherOverrideTextBox.Location = new System.Drawing.Point(148, 69);
            this.gameInfoPublisherOverrideTextBox.Name = "gameInfoPublisherOverrideTextBox";
            this.gameInfoPublisherOverrideTextBox.Size = new System.Drawing.Size(133, 20);
            this.gameInfoPublisherOverrideTextBox.TabIndex = 24;
            this.gameInfoPublisherOverrideTextBox.Text = "Publisher";
            this.gameInfoPublisherOverrideTextBox.TextChanged += new System.EventHandler(this.gameInfoPublisherOverrideTextBox_TextChanged);
            // 
            // gameInfoReleaseDateOverrideTextBox
            // 
            this.gameInfoReleaseDateOverrideTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoReleaseDateOverrideTextBox.Location = new System.Drawing.Point(148, 113);
            this.gameInfoReleaseDateOverrideTextBox.Name = "gameInfoReleaseDateOverrideTextBox";
            this.gameInfoReleaseDateOverrideTextBox.Size = new System.Drawing.Size(133, 20);
            this.gameInfoReleaseDateOverrideTextBox.TabIndex = 23;
            this.gameInfoReleaseDateOverrideTextBox.Text = "Released";
            this.gameInfoReleaseDateOverrideTextBox.TextChanged += new System.EventHandler(this.gameInfoReleaseDateOverrideTextBox_TextChanged);
            // 
            // gameInfoDeveloperOverrideTextBox
            // 
            this.gameInfoDeveloperOverrideTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInfoDeveloperOverrideTextBox.Location = new System.Drawing.Point(6, 69);
            this.gameInfoDeveloperOverrideTextBox.Name = "gameInfoDeveloperOverrideTextBox";
            this.gameInfoDeveloperOverrideTextBox.Size = new System.Drawing.Size(133, 20);
            this.gameInfoDeveloperOverrideTextBox.TabIndex = 21;
            this.gameInfoDeveloperOverrideTextBox.Text = "Developer";
            this.gameInfoDeveloperOverrideTextBox.TextChanged += new System.EventHandler(this.gameInfoDeveloperOverrideTextBox_TextChanged);
            // 
            // lastFiveOverridesGroupBox
            // 
            this.lastFiveOverridesGroupBox.Controls.Add(this.lastFiveVerboseCheckbox);
            this.lastFiveOverridesGroupBox.Controls.Add(this.lastFiveSimpleCheckbox);
            this.lastFiveOverridesGroupBox.Controls.Add(this.label27);
            this.lastFiveOverridesGroupBox.Controls.Add(this.comboBox6);
            this.lastFiveOverridesGroupBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastFiveOverridesGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastFiveOverridesGroupBox.Location = new System.Drawing.Point(1179, 313);
            this.lastFiveOverridesGroupBox.Name = "lastFiveOverridesGroupBox";
            this.lastFiveOverridesGroupBox.Size = new System.Drawing.Size(287, 52);
            this.lastFiveOverridesGroupBox.TabIndex = 10030;
            this.lastFiveOverridesGroupBox.TabStop = false;
            this.lastFiveOverridesGroupBox.Text = "Last 5 Overrides";
            // 
            // lastFiveVerboseCheckbox
            // 
            this.lastFiveVerboseCheckbox.AutoSize = true;
            this.lastFiveVerboseCheckbox.Enabled = false;
            this.lastFiveVerboseCheckbox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastFiveVerboseCheckbox.Location = new System.Drawing.Point(80, 32);
            this.lastFiveVerboseCheckbox.Name = "lastFiveVerboseCheckbox";
            this.lastFiveVerboseCheckbox.Size = new System.Drawing.Size(75, 18);
            this.lastFiveVerboseCheckbox.TabIndex = 40;
            this.lastFiveVerboseCheckbox.Text = "Verbose";
            this.lastFiveVerboseCheckbox.UseVisualStyleBackColor = true;
            // 
            // lastFiveSimpleCheckbox
            // 
            this.lastFiveSimpleCheckbox.AutoSize = true;
            this.lastFiveSimpleCheckbox.Enabled = false;
            this.lastFiveSimpleCheckbox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastFiveSimpleCheckbox.Location = new System.Drawing.Point(6, 32);
            this.lastFiveSimpleCheckbox.Name = "lastFiveSimpleCheckbox";
            this.lastFiveSimpleCheckbox.Size = new System.Drawing.Size(68, 18);
            this.lastFiveSimpleCheckbox.TabIndex = 39;
            this.lastFiveSimpleCheckbox.Text = "Simple";
            this.lastFiveSimpleCheckbox.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.Enabled = false;
            this.label27.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(6, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(212, 19);
            this.label27.TabIndex = 39;
            this.label27.Text = "Achievements to display";
            // 
            // comboBox6
            // 
            this.comboBox6.Enabled = false;
            this.comboBox6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(223, 14);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(58, 23);
            this.comboBox6.TabIndex = 39;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1745, 721);
            this.Controls.Add(this.lastFiveOverridesGroupBox);
            this.Controls.Add(this.gameInfoOverrideSettingsGroupBox);
            this.Controls.Add(this.customMasterySettingsGroupBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.customAchievementSettingsGroupBox);
            this.Controls.Add(this.fontSettingsGroupBox);
            this.Controls.Add(this.statsOverrideGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userInfoGroupBox);
            this.Controls.Add(this.notificationsGroupBox);
            this.Controls.Add(this.statsGroupBox);
            this.Controls.Add(this.focusGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "Retro Achievements Tracker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePictureBox)).EndInit();
            this.statsGroupBox.ResumeLayout(false);
            this.statsGroupBox.PerformLayout();
            this.focusGroupBox.ResumeLayout(false);
            this.focusGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.focusAchievementPictureBox)).EndInit();
            this.notificationsGroupBox.ResumeLayout(false);
            this.notificationsGroupBox.PerformLayout();
            this.userInfoGroupBox.ResumeLayout(false);
            this.userInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raConnectionStatusPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statsOverrideGroupBox.ResumeLayout(false);
            this.statsOverrideGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontOutlineNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontOutlineColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontColorPictureBox)).EndInit();
            this.fontSettingsGroupBox.ResumeLayout(false);
            this.fontSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inAchievementNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outAchievementNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleAchievementNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customAchievementYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customAchievementXNumericUpDown)).EndInit();
            this.customAchievementSettingsGroupBox.ResumeLayout(false);
            this.customAchievementSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inMasteryNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outMasteryNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleMasteryNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customMasteryYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customMasteryXNumericUpDown)).EndInit();
            this.customMasterySettingsGroupBox.ResumeLayout(false);
            this.customMasterySettingsGroupBox.PerformLayout();
            this.gameInfoOverrideSettingsGroupBox.ResumeLayout(false);
            this.gameInfoOverrideSettingsGroupBox.PerformLayout();
            this.lastFiveOverridesGroupBox.ResumeLayout(false);
            this.lastFiveOverridesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion
        private Label usernameLabel;
        private Label apiKeyLabel;
        private Label siteRankLabel;
        private Label pointsLabel;
        private Label awardsLabel;
        private TextBox apiKeyTextBox;
        private TextBox usernameTextBox;
        private PictureBox userProfilePictureBox;
        private Button startButton;
        private Button stopButton;
        private Button showFocusWindowButton;
        private CheckBox autoStartCheckbox;
        private CheckBox autoLaunchFocusWindowCheckBox;
        private GroupBox notificationsGroupBox;
        private GroupBox userInfoGroupBox;
        private GroupBox focusGroupBox;
        private GroupBox statsGroupBox;
        private CheckBox autoLaunchStatsWindowCheckbox;
        private Button openStatsWindowButton;
        private CheckBox autoLaunchNotificationsWindowCheckbox;
        private Button openAlertsWindowButton;
        private Label timerStatusLabel;
        private PictureBox raConnectionStatusPictureBox;
        private Label label33;
        private Label focusAchievementDescriptionLabel;
        private PictureBox focusAchievementPictureBox;
        private Label focusAchievementTitleLabel;
        private Button customizeFocusButton;
        private Button customizeStatsButton;
        private Button customizeAlertsButton;
        private GroupBox groupBox1;
        private Button customizeGameButton;
        private CheckBox autoLaunchGameInfoWindowCheckbox;
        private Button openGameInfoWindowButton;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button customizeLastFiveButton;
        private CheckBox autoLaunchLastFiveWindowCheckbox;
        private Button openLastFiveWindowButton;
        private GroupBox groupBox4;
        private CheckBox lastFiveStreamLabelsCheckBox;
        private CheckBox gameInfoStreamLabelsCheckBox;
        private CheckBox statsStreamLabelsCheckBox;
        private TextBox statsGameRatioOverrideTextBox;
        private TextBox statsTruePointsOverrideTextBox;
        private TextBox statsPointsOverrideTextBox;
        private TextBox statsRatioOverrideTextBox;
        private TextBox statsAwardsOverrideTextBox;
        private TextBox statsRankOverrideTextBox;
        private GroupBox statsOverrideGroupBox;
        private ComboBox fontFamilyComboBox;
        private Button setBackgroundColorButton;
        private PictureBox backgroundColorPictureBox;
        private Label backgroundColorLabel;
        private NumericUpDown fontOutlineNumericUpDown;
        private CheckBox fontOutlineCheckBox;
        private Button fontOutlineColorButton;
        private PictureBox fontOutlineColorPictureBox;
        private Button setFontColorButton;
        private PictureBox fontColorPictureBox;
        private Label fontColorLabel;
        private GroupBox fontSettingsGroupBox;
        private Label label9;
        private Label label10;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private NumericUpDown inAchievementNumericUpDown;
        private Label inLabel1;
        private NumericUpDown outAchievementNumericUpDown;
        private Button selectCustomAchievementButton;
        private Label outLabel1;
        private Label scaleLabel1;
        private NumericUpDown scaleAchievementNumericUpDown;
        private Label yPositionLabel1;
        private Label xPositionLabel1;
        private NumericUpDown customAchievementYNumericUpDown;
        private NumericUpDown customAchievementXNumericUpDown;
        private CheckBox useCustomAchievementCheckbox;
        private Button showAchievementButton;
        private GroupBox customAchievementSettingsGroupBox;
        private Label label16;
        private ComboBox comboBox4;
        private Label label17;
        private NumericUpDown inMasteryNumericUpDown;
        private ComboBox comboBox5;
        private Label inLabel2;
        private NumericUpDown outMasteryNumericUpDown;
        private Button selectCustomMasteryNotificationButton;
        private Label outLabel2;
        private Label scaleLabel2;
        private NumericUpDown scaleMasteryNumericUpDown;
        private Label yPositionLabel2;
        private Label xPositionLabel2;
        private NumericUpDown customMasteryYNumericUpDown;
        private NumericUpDown customMasteryXNumericUpDown;
        private CheckBox useCustomMasteryCheckbox;
        private Button showGameMasteryButton;
        private GroupBox customMasterySettingsGroupBox;
        private Button hideButton;
        private GroupBox gameInfoOverrideSettingsGroupBox;
        private TextBox statsGameTruePointsOverrideTextBox;
        private TextBox statsGamePointsOverrideTextBox;
        private TextBox statsGameAchievementsOverrideTextBox;
        private GroupBox lastFiveOverridesGroupBox;
        private Button setFocusButton;
        private Button focusAchievementButtonRight;
        private Button hideFocusButton;
        private Button focusAchievementButtonLeft;
        private Label ratioLabel;
        private CheckBox focusStreamLabelsCheckBox;
        private CheckBox alertsStreamLabelsCheckBox;
        private Label truePointsLabel;
        private Label label27;
        private ComboBox comboBox6;
        private OpenFileDialog openFileDialog1;
        private ColorDialog colorDialog1;
        private CheckBox acheivementEditOutlineCheckbox;
        private CheckBox masteryEditOultineCheckbox;
        private TextBox gameInfoGenreOverrideTextBox;
        private TextBox gameInfoConsoleOverrideTextBox;
        private TextBox gameInfoPublisherOverrideTextBox;
        private TextBox gameInfoReleaseDateOverrideTextBox;
        private TextBox gameInfoDeveloperOverrideTextBox;
        private Button statsDefaultButton;
        private Button gameInfoDefaultButton;
        private CheckBox lastFiveVerboseCheckbox;
        private CheckBox lastFiveSimpleCheckbox;
        private CheckBox statsGameAchievementsCheckBox;
        private CheckBox statsGameTruePointsCheckBox;
        private CheckBox statsGamePointsCheckBox;
        private CheckBox statsGameRatioCheckBox;
        private CheckBox statsRatioCheckBox;
        private CheckBox statsTruePointsCheckBox;
        private CheckBox statsPointsCheckBox;
        private CheckBox statsAwardsCheckBox;
        private CheckBox statsRankCheckBox;
        private CheckBox gameInfoReleaseDateCheckBox;
        private CheckBox gameInfoGenreCheckBox;
        private CheckBox gameInfoPublisherCheckBox;
        private CheckBox gameInfoDeveloperCheckBox;
        private CheckBox gameInfoConsoleCheckBox;
        private CheckBox gameInfoBoxArtCheckbox;
        private CheckBox gameInfoTitleCheckBox;
        private TextBox gameInfoTitleOverrideTextBox;
    }
}

