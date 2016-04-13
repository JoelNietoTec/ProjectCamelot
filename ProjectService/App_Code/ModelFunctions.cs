using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectModels;
using System.Data.Entity;

public partial class FirmService : ClientsInterface
{
    public List<ClientsData> GetClientsByLawyer(string Lawyer)
    {
        GALA_ServiceEntities contextDB;
        int iLawyer;

        try
        {
            iLawyer = int.Parse(Lawyer);
        }
        catch
        {
            return new List<ClientsData>();
        }
        using (contextDB = new GALA_ServiceEntities())
        {
            List<ClientsData> myClients = new List<ClientsData>();
            var myQuery = from clients in contextDB.Clients
                          where clients.LawyerId == iLawyer
                          select clients;

            foreach (var c in myQuery)
            {
                ClientsData cData = new ClientsData();
                cData.Id = c.Id;
                cData.Name = c.Name;
                cData.BillName = c.BillName;
                cData.ChargeAddress = c.ChargeAddress;
                cData.SendAddress = c.SendAddress;
                cData.PhoneNumber = c.PhoneNumber;
                cData.FaxNumber = c.FaxNumber;
                cData.Email = c.Email;
                cData.LawyerId = c.Lawyer.Id;
                cData.LawyerName = c.Lawyer.Name;
                cData.CountryName = c.Country.Name;
                cData.IndustryName = c.Industry.Name;
                cData.CreationDate = c.CreationDate;
                myClients.Add(cData);
            }
            return myClients;
        }
    }
    public List<CountriesData> GetCountries()
    {
        GALA_ServiceEntities contextDB;
        List<CountriesData> myCountries = new List<CountriesData>();
        using (contextDB = new GALA_ServiceEntities())
        {
            foreach (var c in contextDB.Countries)
            {
                CountriesData cData = new CountriesData();
                cData.Id = c.Id;
                cData.Name = c.Name;
                myCountries.Add(cData);
            }
            return myCountries;
        }
    }
    public List<LawyersData> GetLawyers()
    {
        GALA_ServiceEntities contextDB;
        List<LawyersData> myLawyers = new List<LawyersData>();
        using(contextDB = new GALA_ServiceEntities())
        {
            foreach(var l in contextDB.Lawyers)
            {
                LawyersData cData = new LawyersData();
                cData.Id = l.Id;
                cData.Name = l.Name;
                cData.Position = l.Position;
                cData.StartDate = l.StartDate;
                cData.AddDate = l.AddDate;
                myLawyers.Add(cData);
            }
            return myLawyers;
        }
    }
}