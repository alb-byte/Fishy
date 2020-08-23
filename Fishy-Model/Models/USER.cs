using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Windows.Media.Imaging;

namespace Fishy_Model.Models
{
    [Serializable]
    public class User : BaseModel,ISerializable,IDataErrorInfo
    {
        private int id;
        private string firstName;
        private string lastName;
        private int age;
        private string email;
        private string password;
        private string city;
        private string info;
        private BitmapImage avatar;
        private bool administrator;
        private int countOfFriends;
        public User(int id, string fname, string lname, int age, string email, string password,
                    string city, string info, BitmapImage avatar, bool administrator, int countOfFriends)
        {
            this.Id = id;
            this.FirstName = fname;
            this.LastName = lname;
            this.Age = age;
            this.Email = email;
            this.Password = password;
            this.city = city;
            this.info = info;
            this.Avatar = avatar;
            this.Administrator = administrator;
            this.CountOfFriends = countOfFriends;
        }
        public User(string fname, string lname, string email, string password):this(email,password)
        {
            this.FirstName = fname;
            this.LastName = lname;
        }
        public User(int id, string fname, string lname, BitmapImage avatar):this(id)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Avatar = avatar;
        }
        public User(string email, string password):this()
        {
            this.Email = email;
            this.Password = password;
        }
        public User(int id):this()
        {
            this.Id = id;
        }
        public User()
        {
            this.FirstName = String.Empty;
            this.LastName = String.Empty;
            this.Email = String.Empty;
            this.Password = String.Empty;
            this.City = String.Empty;
            this.Info = String.Empty;
            this.Avatar = null;
        }
        public User(User u)
        {
            this.Id = u.Id;
            this.FirstName = u.FirstName;
            this.LastName = u.LastName;
            this.Age = u.Age;
            this.Email = u.Email;
            this.Password = u.Password;
            this.City = u.City;
            this.Info = u.Info;
            this.Administrator = u.Administrator;
            this.CountOfFriends = u.CountOfFriends;
            this.Avatar = u.Avatar;
        }
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
                OnPropertyChanged("Age");
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }
        public string City
        {
            get { return city; }
            set
            {
                city = value;
                OnPropertyChanged("City");
            }
        }
        public string Info
        {
            get { return info; }
            set
            {
                info = value;
                OnPropertyChanged("Info");
            }
        }
        public BitmapImage Avatar
        {
            get
            {
                return avatar;
            }
            set
            {
                avatar = value;
                OnPropertyChanged("Avatar");

            }
        }
        public bool Administrator
        {
            get
            {
                return administrator;
            }
            set
            {
                administrator = value;
                OnPropertyChanged("Administrator");
            }
        }
        public int CountOfFriends
        {
            get
            {
                return countOfFriends;
            }
            set
            {
                countOfFriends = value;
                OnPropertyChanged("CountOfFriends");
            }
        }
        public override string ToString()
        {
            return $"ID: {Id}\n" +
                $"FirstName: {FirstName}\n" +
                $"LastName: {LastName}\n" +
                $"Age: {Age}\n" +
                $"City: {City}\n" +
                $"Email: {Email}\n" +
                $"Password: {Password}\n" +
                $"Info: {Info}\n" +
                $"Administrator: {Administrator}\n" +
                $"CountOfFriend: {CountOfFriends}\n" +
                $"--------------------------------";
        }
        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Id":
                        {
                            if (Id < 0)
                            {
                                error = "Id должен быть больше 0 ";
                            }
                            break;
                        }
                    case "FirstName":
                        {
                            if (!(new Regex(@"^([A-Z]{1}[a-z]{1,14})|([А-ЯЁ]{1}[а-яё]{1,14})$").Match(FirstName).Success) && !String.IsNullOrWhiteSpace(FirstName))
                            {
                                error = "Имя должно начинаться с заглавной буквы, не должно содержать цифр и быть длиннее 15 символов";
                            }
                            break;
                        }
                    case "LastName":
                        {
                            if (!(new Regex(@"^([A-Z]{1}[a-z]{1,14})|([А-ЯЁ]{1}[а-яё]{1,14})$").Match(LastName).Success) && !String.IsNullOrWhiteSpace(LastName))
                            {
                                error = "Фамилия должна начинаться с заглавной буквы, не должна содержать цифр и быть длиннее 15 символов";
                            }
                            break;
                        }
                    case "Age":
                        {
                            if ((Age < 0) || (Age > 100))
                            {
                                error = "Возраст должен быть больше 0 и меньше 100";
                            }
                            break;
                        }
                    case "Email":
                        {
                            if (!(new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$").Match(Email).Success) && !String.IsNullOrWhiteSpace(Email))
                            {
                                error = "Неверный формат почты";
                            }
                            break;
                        }
                    case "Password":
                        {
                            break;
                        }
                    case "City":
                        {

                            if (!(new Regex(@"^([A-Z]{1}[a-z]{1,14})|([А-ЯЁ]{1}[а-яё]{1,14})$").Match(City).Success) && !String.IsNullOrWhiteSpace(City))
                            {
                                error = "Допущена ошибка в названии города";
                            }
                            break;
                        }
                    case "Info":
                        {
                            if (Info.Length > 200)
                            {
                                error = "Превышена длинна поля либо используются не допустимые символы";
                            }
                            break;
                        }
                    case "CountOfFriens":
                        {
                            if (Age < 0)
                            {
                                error = "Количество друзей не может быть меньше 0";
                            }
                            break;
                        }
                }
                return error;
            }
        }
        public string Error
        {
            get { throw new NotImplementedException(); }
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ID", this.Id);
            info.AddValue("FIRSTNAME", this.FirstName);
            info.AddValue("LASTNAME", this.LastName);
            info.AddValue("AGE", this.Age);
            info.AddValue("EMAIL", this.Email);
            info.AddValue("PASS", this.Password);
            info.AddValue("CITY", this.City);
            info.AddValue("INFO", this.Info);
            info.AddValue("ADMIN", this.Administrator);
            byte[] arr = EncodeImage(Avatar);
            info.AddValue("AVATAR", arr);
            info.AddValue("COUNTOFFRIENDS", this.CountOfFriends);

        }
        public User(SerializationInfo info, StreamingContext context)
        {
            this.Id = (int)info.GetValue("ID", typeof(int));
            this.FirstName = (string)info.GetValue("FIRSTNAME", typeof(string));
            this.LastName = (string)info.GetValue("LASTNAME", typeof(string));
            this.Age = (int)info.GetValue("AGE", typeof(int?));
            this.Email = (string)info.GetValue("EMAIL", typeof(string));
            this.Password = (string)info.GetValue("PASS", typeof(string));
            this.City = (string)info.GetValue("CITY", typeof(string));
            this.Info = (string)info.GetValue("INFO", typeof(string));
            this.Administrator = (bool)info.GetValue("ADMIN", typeof(bool));
            this.Avatar = DecodeImage((byte[])info.GetValue("AVATAR", typeof(byte[])));
            this.CountOfFriends = (int)info.GetValue("COUNTOFFRIENDS", typeof(int));
        }
        public static explicit operator User(USER u)
        {
            User user = new User()
            {
                Id = u.ID,
                FirstName = u.FIRSTNAME,
                LastName = u.LASTNAME,
                Age = u.AGE ?? 0,
                Email = u.EMAIL,
                Password = u.PASS,
                City = u.CITY,
                Info = u.INFO,
                Administrator = u.ADMIN,
                CountOfFriends = u.FRIENDS.Count
            };
            if (!String.IsNullOrEmpty(u.IMG))
            {
                user.Avatar = BitmapToBitmapImage(new Bitmap(u.IMG));
            }
            return user;
        }
        public static explicit operator USER(User u)
        {
            USER user = new USER
            {
                ID = u.Id,
                FIRSTNAME = u.FirstName,
                LASTNAME = u.LastName,
                AGE = u.Age,
                EMAIL = u.Email,
                PASS = u.Password,
                CITY = u.City,
                INFO = u.Info,
                ADMIN = u.Administrator
            };
            if (u.Avatar != null)
            {
                user.IMG = @"Users\user" + u.Id + ".jpg";
                Image bitmap = Bitmap.FromStream(new MemoryStream(EncodeImage(u.Avatar)));
                FileStream fs = new FileStream(user.IMG, FileMode.Create);
                bitmap.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            return user;
        }
    }
}
