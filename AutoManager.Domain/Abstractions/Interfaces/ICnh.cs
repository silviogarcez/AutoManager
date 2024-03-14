using AutoManager.Domain.Abstractions.Enums;

namespace AutoManager.Domain.Abstractions.Interfaces
{
    public interface ICnh
    {
        public string Cnh { get; set; }
        public List<CnhType> CnhType { get; set; }
        public string Image { get; set; }
    }
}
