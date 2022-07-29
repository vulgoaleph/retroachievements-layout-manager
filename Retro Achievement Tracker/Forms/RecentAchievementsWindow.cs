﻿using CefSharp;
using CefSharp.Web;
using Retro_Achievement_Tracker.Controllers;
using Retro_Achievement_Tracker.Models;
using Retro_Achievement_Tracker.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retro_Achievement_Tracker
{
    public partial class RecentAchievementsWindow : Form
    {
        private TaskController TaskController;
        public RecentAchievementsWindow()
        {
            ClientSize = new Size(0, 0);

            Name = "RA Tracker - Recent Achievements";
            Text = "RA Tracker - Recent Achievements";

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));

            Shown += RecentAchievementsWindow_Shown;
            FormClosed += RecentAchievementsWindow_FormClosed;

            TaskController = new TaskController();

            SetupBrowser();
        }

        private void RecentAchievementsWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            RecentAchievementsController.Instance.IsOpen = false;
        }
        private void RecentAchievementsWindow_Shown(object sender, EventArgs e)
        {
            
        }

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }
        public async void AssignJavaScriptVariables()
        {
            await TaskController.Enqueue(() => ExecuteScript(
                "container = document.getElementById(\"container\");" +
                "achievementList = document.getElementById(\"achievement-list\");" +
                "allElements = document.getElementsByClassName(\"has-font\");" +
                "allTitles = document.getElementsByClassName(\"title\");" +
                "allDates = document.getElementsByClassName(\"date\");" +
                "allLines = document.getElementsByClassName(\"line\");" +
                "allPoints = document.getElementsByClassName(\"points\");" +
                "allAchievements = document.getElementsByClassName(\"achievement\");"));
        }
        public async void SetSimpleFontColor(string value)
        {
            await TaskController.Enqueue(() => ExecuteScript(
                "for (var i = 0; i < allElements.length; i++) { allElements[i].style.color = \"" + value + "\"; }" +
                "for (var i = 0; i < allLines.length; i++) { allLines[i].style.color = \"" + value + "\"; }" +
                "for (var i = 0; i < allLines.length; i++) { allLines[i].style.backgroundColor = \"" + value + "\"; }"));
        }
        public async void SetSimpleFontFamily(FontFamily value)
        {
            int lineSpacing = value.GetLineSpacing(FontStyle.Regular) / value.GetEmHeight(FontStyle.Regular);

            string script = "for (var i = 0; i < allElements.length; i++) { " +
                "   allElements[i].style.lineHeight = " + (lineSpacing == 0 ? 1 : lineSpacing) + ";" +
                "   allElements[i].style.fontFamily = \"" + value.Name.Replace(":", "\\:") + "\";" +
                "}" +
                "for (var i = 0; i < allTitles.length; i++) { " +
                "   textFit(allTitles[i], { alignVert: true , alignHoriz: true, multiLine: true, reProcess: true });" +
                "}" +
                "for (var i = 0; i < allDates.length; i++) { " +
                "   textFit(allDates[i], { alignVert: true , alignHoriz: true, multiLine: true, reProcess: true });" +
                "}" +
                "for (var i = 0; i < allPoints.length; i++) { " +
                "   textFit(allPoints[i], { reProcess: true });" +
                "}";

            await TaskController.Enqueue(() => ExecuteScript(script));
        }

        public async void SetSimpleFontOutline(string fontOutline, string borderOutline)
        {
            await TaskController.Enqueue(() => ExecuteScript(
                 "for (var i = 0; i < allElements.length; i++) { allElements[i].style.webkitTextStroke = \"" + fontOutline + "\"; }" +
                 "for (var i = 0; i < allLines.length; i++) { allLines[i].style.border = \"" + borderOutline + "\"; }"));
        }

        public async void SetBackgroundColor(string value)
        {
            await TaskController.Enqueue(() => ExecuteScript("for (var i = 0; i < allAchievements.length; i++) { allAchievements[i].style.backgroundColor = \"" + value + "\"; }"));
        }
        public async void SetWindowBackgroundColor(string value)
        {
            await TaskController.Enqueue(() => ExecuteScript("container.style.backgroundColor = \"" + value + "\";"));
        }
        public async void EnableBorder()
        {
            await TaskController.Enqueue(() => ExecuteScript("for (var i = 0; i < allAchievements.length; i++) { allAchievements[i].style.backgroundImage = \"url('disk://background')\"; }"));
        }
        public async void DisableBorder()
        {
            await TaskController.Enqueue(() => ExecuteScript("for (var i = 0; i < allAchievements.length; i++) { allAchievements[i].style.backgroundImage = \"\"; }"));
        }
        public async void SetTitleFontFamily(FontFamily value)
        {
            int lineSpacing = value.GetLineSpacing(FontStyle.Regular) / value.GetEmHeight(FontStyle.Regular);
            await TaskController.Enqueue(() => ExecuteScript(
                "for (var i = 0; i < allTitles.length; i++) { " +
                "   allTitles[i].style.lineHeight = " + (lineSpacing == 0 ? 1 : lineSpacing) + ";" +
                "   allTitles[i].style.fontFamily = \"" + value.Name.Replace(":", "\\:") + "\";" +
                "   textFit(allTitles[i], { alignVert: true, alignHoriz: true, multiLine: true, reProcess: true });" +
                "}"));
        }
        public async void SetDateFontFamily(FontFamily value)
        {
            int lineSpacing = value.GetLineSpacing(FontStyle.Regular) / value.GetEmHeight(FontStyle.Regular);
            await TaskController.Enqueue(() => ExecuteScript(
                "for (var i = 0; i < allDates.length; i++) { " +
                "   allDates[i].style.lineHeight = " + (lineSpacing == 0 ? 1 : lineSpacing) + ";" +
                "   allDates[i].style.fontFamily = \"" + value.Name.Replace(":", "\\:") + "\";" +
                "   textFit(allDates[i], { alignVert: true, alignHoriz: true, multiLine: true, reProcess: true });" +
                "}"));
        }

        public async void SetPointsFontFamily(FontFamily value)
        {
            int lineSpacing = value.GetLineSpacing(FontStyle.Regular) / value.GetEmHeight(FontStyle.Regular);
            await TaskController.Enqueue(() => ExecuteScript(
                "for (var i = 0; i < allPoints.length; i++) { " +
                "   allPoints[i].style.lineHeight = " + (lineSpacing == 0 ? 1 : lineSpacing) + ";" +
                "   allPoints[i].style.fontFamily = \"" + value.Name.Replace(":", "\\:") + "\";" +
                "   textFit(allPoints[i], { reProcess: true });" +
                "}"));
        }

        public async void SetTitleColor(string value)
        {
            await TaskController.Enqueue(() => ExecuteScript("for (var i = 0; i < allTitles.length; i++) { allTitles[i].style.color = \"" + value + "\"; }"));
        }

        public async void SetDateColor(string value)
        {
            await TaskController.Enqueue(() => ExecuteScript("for (var i = 0; i < allDates.length; i++) { allDates[i].style.color = \"" + value + "\"; }"));
        }

        public async void SetPointsColor(string value)
        {
            await TaskController.Enqueue(() => ExecuteScript("for (var i = 0; i < allPoints.length; i++) { allPoints[i].style.color = \"" + value + "\"; }"));
        }
        public async void SetLineColor(string value)
        {
            await TaskController.Enqueue(() => ExecuteScript("for (var i = 0; i < allLines.length; i++) { allLines[i].style.color = \"" + value + "\"; allLines[i].style.backgroundColor = \"" + value + "\"; }"));
        }
        public async void SetTitleOutline(string value)
        {
            await TaskController.Enqueue(() => ExecuteScript("for (var i = 0; i < allTitles.length; i++) { allTitles[i].style.webkitTextStroke = \"" + value + "\"; textFit(allTitles[i], { alignVert: true, alignHoriz: true, multiLine: true, reProcess: true }); }"));
        }
        public async void SetDateOutline(string value)
        {
            await TaskController.Enqueue(() => ExecuteScript("for (var i = 0; i < allDates.length; i++) { allDates[i].style.webkitTextStroke = \"" + value + "\"; textFit(allDates[i], { alignVert: true, alignHoriz: true, multiLine: true, reProcess: true }); }"));
        }
        public async void SetPointsOutline(string value)
        {
            await TaskController.Enqueue(() => ExecuteScript("for (var i = 0; i < allPoints.length; i++) { allPoints[i].style.webkitTextStroke = \"" + value + "\"; textFit(allPoints[i], { reProcess: true }); }"));
        }
        public async void SetLineOutline(string value)
        {
            await TaskController.Enqueue(() => ExecuteScript("for (var i = 0; i < allLines.length; i++) { allLines[i].style.border = \"" + value + "\"; }"));
        }
        public async void StartScrolling()
        {
            await TaskController.Enqueue(() => ExecuteScript("startScrolling();"));
        }
        public async void AddAchievements(List<Achievement> achievements)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < achievements.Count; i++)
            {
                stringBuilder.Append(
                    "var achievementBlock = document.createElement('div');" +
                    "achievementBlock.classList.add(\"achievement\");" +
                    "achievementBlock.id = \"achievement-" + achievements[i].Id + "\";" +
                    "if (achievementList.childNodes.length > 0) { achievementList.insertBefore(achievementBlock, achievementList.childNodes[0]); } else { achievementList.appendChild(achievementBlock); }" +

                    "var achievementImage = document.createElement('img');" +
                    "achievementImage.id = \"achievement-" + achievements[i].Id + "-image\";" +
                    "achievementImage.classList.add(\"badge\");" +
                    "achievementImage.src = \"https://s3-eu-west-1.amazonaws.com/i.retroachievements.org/Badge/" + achievements[i].BadgeNumber + ".png\";" +
                    "achievementImage.style.border = \"2px solid gold\";" +
                    "achievementBlock.appendChild(achievementImage);" +

                    "var achievementTitleBlock = document.createElement('div');" +
                    "achievementTitleBlock.innerHTML = \"" + achievements[i].Title + "\";" +
                    "achievementTitleBlock.classList.add(\"title\");" +
                    "achievementTitleBlock.classList.add(\"has-font\");" +
                    "achievementTitleBlock.style.zIndex = 1;" +
                    "achievementBlock.appendChild(achievementTitleBlock);" +

                    "var achievementLineBlock = document.createElement('hr');" +
                    "achievementLineBlock.classList.add(\"line\");" +
                    "achievementBlock.appendChild(achievementLineBlock);" +

                    "var achievementDateBlock = document.createElement('div');" +
                    "achievementDateBlock.innerHTML = \"" + (achievements[i].DateEarned.HasValue ? achievements[i].DateEarned.Value.ToString() : "") + "\";" +
                    "achievementDateBlock.classList.add(\"date\");" +
                    "achievementDateBlock.classList.add(\"has-font\");" +
                    "achievementBlock.appendChild(achievementDateBlock);" +

                    "var achievementPointsBlock = document.createElement('div');" +
                    "achievementPointsBlock.innerHTML = \"" + achievements[i].Points + "\";" +
                    "achievementPointsBlock.classList.add(\"points\");" +
                    "achievementPointsBlock.classList.add(\"has-font\");" +
                    "achievementBlock.appendChild(achievementPointsBlock);");
            }

            await TaskController.Enqueue(() => ExecuteScript(stringBuilder.ToString()));
        }
        public async void ShowRecentAchievements()
        {
            await TaskController.Enqueue(() => ExecuteScript("$(\"#achievement-list\").animate( { left: '0px', top: '0px' }, 500, 'easeInOutQuint');"));
        }
        public async void HideRecentAchievements()
        {
            await TaskController.Enqueue(() => ExecuteScript("stopScrolling(); $(\"#achievement-list\").animate( { left: '535px', top: '0px' }, 500, 'easeInOutQuint');"));
        }
        public async void ClearRecentAchievements()
        {
            await TaskController.Enqueue(() => ExecuteScript("document.getElementById(\"achievement-list\").innerHTML = \"\";"));
        }
        protected async Task ExecuteScript(string script)
        {
            if (chromiumWebBrowser != null)
            {
                try
                {
                    await chromiumWebBrowser.EvaluateScriptAsync(script, TimeSpan.FromSeconds(5));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        public void SetupBrowser()
        {
            Controls.Remove(chromiumWebBrowser);

            chromiumWebBrowser = new CefSharp.WinForms.ChromiumWebBrowser(new HtmlString(Resources.RecentAchievementsWindow))
            {
                ActivateBrowserOnCreation = false,
                Location = new Point(0, 0),
                Name = "chromiumWebBrowser",
                Size = new Size(516, 608),
                TabIndex = 0,
                Dock = DockStyle.None,
                RequestHandler = new CustomRequestHandler()
            };

            chromiumWebBrowser.FrameLoadEnd += new EventHandler<FrameLoadEndEventArgs>((sender, frameLoadEndEventArgs) =>
            {
                Invoke((MethodInvoker)delegate
                {
                    ClientSize = new Size(516, 600); 
                    RecentAchievementsController.Instance.IsOpen = true;
                    RecentAchievementsController.Instance.PopulateRecentAchievementsWindow();
                });
            });

            Controls.Add(chromiumWebBrowser);
        }

        public CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser;
    }
}