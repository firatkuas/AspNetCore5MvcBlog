using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public void AddBlog(Blog blog)
		{
			_blogDal.Add(blog);
		}

		public List<Blog> GetAllBlogs()
		{
			return _blogDal.GetAll();
		}

        public List<Blog> GetAllBlogsWithCategories()
        {
			return _blogDal.GetListWithCategory();
        }

        public Blog GetBlogById(int id)
		{
			return _blogDal.Get(id);
		}

		public void RemoveBlog(Blog category)
		{
			_blogDal.Remove(category);
		}

		public void UpdateBlog(Blog category)
		{
			_blogDal.Update(category);
		}
	}
}
