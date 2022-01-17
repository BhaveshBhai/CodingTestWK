using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WKBackend.Model;

namespace WKBackend.Repository
{
    public class FormsRepository : IFormsRepository
    {
        private readonly WKDBContext _wkDBContext;
        public FormsRepository(WKDBContext wKDBContext)
        {
            _wkDBContext = wKDBContext;
        }
        public List<Form> GetForms()
        {
            return _wkDBContext.Forms.Local.ToList();
        }
        public List<Parent> GetFormDetailsById(int id)
        {
            var lstParent = _wkDBContext.Parents.Local.Where(x => x.FormId == id).ToList();
            return lstParent;
        }

    }
}
