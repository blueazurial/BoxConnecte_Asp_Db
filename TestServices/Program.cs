﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoxConnecte.Entities;
using BoxConnecte.repositories;

namespace TestServices
{
    class Program
    {
        static void Main(string[] args)
        {
            #region test service insert sur people et address 
            ////test des service 
            //// insert de la table People pour insert une personne 
            ////pour ca une crée un new PeopleRepository 
            //PeopleRepository insertPersonne1 = new PeopleRepository();
            ////on crée une nouvelle personne 
            //People personne1 = new People();
            //personne1.FirstName = "yolo";
            //personne1.LastName = "does";
            //personne1.Gsm = 0445841809;
            //personne1.Email = "youyyyd@hotmail.com";
            //personne1.Birthdate = new DateTime(1895, 10, 04);
            ////insert une adresse 
            //AddressRepository insertaddress1 = new AddressRepository();
            ////on crée une nouvelle adresse qu on vas lie a la personne 1
            //Address address1 = new Address();
            ////on ramplis chaque chan 
            //address1.City = "voo";
            //address1.Number = 2;
            //address1.PostalCode = 1000;
            //address1.Street = "rue toutuit";
            ////j utilise insertaddress1 le repository crée au prealable .insert pour apliquer la methode insert sur l object addresse1
            //address1.Id = insertaddress1.Insert(address1);
            ////j insert id de l'object addresse1 pmour qu'il corespond a l'addresseId de personne1 
            //personne1.AddressId = address1.Id;
            ////insert ma personne1 dans la db 
            //personne1.Id = insertPersonne1.Insert(personne1);
            #endregion
            #region test getall et get address et people

            //////////////////////////GET/////////////////////////////////////////
            //PeopleRepository service = new PeopleRepository();
            //People people1 = new People();
            ////on utilise le get avec argument l id du people
            //people1 = service.Get(6);
            ////la je veux juste resortire le lastName
            //Console.WriteLine (people1.LastName);

            //AddressRepository serviceGET = new AddressRepository();
            //Address address = new Address();

            //address = serviceGET.Get(9);

            //Console.WriteLine(address.City);

            //////////////////////////////GETALL///////////////////////////////////

            //PeopleRepository serviceGetALL = new PeopleRepository();
            ////iIEnumerable est une eterface et une interface n est pas est listenciable 

            ////get all des people
            //IEnumerable<People> allPeople = serviceGetALL.GetAll();
            //foreach (var item in allPeople)
            //{
            //    Console.WriteLine(item.Gsm);
            //}
            // //get all des address 

            //AddressRepository serviceGetALLAd = new AddressRepository(); 
            //IEnumerable<Address> allAddress = serviceGetALLAd.GetAll();
            ////foreach est utiliser parce qu il y a plusieur adresse a sortire 
            //foreach (var item in allAddress)
            //{
            //    Console.WriteLine(item.Street);
            //}

            #endregion

            #region test delete people and address

            //AddressRepository supAddress = new AddressRepository();                        
            //supAddress.Delete(7);

            //PeopleRepository supPeople = new PeopleRepository();
            //supPeople.Delete(6);

            #endregion


            #region test update poeple and adress

            

            #endregion
            Console.ReadLine();
        }
    }
}
