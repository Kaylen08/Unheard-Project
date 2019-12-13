﻿using SQLite;

namespace UnheardApi.Models
{
    public class User
    {

        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }

        public string UserName { get; set; }


        public string Email { get; set; }

    
        public string Password { get; set; }


        public string Gender { get; set; }


    }
}

