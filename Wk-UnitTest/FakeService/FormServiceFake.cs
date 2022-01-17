using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WKBackend.Model;
using WKBackend.Repository;

namespace Wk_UnitTest.FakeService
{
    public class FormServiceFake : IFormsRepository
    {
        private readonly List<Form> _forms;
        private readonly List<Parent> _parents;
        public FormServiceFake()
        {
            _forms = new List<Form>()
            {
                new Form(){FormId=1, Name="test1"},
                new Form(){FormId=2,Name="test2"}
            };
            _parents = new List<Parent>()
            {
                new Parent()
                {
                    FormId=1,
                    Name="Ukabhai",
                    ParentId=1,
                    Children =new Child()
                    {
                            FirstName = "Bhaveshb",
                                    LastName = "Narola",
                                    MiddleName = "U",
                                    City = "Surat",
                                    ContactNumber = "+610475785218",
                                    ParentId = 1
                    },
                }
            };
        }

        public List<Parent> GetFormDetailsById(int id)
        {
            return _parents.Where(x => x.FormId == id).ToList();
        }

        public List<Form> GetForms()
        {
            return _forms;
        }
    }
}
