using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ProjectModels;

[ServiceContract]
public interface ClientsInterface
{
    [OperationContract(), WebGet(UriTemplate ="/ClientsByLawyer/{Lawyer}", BodyStyle =WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
    List<ClientsData> GetClientsByLawyer(string Lawyer);
    [OperationContract(), WebGet(UriTemplate = "/Countries", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
    List<CountriesData> GetCountries();
    [OperationContract(), WebGet(UriTemplate = "/Lawyers", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
    List<LawyersData> GetLawyers();
}