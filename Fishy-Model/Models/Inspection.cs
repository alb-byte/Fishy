using System;

namespace Fishy_Model.Models
{
    [Serializable]
    public class StateInspection : BaseModel
    {
        private int id;
        private string region;
        private string address;
        private string phone;
        public StateInspection(int id, string region, string address, string phone)
        {
            this.Id = id;
            this.Region = region;
            this.Address = address;
            this.Phone = phone;
        }
        public StateInspection(){  }
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                OnPropertyChanged("Address");
            }
        }
        public string Region
        {
            get { return region; }
            set
            {
                region = value;
                OnPropertyChanged("Region");
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                OnPropertyChanged("Phone");
            }
        }
    }
}
