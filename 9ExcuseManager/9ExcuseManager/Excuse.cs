using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _9ExcuseManager
{
    class Excuse
    {
        public string description;
        public string results;
        public DateTime lastused;
        public string excusepath;
        public Excuse(Random random, string Excusepath)
        {
            string[] fileNames = Directory.GetFiles(Excusepath);
            Open(fileNames[random.Next(fileNames.Length)]);

        }
        public Excuse() { excusepath = ""; }
        public Excuse(string Excusepath)
        { 
            Open(Excusepath);
        }
        public void Open(string FileName)
        {
            this.excusepath = FileName;
            //way1:classical 
            //StreamReader myReader = new StreamReader(FileName);
            //this.description = myReader.ReadLine();
            //this.results = myReader.ReadLine();
            //this.lastused = Convert.ToDateTime(myReader.ReadLine());
            //myReader.Close();
            //way2:Avoid file system errors with using statement
            using (StreamReader myReader = new StreamReader(FileName))
            {
                this.description = myReader.ReadLine();
                this.results = myReader.ReadLine();
                this.lastused = Convert.ToDateTime(myReader.ReadLine());
            }
        }
        public void Save(string FileName)
        {
            this.excusepath = FileName;
            //way1:classical
            //StreamWriter myWriter = new StreamWriter(@FileName,false);
            //myWriter.WriteLine(this.description);
            //myWriter.WriteLine(this.results);
            //myWriter.WriteLine(this.lastused);
            //myWriter.Close();
            //way2:Avoid file system errors with using statement
            using (StreamWriter myWriter = new StreamWriter(FileName))
            {
                myWriter.WriteLine(this.description);
                myWriter.WriteLine(this.results);
                myWriter.WriteLine(this.lastused);
            }

        }

    }
}
