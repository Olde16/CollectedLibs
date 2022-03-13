using System;

namespace CollectedLibs
{
    public class LibInfo
    {
        public string version = "v0.0.5";
        public uint versionInt = 5;
        public string[] contributors = { "Olde16 : Ole Taege" };
        public bool original = true;
    }

    namespace Mathematics
    {
        public class Circle
        {

        }

        public class Square
        {

        }

    }

    namespace Objects
    {
        public class Customer
        {
            public uint UID { get; set; }
            public string cust_id { get; set; }
            public string name { get; set; }
            public string lastName { get; set; }
            public double age { get; set; }
            public string address_street { get; set; }
            public string address_number { get; set; }
            public string address_state { get; set; }
            public string address_country { get; set; }
            public DateTime cust_since { get; set; }
            public DateTime regist_since { get; set; }
            public DateTime dataEndOfLife { get; set; }
            public DateTime lastLogin { get; set; }
            public string storage { get; set; }

            public Customer(uint UID)
            {
                this.UID = UID;
            }
            public Customer(string cust_id)
            {
                this.cust_id = cust_id;
            }
            public Customer(uint UID, string cust_id)
            {
                this.UID = UID;
                this.cust_id = cust_id;
            }
            public Customer(uint UID, string name, string lastName)
            {
                this.UID = UID;
                this.name = name;
                this.lastName = lastName;
            }
            public Customer(uint UID, string name, string lastName, double age)
            {
                this.UID = UID;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
            }
            public Customer(uint UID, string name, string lastName, double age, string address_street)
            {
                this.UID = UID;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
            }
            public Customer(uint UID, string name, string lastName, double age, string address_street, string address_number)
            {
                this.UID = UID;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
            }
            public Customer(uint UID, string name, string lastName, double age, string address_street, string address_number, string address_state)
            {
                this.UID = UID;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
                this.address_state = address_state;
            }
            public Customer(uint UID, string name, string lastName, double age, string address_street, string address_number, string address_state, string address_country)
            {
                this.UID = UID;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
                this.address_state = address_state;
                this.address_country = address_country;
            }
            public Customer(uint UID, string name, string lastName, double age, string address_street, string address_number, string address_state, string address_country, DateTime cust_since)
            {
                this.UID = UID;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
                this.address_state = address_state;
                this.address_country = address_country;
                this.cust_since = cust_since;
            }
            public Customer(uint UID, string name, string lastName, double age, string address_street, string address_number, string address_state, string address_country, DateTime cust_since, DateTime regist_since)
            {
                this.UID = UID;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
                this.address_state = address_state;
                this.address_country = address_country;
                this.cust_since = cust_since;
                this.regist_since = regist_since;
            }
            public Customer(uint UID, string name, string lastName, double age, string address_street, string address_number, string address_state, string address_country, DateTime cust_since, DateTime regist_since, DateTime dataEndOfLife)
            {
                this.UID = UID;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
                this.address_state = address_state;
                this.address_country = address_country;
                this.cust_since = cust_since;
                this.regist_since = regist_since;
                this.dataEndOfLife = dataEndOfLife;
            }
            public Customer(uint UID, string name, string lastName, double age, string address_street, string address_number, string address_state, string address_country, DateTime cust_since, DateTime regist_since, DateTime dataEndOfLife, DateTime lastLogin)
            {
                this.UID = UID;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
                this.address_state = address_state;
                this.address_country = address_country;
                this.cust_since = cust_since;
                this.regist_since = regist_since;
                this.dataEndOfLife = dataEndOfLife;
                this.lastLogin = lastLogin;
            }
            public Customer(uint UID, string name, string lastName, double age, string address_street, string address_number, string address_state, string address_country, DateTime cust_since, DateTime regist_since, DateTime dataEndOfLife, DateTime lastLogin, string storage)
            {
                this.UID = UID;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
                this.address_state = address_state;
                this.address_country = address_country;
                this.cust_since = cust_since;
                this.regist_since = regist_since;
                this.dataEndOfLife = dataEndOfLife;
                this.lastLogin = lastLogin;
                this.storage = storage;
            }
            public Customer(string cust_id, string name, string lastName)
            {
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
            }
            public Customer(string cust_id, string name, string lastName, double age)
            {
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
            }
            public Customer(string cust_id, string name, string lastName, double age, string address_street)
            {
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
            }
            public Customer(string cust_id, string name, string lastName, double age, string address_street, string address_number)
            {
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
            }
            public Customer(string cust_id, string name, string lastName, double age, string address_street, string address_number, string address_state)
            {
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
                this.address_state = address_state;
            }
            public Customer(string cust_id, string name, string lastName, double age, string address_street, string address_number, string address_state, string address_country)
            {
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
                this.address_state = address_state;
                this.address_country = address_country;
            }
            public Customer(string cust_id, string name, string lastName, double age, string address_street, string address_number, string address_state, string address_country, DateTime cust_since)
            {
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
                this.address_state = address_state;
                this.address_country = address_country;
                this.cust_since = cust_since;
            }
            public Customer(string cust_id, string name, string lastName, double age, string address_street, string address_number, string address_state, string address_country, DateTime cust_since, DateTime regist_since)
            {
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
                this.address_state = address_state;
                this.address_country = address_country;
                this.cust_since = cust_since;
                this.regist_since = regist_since;
            }
            public Customer(string cust_id, string name, string lastName, double age, string address_street, string address_number, string address_state, string address_country, DateTime cust_since, DateTime regist_since, DateTime dataEndOfLife)
            {
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
                this.address_state = address_state;
                this.address_country = address_country;
                this.cust_since = cust_since;
                this.regist_since = regist_since;
                this.dataEndOfLife = dataEndOfLife;
            }
            public Customer(string cust_id, string name, string lastName, double age, string address_street, string address_number, string address_state, string address_country, DateTime cust_since, DateTime regist_since, DateTime dataEndOfLife, DateTime lastLogin)
            {
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
                this.address_state = address_state;
                this.address_country = address_country;
                this.cust_since = cust_since;
                this.regist_since = regist_since;
                this.dataEndOfLife = dataEndOfLife;
                this.lastLogin = lastLogin;
            }
            public Customer(string cust_id, string name, string lastName, double age, string address_street, string address_number, string address_state, string address_country, DateTime cust_since, DateTime regist_since, DateTime dataEndOfLife, DateTime lastLogin, string storage)
            {
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
                this.address_state = address_state;
                this.address_country = address_country;
                this.cust_since = cust_since;
                this.regist_since = regist_since;
                this.dataEndOfLife = dataEndOfLife;
                this.lastLogin = lastLogin;
                this.storage = storage;
            }
            public Customer(uint UID, string cust_id, string name, string lastName)
            {
                this.UID = UID;
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
            }
            public Customer(uint UID, string cust_id, string name, string lastName, double age)
            {
                this.UID = UID;
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
            }
            public Customer(uint UID, string cust_id, string name, string lastName, double age, string address_street)
            {
                this.UID = UID;
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
            }
            public Customer(uint UID, string cust_id, string name, string lastName, double age, string address_street, string address_number)
            {
                this.UID = UID;
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
            }
            public Customer(uint UID, string cust_id, string name, string lastName, double age, string address_street, string address_number, string address_state)
            {
                this.UID = UID;
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
                this.address_state = address_state;
            }
            public Customer(uint UID, string cust_id, string name, string lastName, double age, string address_street, string address_number, string address_state, string address_country)
            {
                this.UID = UID;
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
                this.address_state = address_state;
                this.address_country = address_country;
            }
            public Customer(uint UID, string cust_id, string name, string lastName, double age, string address_street, string address_number, string address_state, string address_country, DateTime cust_since)
            {
                this.UID = UID;
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
                this.address_state = address_state;
                this.address_country = address_country;
                this.cust_since = cust_since;
            }
            public Customer(uint UID, string cust_id, string name, string lastName, double age, string address_street, string address_number, string address_state, string address_country, DateTime cust_since, DateTime regist_since)
            {
                this.UID = UID;
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
                this.address_state = address_state;
                this.address_country = address_country;
                this.cust_since = cust_since;
                this.regist_since = regist_since;
            }
            public Customer(uint UID, string cust_id, string name, string lastName, double age, string address_street, string address_number, string address_state, string address_country, DateTime cust_since, DateTime regist_since, DateTime dataEndOfLife)
            {
                this.UID = UID;
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
                this.address_state = address_state;
                this.address_country = address_country;
                this.cust_since = cust_since;
                this.regist_since = regist_since;
                this.dataEndOfLife = dataEndOfLife;
            }
            public Customer(uint UID, string cust_id, string name, string lastName, double age, string address_street, string address_number, string address_state, string address_country, DateTime cust_since, DateTime regist_since, DateTime dataEndOfLife, DateTime lastLogin)
            {
                this.UID = UID;
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
                this.address_state = address_state;
                this.address_country = address_country;
                this.cust_since = cust_since;
                this.regist_since = regist_since;
                this.dataEndOfLife = dataEndOfLife;
                this.lastLogin = lastLogin;
            }
            public Customer(uint UID, string cust_id, string name, string lastName, double age, string address_street, string address_number, string address_state, string address_country, DateTime cust_since, DateTime regist_since, DateTime dataEndOfLife, DateTime lastLogin, string storage)
            {
                this.UID = UID;
                this.cust_id = cust_id;
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.address_street = address_street;
                this.address_number = address_number;
                this.address_state = address_state;
                this.address_country = address_country;
                this.cust_since = cust_since;
                this.regist_since = regist_since;
                this.dataEndOfLife = dataEndOfLife;
                this.lastLogin = lastLogin;
                this.storage = storage;
            }
            
            public string get_fullName()
            {
                return this.name + " " + this.lastName;
            }
            public int get_normalisedAge()
            {
                if (this.age == double.NaN || this.age == double.NegativeInfinity || this.age == double.PositiveInfinity) return 0;
                return (int)Math.Floor(this.age);
            }
            public string get_fullAddress()
            {
                return (this.address_street + " " + this.address_number + " " + this.address_state + " " + this.address_country).Trim();
            }
        }
        public class Phone
        {

        }
    }
}
