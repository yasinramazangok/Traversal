using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubAboutManager : ISubAboutService
    {
        private readonly ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void Delete(SubAbout entity)
        {
            _subAboutDal.Delete(entity);
        }

        public SubAbout GetById(int id)
        {
            return _subAboutDal.GetById(id);
        }

        public List<SubAbout> GetList()
        {
            return _subAboutDal.GetList();
        }

        public void Insert(SubAbout entity)
        {
            _subAboutDal.Insert(entity);
        }

        public void Update(SubAbout entity)
        {
            _subAboutDal.Update(entity);
        }
    }
}
