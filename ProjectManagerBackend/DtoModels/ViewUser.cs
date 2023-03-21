using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerBackend.DtoModels
{
    public class ViewUser
    {
        public ViewUser(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return Id+" "+Name +" "+Surname;
        }
    }
}
