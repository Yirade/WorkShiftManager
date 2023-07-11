using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace WorkShiftManager
{
    public class DataManager
    {
        public List<Department> Departments { get; set; }
        public List<Worker> Workers { get; set; }

        public DataManager()
        {
            Departments = new List<Department>();
        }

        public void SaveData(string filename)
        {
            Array daysOfWeek = Enum.GetValues(typeof(DayOfWeek));
            Array reorderedDaysOfWeek = new DayOfWeek[7];
            Array.Copy(daysOfWeek, 1, reorderedDaysOfWeek, 0, 6); // Copia da lunedì a sabato
            reorderedDaysOfWeek.SetValue(DayOfWeek.Sunday, 6); // Imposta la domenica come ultimo giorno

            if (Departments != null)
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlElement root = xmlDoc.CreateElement("Data");
                xmlDoc.AppendChild(root);

                foreach (Department department in Departments)
                {
                    if (department != null)
                    {
                        XmlElement departmentElement = xmlDoc.CreateElement("Department");
                        root.AppendChild(departmentElement);

                        XmlElement nameElement = xmlDoc.CreateElement("DepName");
                        nameElement.InnerText = department.Name;
                        departmentElement.AppendChild(nameElement);

                        if (department.Workers != null)
                        {
                            foreach (Worker worker in department.Workers)
                            {
                                if (worker != null)
                                {
                                    XmlElement workerElement = xmlDoc.CreateElement("Worker");
                                    departmentElement.AppendChild(workerElement);

                                    XmlElement idElement = xmlDoc.CreateElement("Id");
                                    idElement.InnerText = worker.Id.ToString();
                                    workerElement.AppendChild(idElement);

                                    XmlElement workernameElement = xmlDoc.CreateElement("Name");
                                    workernameElement.InnerText = worker.Name;
                                    workerElement.AppendChild(workernameElement);

                                    XmlElement emailElement = xmlDoc.CreateElement("Email");
                                    emailElement.InnerText = worker.Email;
                                    workerElement.AppendChild(emailElement);

                                    // Salva il percorso dell'immagine
                                    XmlElement imageElement = xmlDoc.CreateElement("ProfileImagePath");
                                    imageElement.InnerText = worker.ProfileImagePath;
                                    workerElement.AppendChild(imageElement);

                                    // Aggiungi gli orari di lavoro del lavoratore come elementi XML
                                    XmlElement scheduleElement = xmlDoc.CreateElement("Schedule");
                                    workerElement.AppendChild(scheduleElement);

                                    foreach (KeyValuePair<DayOfWeek, WorkSchedule> schedulePair in worker.Schedule)
                                    {
                                        DayOfWeek dayOfWeek = schedulePair.Key;
                                        WorkSchedule workSchedule = schedulePair.Value;

                                        XmlElement dayElement = xmlDoc.CreateElement(dayOfWeek.ToString());
                                        scheduleElement.AppendChild(dayElement);

                                        if (workSchedule != null)
                                        {
                                            XmlElement startTimeElement = xmlDoc.CreateElement("StartTime");
                                            startTimeElement.InnerText = workSchedule.StartTime.ToString();
                                            dayElement.AppendChild(startTimeElement);

                                            XmlElement endTimeElement = xmlDoc.CreateElement("EndTime");
                                            endTimeElement.InnerText = workSchedule.EndTime.ToString();
                                            dayElement.AppendChild(endTimeElement);
                                        }
                                    }

                                    // Aggiungi altre proprietà del worker come elementi XML
                                }
                            }
                        }
                    }
                }

                xmlDoc.Save(filename);
            }
        }


        // Metodo per caricare i dati da file
        public void LoadData(string filename)
        {
            if (File.Exists(filename))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filename);

                Departments.Clear(); // Rimuove i dipartimenti esistenti prima di caricare nuovi dati

                XmlNodeList departmentNodes = xmlDoc.SelectNodes("//Department");
                foreach (XmlNode departmentNode in departmentNodes)
                {
                    string departmentName = departmentNode.SelectSingleNode("DepName")?.InnerText;
                    if (!string.IsNullOrEmpty(departmentName))
                    {
                        Department department = new Department
                        {
                            Name = departmentName
                        };

                        XmlNodeList workerNodes = departmentNode.SelectNodes("Worker");
                        foreach (XmlNode workerNode in workerNodes)
                        {
                            int workerId = int.Parse(workerNode.SelectSingleNode("Id")?.InnerText);
                            string workerName = workerNode.SelectSingleNode("Name")?.InnerText;
                            string profileImagePath = workerNode.SelectSingleNode("ProfileImagePath")?.InnerText;
                            string email = workerNode.SelectSingleNode("Email")?.InnerText;

                            // Carica le schedule del worker
                            XmlNode scheduleNode = workerNode.SelectSingleNode("Schedule");
                            Dictionary<DayOfWeek, WorkSchedule> schedule = new Dictionary<DayOfWeek, WorkSchedule>();

                            foreach (DayOfWeek dayOfWeek in Enum.GetValues(typeof(DayOfWeek)))
                            {
                                XmlNode dayNode = scheduleNode.SelectSingleNode(dayOfWeek.ToString());

                                if (dayNode != null)
                                {
                                    string startTimeString = dayNode.SelectSingleNode("StartTime")?.InnerText;
                                    string endTimeString = dayNode.SelectSingleNode("EndTime")?.InnerText;

                                    TimeSpan startTime;
                                    TimeSpan endTime;

                                    if (TimeSpan.TryParse(startTimeString, out startTime) && TimeSpan.TryParse(endTimeString, out endTime))
                                    {
                                        WorkSchedule workSchedule = new WorkSchedule(startTime, endTime);
                                        schedule.Add(dayOfWeek, workSchedule);
                                    }
                                    else
                                    {
                                        // Errore nella conversione TimeSpan, gestisci l'errore o assegna un valore predefinito
                                    }
                                }
                                else
                                {
                                    // Aggiungi un orario di lavoro vuoto per il giorno se non è specificato nel file
                                    schedule.Add(dayOfWeek, null);
                                }
                            }

                            // Creare un oggetto Worker e impostare le altre proprietà se necessario
                            Worker worker = new Worker
                            {
                                Id = workerId,
                                Name = workerName,
                                ProfileImagePath = profileImagePath,
                                Department = departmentName,
                                Email = email,
                                Schedule = schedule
                            };

                            department.Workers.Add(worker);
                        }

                        Departments.Add(department);
                    }
                }
            }
        }



        public void RemoveWorker(int workerId)
        {
            foreach (Department department in Departments)
            {
                Worker workerToRemove = department.Workers.FirstOrDefault(w => w.Id == workerId);
                if (workerToRemove != null)
                {
                    department.Workers.Remove(workerToRemove);
                    break; // Esci dal ciclo una volta che il lavoratore è stato trovato e rimosso
                }
            }
        }

        public void EditWorker(int workerId, string newName, string newEmail, string newProfileImagePath, string newDepartment)
        {
            foreach (Department department in Departments)
            {
                Worker workerToEdit = department.Workers.FirstOrDefault(w => w.Id == workerId);
                if (workerToEdit != null)
                {
                    // Modifica le proprietà del lavoratore
                    workerToEdit.Name = newName;
                    workerToEdit.ProfileImagePath = newProfileImagePath;
                    workerToEdit.Department = newDepartment;
                    workerToEdit.Email = newEmail;
                    break; // Esci dal ciclo una volta che il lavoratore è stato trovato ed editato
                }
            }
        }

        public void DeleteDepartment(string departmentName)
        {
            Department departmentToDelete = Departments.FirstOrDefault(d => d.Name == departmentName);
            if (departmentToDelete != null)
            {
                Departments.Remove(departmentToDelete);
            }
        }

        public int GetWorkerCountInDepartment(string departmentName)
        {
            Department department = Departments.FirstOrDefault(d => d.Name == departmentName);
            if (department != null)
            {
                return department.Workers.Count;
            }
            return 0;
        }

        public void ModifyDepartmentName(string departmentName, string newName)
        {
            Department department = Globals.DataManager.Departments.FirstOrDefault(d => d.Name == departmentName);

            if (department != null)
            {
                // Modifica il nome del dipartimento
                department.Name = newName;

                // Aggiorna il nome del dipartimento per tutti i lavoratori associati
                foreach (Worker worker in department.Workers)
                {
                    worker.Department = newName;
                }

                // Salva i dati aggiornati
                Globals.DataManager.SaveData("data.xml");
            }
            else
            {
                //MessageBox.Show("Department not found.");
            }
        }

        public Worker GetWorkerById(int workerId)
        {
            foreach (Department department in Departments)
            {
                Worker worker = department.Workers.FirstOrDefault(w => w.Id == workerId);
                if (worker != null)
                {
                    return worker; // Restituisci il lavoratore se trovato
                }
            }

            return null; // Lavoratore non trovato
        }

        public void AddData(string filename)
        {
            // Carica i dati dal file XML
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filename);

            // Ottieni l'elemento radice del file XML
            XmlElement root = xmlDoc.DocumentElement;

            // Verifica se il file XML contiene dati
            if (root.HasChildNodes)
            {
                // Aggiungi i dipartimenti e i workers al DataManager corrente
                foreach (XmlElement departmentElement in root.ChildNodes)
                {
                    // Leggi il nome del dipartimento
                    string departmentName = departmentElement.SelectSingleNode("DepName").InnerText;

                    // Verifica se il dipartimento esiste già nel DataManager corrente
                    Department existingDepartment = Departments.Find(d => d.Name == departmentName);

                    if (existingDepartment != null)
                    {
                        // Il dipartimento esiste già, aggiungi i worker a quel dipartimento
                        if (departmentElement.SelectSingleNode("Workers") != null)
                        {
                            foreach (XmlElement workerElement in departmentElement.SelectSingleNode("Workers").ChildNodes)
                            {
                                // Crea un nuovo oggetto Worker
                                Worker worker = new Worker();

                                // Leggi le informazioni del worker
                                //worker.Id = int.Parse(workerElement.SelectSingleNode("Id").InnerText);
                                worker.Name = workerElement.SelectSingleNode("Name").InnerText;
                                worker.Email = workerElement.SelectSingleNode("Email").InnerText;
                                worker.ProfileImagePath = workerElement.SelectSingleNode("ProfileImagePath").InnerText;

                                // Carica le schedule del worker
                                if (workerElement.SelectSingleNode("Schedule") != null)
                                {
                                    foreach (XmlElement scheduleElement in workerElement.SelectSingleNode("Schedule").ChildNodes)
                                    {
                                        DayOfWeek dayOfWeek;
                                        if (Enum.TryParse(scheduleElement.Name, out dayOfWeek))
                                        {
                                            WorkSchedule workSchedule = new WorkSchedule();

                                            // Leggi l'orario di inizio
                                            if (scheduleElement.SelectSingleNode("StartTime") != null)
                                            {
                                                TimeSpan startTime;
                                                if (TimeSpan.TryParse(scheduleElement.SelectSingleNode("StartTime").InnerText, out startTime))
                                                {
                                                    workSchedule.StartTime = startTime;
                                                }
                                            }

                                            // Leggi l'orario di fine
                                            if (scheduleElement.SelectSingleNode("EndTime") != null)
                                            {
                                                TimeSpan endTime;
                                                if (TimeSpan.TryParse(scheduleElement.SelectSingleNode("EndTime").InnerText, out endTime))
                                                {
                                                    workSchedule.EndTime = endTime;
                                                }
                                            }

                                            // Aggiungi la schedule al worker
                                            worker.Schedule.Add(dayOfWeek, workSchedule);
                                        }
                                    }
                                }

                                // Aggiungi il worker al dipartimento esistente
                                existingDepartment.Workers.Add(worker);
                            }
                        }
                    }
                    else
                    {
                        // Il dipartimento non esiste, crea un nuovo dipartimento e aggiungi i worker
                        Department department = new Department();
                        department.Name = departmentName;

                        if (departmentElement.SelectSingleNode("Workers") != null)
                        {
                            foreach (XmlElement workerElement in departmentElement.SelectSingleNode("Workers").ChildNodes)
                            {
                                // Crea un nuovo oggetto Worker
                                Worker worker = new Worker();

                                // Leggi le informazioni del worker
                                //worker.Id = int.Parse(workerElement.SelectSingleNode("Id").InnerText);
                                worker.Name = workerElement.SelectSingleNode("Name").InnerText;
                                worker.Email = workerElement.SelectSingleNode("Email").InnerText;
                                worker.ProfileImagePath = workerElement.SelectSingleNode("ProfileImagePath").InnerText;

                                // Carica le schedule del worker
                                if (workerElement.SelectSingleNode("Schedule") != null)
                                {
                                    foreach (XmlElement scheduleElement in workerElement.SelectSingleNode("Schedule").ChildNodes)
                                    {
                                        DayOfWeek dayOfWeek;
                                        if (Enum.TryParse(scheduleElement.Name, out dayOfWeek))
                                        {
                                            WorkSchedule workSchedule = new WorkSchedule();

                                            // Leggi l'orario di inizio
                                            if (scheduleElement.SelectSingleNode("StartTime") != null)
                                            {
                                                TimeSpan startTime;
                                                if (TimeSpan.TryParse(scheduleElement.SelectSingleNode("StartTime").InnerText, out startTime))
                                                {
                                                    workSchedule.StartTime = startTime;
                                                }
                                            }

                                            // Leggi l'orario di fine
                                            if (scheduleElement.SelectSingleNode("EndTime") != null)
                                            {
                                                TimeSpan endTime;
                                                if (TimeSpan.TryParse(scheduleElement.SelectSingleNode("EndTime").InnerText, out endTime))
                                                {
                                                    workSchedule.EndTime = endTime;
                                                }
                                            }

                                            // Aggiungi la schedule al worker
                                            worker.Schedule.Add(dayOfWeek, workSchedule);
                                        }
                                    }
                                }

                                // Aggiungi il worker al nuovo dipartimento
                                department.Workers.Add(worker);
                            }
                        }

                        // Aggiungi il nuovo dipartimento al DataManager corrente
                        Departments.Add(department);
                    }
                }
            }
        }

        public void SetWorkerSchedule(int workerId, string dayName, TimeSpan startTime, TimeSpan endTime)
        {
            Worker worker = GetWorkerById(workerId);
            if (worker != null)
            {
                DayOfWeek dayOfWeek;
                if (Enum.TryParse(dayName, out dayOfWeek))
                {
                    // Verifica se il lavoratore ha già un orario di lavoro per il giorno specificato
                    if (worker.Schedule.ContainsKey(dayOfWeek))
                    {
                        // Ottieni l'orario di lavoro esistente per il giorno specificato
                        WorkSchedule workSchedule = worker.Schedule[dayOfWeek];

                        // Aggiorna l'orario di lavoro esistente con i nuovi valori
                        workSchedule.StartTime = startTime;
                        workSchedule.EndTime = endTime;
                    }
                    else
                    {
                        // Crea un nuovo orario di lavoro per il giorno specificato
                        WorkSchedule newWorkSchedule = new WorkSchedule(startTime, endTime);

                        // Aggiungi l'orario di lavoro al lavoratore
                        worker.Schedule.Add(dayOfWeek, newWorkSchedule);
                    }
                }
            }
        }

    }
}
