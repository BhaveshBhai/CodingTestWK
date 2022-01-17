using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WKBackend.Model;

namespace WKBackend.Repository
{
   public interface IFormsRepository
    {
        List<Form> GetForms();
        List<Parent> GetFormDetailsById(int id);
    }
}
