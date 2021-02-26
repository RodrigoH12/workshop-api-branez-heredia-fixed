﻿using System;
using System.Collections.Generic;
using Database.Database.Models;

namespace Database.Database
{
    public interface IWorkshopTableDB
    {
        public List<Workshop> GetAll(); //Get, Read all in Database
        public Workshop Create(Workshop workshop); //Post
        public Workshop Update(Workshop workshop); //Put
        public Workshop DeleteById(string id); //Delete a Workshop by its ID
    }
}

