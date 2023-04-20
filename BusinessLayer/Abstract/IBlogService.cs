using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogService
	{
		void AddBlog(Blog blog);
		void RemoveBlog(Blog category);
		void UpdateBlog(Blog category);
		List<Blog> GetAllBlogs();
		List<Blog> GetAllBlogsWithCategories();
		Blog GetBlogById(int id);
	}
}
