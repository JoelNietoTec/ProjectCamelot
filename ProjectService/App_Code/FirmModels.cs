using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[DataContract]
public class ClientsData
{
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public string BillName { get; set; }
    [DataMember]
    public string ChargeAddress { get; set;  }
    [DataMember]
    public string SendAddress { get; set; }
    [DataMember]
    public string PhoneNumber { get; set; }
    [DataMember]
    public string FaxNumber { get; set; }
    [DataMember]
    public string Email { get; set; }
    [DataMember]
    public int LawyerId { get; set; }
    [DataMember]
    public string LawyerName { get; set; }
    [DataMember]
    public int CountryId { get; set; }
    [DataMember]
    public string CountryName { get; set; }
    [DataMember]
    public string IndustryId { get; set; }
    [DataMember]
    public string IndustryName { get; set; }
    [DataMember]
    public DateTime? CreationDate { get; set; }
}

public class LawyersData
{
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public string Position { get; set; }
    [DataMember]
    public DateTime ? AddDate { get; set; }
    [DataMember]
    public DateTime ? StartDate { get; set; }
}

public class CountriesData
{
    public int Id { get; set; }
    public string Name { get; set; }
}