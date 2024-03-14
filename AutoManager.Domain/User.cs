using AutoManager.Domain.Abstractions.Interfaces;

namespace AutoManager.Domain
{
    public class User : IUser
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public IRole Role { get; set; }        

        public IUser Get(string Name)
        {
            throw new NotImplementedException();
        }

        public IUser Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}