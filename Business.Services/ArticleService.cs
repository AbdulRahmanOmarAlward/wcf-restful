using Business.Entities;
using Business.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFRestFull.Core.Infrastructure;
using WCFRestFull.Core.Repositories;

namespace Business.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IUnitOfWork unitOfWork, IArticleRepository articleRepository)
        {
            _unitOfWork = unitOfWork;
            _articleRepository = articleRepository;
        }
        public void Add(Article article)
        {
            _articleRepository.Add(article);
            _unitOfWork.Commit();
        }

        public void Update(Article article)
        {
            _articleRepository.Update(article);
            _unitOfWork.Commit();
        }

        public void Delete(Article article)
        {
            _articleRepository.Delete(article);
            _unitOfWork.Commit();
        }

        public Article GetById(string id)
        {
            return _articleRepository.GetById(Convert.ToInt32(id));
        }

        public Article[] GetAll()
        {
            return _articleRepository.GetAll().ToArray();
        }
    }
}
