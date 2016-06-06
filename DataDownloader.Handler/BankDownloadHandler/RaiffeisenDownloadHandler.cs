﻿using System.Collections.ObjectModel;
using System.IO;
using System.Security;
using DataDownloader.Common.Properties;
using DataDownloader.Common.Settings;
using DataDownloader.Handler.Selenium;
using KeePass;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace DataDownloader.Handler.BankDownloadHandler
{

    public class RaiffeisenDownloadHandler : BankDownloadHandlerBase
    {
        public RaiffeisenDownloadHandler(string password) : base(password, "https://banking.raiffeisen.at", Path.Combine(SettingHandler.Default.DataDownloaderPath, SettingHandler.Default.DataDownloaderSubfolderRaiffeisen))
        {
        }

        public RaiffeisenDownloadHandler(SecureString password) : base(password, "https://banking.raiffeisen.at", Path.Combine(SettingHandler.Default.DataDownloaderPath, SettingHandler.Default.DataDownloaderSubfolderRaiffeisen))
        {
        }

        protected override void Login()
        {
            var entry = KeePass.GetEntryByUuid(SettingHandler.Default.KeePassEntryUuidRaiffeisen);

            //change to username login
            Browser.FindElement(By.Id("j_id280:benutzer")).Click();

            //type username
            Browser.FindElement(new ByIdOrName("loginform:LOGINNAME")).SendKeys(entry.GetUserName());

            //type password
            Browser.FindElement(new ByIdOrName("loginform:LOGINPASSWD")).SendKeys(entry.GetPassword());

            //check pass
            Browser.FindElement(new ByIdOrName("loginform:checkPasswort")).Click();

            //type pin
            Browser.FindElement(new ByIdOrName("loginpinform:PIN")).SendKeys(entry.GetString("PIN"));

            //final login
            Browser.FindElement(new ByIdOrName("loginpinform:anmeldenPIN")).Click();
        }

        protected override void Logout()
        {
            Browser.FindElement(new ByAll(By.ClassName("button"), By.ClassName("logoutlink"))).Click();
        }

        protected override void NavigateHome()
        {
            Browser.FindElement(new ByChained(By.Id("nav"), By.TagName("ul"), By.TagName("li"), By.TagName("a"))).Click();
        }

        protected override void Download()
        {
            var allAccountLinks = GetAccountLinks();
            for (int i = 0; i < allAccountLinks.Count; i++)
            {
                allAccountLinks = GetAccountLinks();
                var accountNumber = allAccountLinks[i].Text;
                allAccountLinks[i].Click();
                SetMaxDateRange();
                DownloadCsv(accountNumber);
                NavigateHome();
            }
        }

        private void DownloadCsv(string filePrefix = null)
        {
            //*[@id="j_id1_kontoinfo_WAR_kontoinfoportlet_INSTANCE_9k3Y_:umsaetzeForm"]/div[3]/div[1]/div/a
            Browser.FindElement(
                new ByChained(By.ClassName("serviceButtonArea"),
                    new ByAll(By.ClassName("formControlButton"), By.ClassName("print")))).Click();

            var combo = new SelectElement(Browser.FindElement(
                new ByChained(By.ClassName("mainInput"), By.ClassName("inputLarge"))));
            combo.SelectByValue("CSV");

            var link =
                Browser.FindElement(
                    new ByChained(By.ClassName("formFooterRight"),
                    new ByAll(By.ClassName("button"), By.ClassName("button-colored"))));
            FileDownloader.DownloadFile(link, fileOtherPrefix: filePrefix);
        }

        private void SetMaxDateRange()
        {
            Browser.FindElement(By.Id("kontoauswahlSelectionToggleLink")).Click();

            var month = new SelectElement(Browser.FindElement(
                By.Id("j_id1_kontoinfo_WAR_kontoinfoportlet_INSTANCE_9k3Y_:umsaetzeForm:kontoauswahlDatumVon-month-year")
                    .Or(new ByChained(By.Id("kontoauswahlSelectionExtended"), By.ClassName("float-left"),
                        By.ClassName("cal-month-year")))));
            month.SelectByIndex(0);

            var day = new SelectElement(Browser.FindElement(
                By.Id("j_id1_kontoinfo_WAR_kontoinfoportlet_INSTANCE_9k3Y_:umsaetzeForm:kontoauswahlDatumVon-day")
                    .Or(new ByChained(By.Id("kontoauswahlSelectionExtended"), By.ClassName("float-left"),
                        By.ClassName("cal-day")))));
            day.SelectByIndex(0);

            Browser.FindElement(new ByChained(By.ClassName("boxFormFooter"),
                new ByAll(By.ClassName("button"), By.ClassName("button-colored")))).Click();
        }

        private ReadOnlyCollection<IWebElement> GetAccountLinks()
        {
            return Browser.FindElements(
                new ByChained(
                    By.ClassName("kontoTable"),
                    By.TagName("tbody"),
                    By.TagName("tr"),
                    By.XPath("td[1]"),
                    By.TagName("a")
                    ));
        }
    }
}