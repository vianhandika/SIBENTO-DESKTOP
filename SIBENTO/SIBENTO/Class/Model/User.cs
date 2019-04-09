using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIBENTO.Class.Model
{
    class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public string role { get; set; }
        public string branch { get; set; }

        public User(int id, string username, string name, string role, string branch)
        {
            this.id = id;
            this.username = username;
            this.name = name;
            this.role = role;
            this.branch = branch;
        }

        public override bool Equals(object obj)
        {
            var user = obj as User;
            return user != null &&
                   id == user.id;
        }

        public void Update(User User)
        {
            this.id = User.id;
            this.username = User.username;
            this.name = User.name;
            this.role = User.role;
            this.branch = User.branch;
        }
    }
}
