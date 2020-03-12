using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;


namespace ReportFromShabInPdf
{
    public class Parser
    {
        WebClient wc;
        List<Report> reports;
        string url { get; set; }
        string UriPdfLink { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }

        ReportFromShabInPdf.Logic.Directory directory { get; set; }

        string SaveFiles { get; set; } 

        public Parser(string DateStart, string DateEnd)
        {
            wc = new WebClient();
            this.DateStart = DateStart;
            this.DateEnd = DateEnd;
            this.reports = new List<Report>();
            UriPdfLink = "https://www.shab.ch/edoras/rest/file/";
            this.directory = new Logic.Directory();

        }

        public void DonloadPage()
        {
            this.url = $"https://www.shab.ch/api/v1/publications?allowRubricSelection=false&includeContent=false&keyword=invitation&pageRequest.page=0" +
                $"&pageRequest.size=100&publicationDate.end={this.DateEnd}&publicationDate.start={this.DateStart}&publicationStates=PUBLISHED&publicationStates=CANCELLED" +
                $"&rubrics=AB&rubrics=AW&rubrics=AZ&rubrics=BB&rubrics=BH&rubrics=EK&rubrics=ES&rubrics=FM&rubrics=HR&rubrics=KK&rubrics=LS&rubrics=NA&rubrics=SB&rubrics=SR&rubrics=UP&rubrics=UV&searchPeriod=CUSTOM";
            string str = wc.DownloadString(url);

            dynamic json = JObject.Parse(str);

            List<Report> reports = new List<Report>();
            Report.Total = json.total;
            for (int i = 0; i < Report.Total; i++)
            {
                string filenameId = "";
                try
                { filenameId = json.content[i].attachments[0].fileId; }
                catch (Exception)
                {
                    continue;
                }
                string NameReport = json.content[i].meta.title.en;
                DateTime publicationDate = json.content[i].meta.publicationDate;
                
                this.reports.Add(new Report(NameReport, filenameId, publicationDate));
            }
        }

        public void DonloadFilePdf()
        {
            this.SaveFiles = directory.CreateFolder(this.DateStart, this.DateEnd);
            
            for (int i = 0; i < this.reports.Count; i++)
            {
                wc.DownloadFile(new Uri(UriPdfLink + reports[i].filenameId), $"{this.SaveFiles}\\{this.reports[i].NameReport}.pdf");
            }
        }

     
    }
}
