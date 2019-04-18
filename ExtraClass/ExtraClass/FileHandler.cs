using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ExtraClass
{
    class FileHandler
    {
        FileStream fs; //global declare the filestream

        //method to check if the file exists
        public void Exist(string filename)
        {
            if (!File.Exists(filename)) //Creates the file if it does not exist
            {
                fs = new FileStream(filename, FileMode.Create);
                fs.Close();
                MessageBox.Show("File created");
            }
        }

        //Method that reads from the text file
        public List<string> Read(string filename)
        {
            Exist(filename); //check if file exists
            fs = new FileStream(filename, FileMode.Open, FileAccess.Read); //opening the file stream
            StreamReader sr = new StreamReader(fs); //reading stream
            List<string> lines = new List<string>(); //list to hold the iems from the file
            try
            {
                while (!sr.EndOfStream) //items are added to the list until the last line in the file is read
	             {
	                lines.Add(sr.ReadLine());
	             }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            finally
            {
                sr.Close(); //cloing the stream reader first!!!
                fs.Close(); // closing the file stream
            }
            
            return lines; //returning the list
        }
        public void Write(string filename, List<string> lines, bool x) // method for writing to the file
        {
            Exist(filename); //check that the file exists 
            if (x) //writing to the file to replace the data
               fs =new FileStream(filename, FileMode.Open, FileAccess.Write); //open the file stream
            else  //writing to the file to add to existing data
                fs =new FileStream(filename, FileMode.Append, FileAccess.Write); //open the file stream

            StreamWriter sw = new StreamWriter(fs); //open the stream writer

            try
            {
                foreach (string item in lines) //writing to the file
                {
                    sw.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sw.Close(); //close the stream writer first!!!
                fs.Close(); // close the file stream
            }
            

        }
    }
}
