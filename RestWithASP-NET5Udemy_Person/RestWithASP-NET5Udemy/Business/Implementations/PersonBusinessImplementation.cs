﻿using RestWithASP_NET5Udemy.Model;
using RestWithASP_NET5Udemy.Model.Context;
using RestWithASP_NET5Udemy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithASP_NET5Udemy.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IPersonRepository _repository;
        public PersonBusinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }
        public Person FindByID(long id)
        {
            return _repository.FindByID(id);
        }
        public Person Create(Person person)
        {
            return _repository.Create(person);
        }
        public Person Update(Person person)
        {
            return _repository.Update(person);
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
