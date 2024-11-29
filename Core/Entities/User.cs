namespace FinanceBackEnd.Core.Entities
{
    public class User
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Role[] Roles { get; set; }
        public Account[] Accounts { get; set; }
        public Portfolio[] Portfolios { get; set; }
        //Crear patrimonio total y guardar logs diarios de patrimonio
        //Currency
    }
}
