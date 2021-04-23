using System;

namespace FriendAssembly
{
    internal class FriendlyClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FriendlyClass(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}