namespace TinyShoppingCart.Server.Domain.Entities
{
    public class ProductCategory : VerAudEntity
    {
        public string Name {get;set;}

        public int? ParentId {get;set;}

        public ProductCategory Parent {get;set;}
    }
}