using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{

    public class File_demo
    {
        public void Write()
        {
            FileInfo fileInfo = new FileInfo(@"C:\Users\ei13113\Desktop\karthik\Technical_Training\Files\Table.txt");
            FileStream fs = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite,FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(fs);
       
            try
            {
                writer.WriteLine("Welcome to Tables from 1 - 10");
                writer.WriteLine("--------------------------------------");
                int multi;
                for (int i = 1; i < 11; i++)
                {
                    for (int j = 1; j < 11; j++)
                    {
                        multi = i * j;
                        writer.WriteLine($"{i}*{j}={multi}");
                    }
                    writer.WriteLine("-------------------");
                }
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                writer.Close();
                fs.Close();
            }
            
        }
        
        public void Read()
        {
            FileInfo fileInfo = new FileInfo(@"C:\Users\ei13113\Desktop\karthik\Technical_Training\Files\Table.txt");
            FileStream fs = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(fs);

            try
            {
                String Multi_tables=reader.ReadToEnd();
                Console.WriteLine(Multi_tables);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                reader.Close();
                fs.Close();
            }
        }
    }

    internal class File_multitable
    {
        public static void Main()
        {
           File_demo demo = new File_demo();
            demo.Write();
            demo.Read();
        }
    }
}
