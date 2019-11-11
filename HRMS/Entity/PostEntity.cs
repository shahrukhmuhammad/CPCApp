using AutoMapper;
using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS
{
    public class PostEntity
    {
        private SOSHRMSEntities context;


        public List<Post> GetAllPosts()
        {
            try
            {
                using (context = new SOSHRMSEntities())
                {
                    return context.Posts.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Post> GetPostById(Guid Id)
        {
            try
            {
                using (context = new SOSHRMSEntities())
                {
                    return context.Posts.Where(x=> x.PostId == Id).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CustomSelectList> GetPostsDropdown(Guid? Id = null)
        {
            try
            {
                using (context = new SOSHRMSEntities())
                {
                    var ls = new List<Post>();
                    if (Id.HasValue)
                    {
                        ls = context.Posts.Where(x => x.PostId == Id).ToList();
                        return ls.Select(x => new CustomSelectList { Value = x.PostId.ToString(), Text = x.PostName }).ToList();
                    }
                    ls = context.Posts.ToList();
                    return ls.Select(x => new CustomSelectList { Value = x.PostId.ToString(), Text = x.PostName }).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
