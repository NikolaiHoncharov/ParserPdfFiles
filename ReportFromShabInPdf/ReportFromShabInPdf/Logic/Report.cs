using System;

namespace ReportFromShabInPdf
{
    public class Report
    {
        public static int Total { get; set; }
        public string NameReport { get; set; }
        public string filenameId { get; set; }
        public string publicationDate { get; set; }

        public Report(string NameReport, string filenameId, DateTime publicationDate)
        {
            this.publicationDate = publicationDate.ToShortDateString();
            this.filenameId = filenameId;
            //
            int ind = NameReport.IndexOf("extraordinary");
            if(ind>=0)
            {
               NameReport = NameReport.Substring(ind).Replace("general meeting", "GM");
            }
            else
            {
                int in2 = NameReport.IndexOf("ordinary");
                if (in2 >= 0)
                {
                    NameReport = NameReport.Substring(in2).Replace("general meeting", "GM");
                }
            }
            this.NameReport = (this.publicationDate + '_' + NameReport).Replace(' ', '_');

        }
    }
}
