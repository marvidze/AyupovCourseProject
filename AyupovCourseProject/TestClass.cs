using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyupovCourseProject
{
    public class Document
    {
        public int Id { get; private set; }
        public string Title { get; set; }
        public string SenderName { get; set; }
        public string ReceiptDate { get; set; }
        public string DocumentTopic { get; set; }
        public string DocumentContent { get; set; }
        public string Name { get; set; }

        private static int countOfObjects = 0;
        public Document() 
        {
            this.Id = countOfObjects;
            countOfObjects++;
        }
        public Document(string title, string senderName, string receiptDate, string documentTopic, string documentContent) 
        {
            this.Title = title;
            this.SenderName = senderName;
            this.ReceiptDate = receiptDate;
            this.DocumentTopic = documentTopic;
            this.DocumentContent = documentContent;
        }

        public override string ToString()
        {
            return Name;
        }
        
    }
}
