using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json;

namespace WindowsFormsApp3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class Module {
        public Module()
        {
            using (var fileStream = File.Open("./users.json", FileMode.OpenOrCreate, FileAccess.ReadWrite)) { }
        }
        public User signUp(string wUsername, string wFirstname, string wLastname, string wPassword, DateTime dateTime, string wGender)
        {
            List<User> ro = new List<User>();

            using (StreamReader r = new StreamReader(@"./users.json"))
            {
                string json = r.ReadToEnd();
                if (!json.Trim().Equals(""))
                {
                    ro = JsonConvert.DeserializeObject<List<User>>(json);
                }
            }

            ro.Add(new User(wUsername, wFirstname, wLastname, wPassword, dateTime, wGender));

            using (StreamWriter w = new StreamWriter(@"./users.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(w, ro);
                return new User(wUsername, wFirstname, wLastname, wPassword, dateTime, wGender);
            }
        }

        public User Login(string wUsername, string wPassword)
        {
            List<User> ro = new List<User>();

            using (StreamReader r = new StreamReader(@"./users.json"))
            {
                string json = r.ReadToEnd();
                if (!json.Trim().Equals(""))
                {
                    ro = JsonConvert.DeserializeObject<List<User>>(json);
                }
            }

            User result = (from temp in ro
                           where temp.Username == wUsername && temp.Password == wPassword
                           select temp).SingleOrDefault();

            return result;
        }
    }

    class User
    {
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }

        public User(string wUsername, string wFirstname, string wLastname, string wPassword, DateTime wBirthday, string wGender)
        {
            Username = wUsername;
            Firstname = wFirstname;
            Lastname = wLastname;
            Password = wPassword;
            Birthday = wBirthday;
            Gender = wGender;
        }
        public User() { }
    }
}
