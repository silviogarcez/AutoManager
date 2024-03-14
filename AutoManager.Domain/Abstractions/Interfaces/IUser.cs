using AutoManager.Domain.Abstractions.Enums;

namespace AutoManager.Domain.Abstractions.Interfaces
{
    public interface IUser
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public string BirthDate { get; set; }
        public ICnh Cnh { get; set; }
        public UserType UserType { get; set; }
        public bool CanRent { get; set; }
        public IUser Get(string Name);
        public IUser Get(int id);
        public bool Insert(IUser user);
        public bool Update(int id, ICnh cnh);

    }
}
