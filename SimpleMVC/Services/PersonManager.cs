using SimpleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMVC.Services
{
    public class PersonManager
    {
        public PersonModel[] GetPeople()
        {
            return new PersonModel[]
            {
                new PersonModel
                {
                    Age = 10,
                    FirstName = "Person",
                    LastName = "One"
                },
                new PersonModel
                {
                    Age = 10,
                    FirstName = "Person",
                    LastName = "One"
                },
                new PersonModel
                {
                    Age = 10,
                    FirstName = "Person",
                    LastName = "One"
                },
                new PersonModel
                {
                    Age = 10,
                    FirstName = "Person",
                    LastName = "One"
                }
            };
        }
    }
}
