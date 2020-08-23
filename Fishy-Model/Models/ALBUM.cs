using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Fishy_Model.Models
{
    [Serializable]
    public class Album :BaseModel, IDataErrorInfo
    {
        private int id;
        private string name;
        private int owner_id;
        public Album(int id, int owner_id, string name)
        {
            this.Id = id;
            this.Owner = owner_id;
            this.Name = name;
        }
        public Album(Album a)
        {
            this.Owner = a.Owner;
            this.Name = a.Name;
        }
        public Album()
        {
            this.Name = String.Empty;
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
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public int Owner
        {
            get { return owner_id; }
            set
            {
                owner_id = value;
                OnPropertyChanged("Owner");
            }
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
                                error = "Идентификатор альбома не может быть меньше 0";
                            }
                            break;
                        }
                    case "Name":
                        {
                            if (Name.Length > 15)
                            {
                                error = "Превышена длинна имени альбома";
                            }
                            break;
                        }
                    case "Owner":
                        {
                            if (Owner < 0)
                            {
                                error = "Идентификатор владельца альбома не может быть меньше 0";
                            }
                            break;
                        }
                }
                return error;
            }
        }
        public string Error => throw new NotImplementedException();

    }
}