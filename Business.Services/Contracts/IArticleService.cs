using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Contracts
{
    [ServiceContract]
    public interface IArticleService
    {
        [OperationContract]
        void Add(Article article);

        [OperationContract]
        void Update(Article article);

        [OperationContract]
        void Delete(Article article);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Article/{id}")]
        Article GetById(string id);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetAll")]
        Article[] GetAll();
    }
}
