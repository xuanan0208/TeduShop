using System;
using System.Collections.Generic;
using TeduShop.Data.Infastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Model;

namespace TeduShop.Service
{
    public interface IPostService
    {
        void Add(Post Post);

        void Update(Post Post);

        void Delete(int id);

        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetAllPaging(int page, int PageSize, out int totalRow);

        Post GetById(int id);

        IEnumerable<Post> GetAllTagPaging(string tag,int page, int pageSize, out int totalRow);

        void SaveChange();
    }

    public class PostService : IPostService
    {
        IPostRepository _postRepository;
        IUnitOfWork _unitofwork;
        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitofwork = unitOfWork;
        }
        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Delete(int id)
        {
            _postRepository.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll(new string[] { "PostCategory"});
        }

        public IEnumerable<Post> GetAllTagPaging(string tag,int page, int PageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x=>x.Status == true,out totalRow,page,PageSize);
        }

        public IEnumerable<Post> GetAllPaging (int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public void SaveChange()
        {
            _unitofwork.Commit();
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }
    }
}