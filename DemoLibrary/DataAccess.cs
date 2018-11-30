using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using DemoLibrary.Models;

namespace DemoLibrary
{
    public static class DataAccess
    {
        private static string personTextFile = "PersonText.txt";

        public static void AddNewPerson(PersonalModel person)
        {
            person.Id = GetNewId();

            List<PersonalModel> allPersons = GetAllPerson();
            allPersons.Add(person);

            List<string> lines = new List<string>();
            foreach (var item in allPersons)
            {
                lines.Add($"{ item.Id }, { item.FirstName }, { item.LastName }");
            }

            File.WriteAllLines(personTextFile, lines);
        }

        public static List<PersonalModel> GetAllPerson()
        {
            List<PersonalModel> output = new List<PersonalModel>();
            string[] content = File.ReadAllLines(personTextFile);

            foreach (var item in content)
            {
                string[] data = item.Split(',');
                int.TryParse(data[0], out int _id);
                output.Add(new PersonalModel { Id = _id, FirstName = data[1], LastName = data[2] });
            }

            return output;
        } 

        public static int GetNewId()
        {
            List<PersonalModel> output = new List<PersonalModel>();
            string[] content = File.ReadAllLines(personTextFile);
            return content.Length + 1;
        }
    }
}
