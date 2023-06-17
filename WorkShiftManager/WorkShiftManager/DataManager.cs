using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkShiftManager
{
    public class DataManager
    {
        public static void SaveData(string data, string fileName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write(data);
                }
                Console.WriteLine("Datele au fost salvate cu succes în fișierul {0}.", fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la salvarea datelor: {0}", ex.Message);
            }
        }

        public static string LoadData(string fileName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string data = reader.ReadToEnd();
                    Console.WriteLine("Datele au fost încărcate cu succes din fișierul {0}.", fileName);
                    return data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la încărcarea datelor: {0}", ex.Message);
                return null;
            }
        }
    }
}